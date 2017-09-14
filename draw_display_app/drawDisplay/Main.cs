using System;
using System.Management;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Linq;

namespace drawDisplay
{
    public partial class frmMain : Form
    {
        Graphics graphics;
        Brush brush = Brushes.White;

        Display display;

        bool draw;
        string[] ports;

        enum Error
        {
            COMPortNotOpen,
            COMOpenError,
            COMNoPortsAvailable
        }

        public frmMain()
        {
            InitializeComponent();
            SetPanel();

            graphics = panelDrawArea.CreateGraphics();
            display = new Display();

            lblCursorX.Text = "X:";
            lblCursorY.Text = "Y:";

            draw = false;

            UpdateCOMportList();
        }

        #region panel

        /* Init panel */
        void SetPanel()
        {
            panelDrawArea.Height = Display.Height;
            panelDrawArea.Width = Display.Width;
            panelDrawArea.BackColor = Color.Black;
        }

        /* Mouse moves over panel area */
        private void panelDrawArea_MouseMove(
            object sender, MouseEventArgs e)
        {
            lblCursorX.Text = "X: " + e.Location.X.ToString();
            lblCursorY.Text = "Y: " + e.Location.Y.ToString();

            if (draw)
            {
                graphics.FillRectangle(
                    brush,
                    e.Location.X,
                    e.Location.Y,
                    int.Parse(textBoxDrawSize.Text),
                    int.Parse(textBoxDrawSize.Text)
                );

                display.SetPixel(true, e.Location.X, e.Location.Y);
            }
        }

        /* Mouse button down, over panel area */
        private void panelDrawArea_MouseDown(
            object sender, MouseEventArgs e)
        {
            draw = true;
        }

        /* Mouse button up, over panel area */
        private void panelDrawArea_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        #endregion

        private void btnGenXBM_Click(object sender, System.EventArgs e)
        {
            textBoxXBMArray.Clear();

            string content = "";

            for (int i = 0; i < display.GetNumberOfXBMBytes(); i++)
            {
                content += display.XBMArrayToString(i) + "\r\n";

            }

            textBoxXBMArray.Text = content;
        }

        private void btnShowPix_Click(object sender, System.EventArgs e)
        {
            textBoxXBMArray.Clear();

            string content = "";

            for (int i = 0; i < display.GetNumberOfPixels(); i++)
            {
                content += display.PixelToString(i) + "\r\n";
            }

            textBoxXBMArray.Text = content;
        }

        private void btnXBMCode_Click(object sender, System.EventArgs e)
        {
            textBoxXBMArray.Clear();

            byte[] array = display.GenerateXBMImage();

            string content = "const char test_bits[] = { \r\n";

            for (int i = 0; i < array.Length; i++)
            {
                content += "0x" + array[i].ToString("X2") + ", ";

                if (i % 10 == 10)
                {
                    content += "\r\n";
                }
            }

            content += "};";

            textBoxXBMArray.Text = content;
        }

        #region comport
        private void comboBoxPorts_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            serialPort.Close();

            string newPort = (
                comboBoxPorts.SelectedItem
                as ComboboxItem).Value.ToString();

            textBoxData.AppendText("Changing port " +
                serialPort.PortName + "->" + newPort + "\r\n");

            if (OpenCOM(newPort))
            {
                ;
            }
        }

            /* Open COM-Port */
            bool OpenCOM(string portName)
        {
            bool success = true;

            if (!serialPort.IsOpen)
            {

                try
                {
                    serialPort.PortName = portName;
                    serialPort.Open();

                    textBoxData.AppendText(
                        "Port " + serialPort.PortName +
                        " öppnad!\r\n");
                }

                catch (Exception)
                {
                    DisplayError(Error.COMOpenError,
                        serialPort.PortName);
                    success = false;
                }

            }

            return success;
        }

        /* Update drop-down list with available COM-ports */
        void UpdateCOMportList()
        {
            ports = SerialPort.GetPortNames();

            Array.Sort(ports);

            comboBoxPorts.Items.Clear();

            /* Populate combobox with ports 
             * (port names and device names) */
            foreach (string port in ports)
            {
                ComboboxItem item = new ComboboxItem();

                item.Text = port + ": " + SerialPortDeviceName(port);
                item.Value = port;

                comboBoxPorts.Items.Add(item);
            }
        }

        /* Gets device name for COM-port */
        private string SerialPortDeviceName(string portName)
        {
            using (var searcher = new ManagementObjectSearcher
               ("SELECT * FROM WIN32_SerialPort"))
            {
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();

                foreach (var port in ports)
                {
                    if (portName == port["DeviceID"].ToString())
                    {
                        return port["Name"].ToString();
                    }
                }
            }

            return "Not Found";
        }

        #endregion

        #region errors

        /* Display errors in data textbox */
        private void DisplayError(Error error, string extra = "")
        {
            textBoxData.AppendText("Error: ");

            switch (error)
            {
                case Error.COMPortNotOpen:
                    textBoxData.AppendText(
                        "COM-port not open!");
                    break;

                case Error.COMOpenError:
                    textBoxData.AppendText(
                        "Cannot open port " + extra + "!");
                    break;

                case Error.COMNoPortsAvailable:
                    textBoxData.AppendText(
                        "No COM-ports available!");
                    break;

                default:
                    break;
            }

            textBoxData.AppendText("\r\n");
        }


        #endregion

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] array = display.GenerateXBMImage();

            serialPort.Write(array, 0, array.Length);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.Black);
            display.Reset();

        }
    }

    /* Override combobox ToString, 
    * to have different text/value */
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
