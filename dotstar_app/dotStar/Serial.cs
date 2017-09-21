using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace dotStar
{
    public partial class Main : Form
    {
        string[] ports;



        private void serialPort_DataReceived(
            object sender, SerialDataReceivedEventArgs e)
        {
            serialData = serialPort.ReadLine();
            this.Invoke(new EventHandler(DisplayText));
        }

        /* Display serial data in textbox */
        private void DisplayText(object o, EventArgs e)
        {
            /* Display data in textbox */
            textBoxData.AppendText(serialData + "\r\n");
        }

        /* Update drop-down list with available COM-ports */
        void UpdateCOMportList()
        {
            ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            comboBoxPorts.Items.Clear();
            comboBoxPorts.Items.AddRange(ports);

            if (ports.Length > 0)
            {
                comboBoxPorts.SelectedIndex = 0;
            }
            
        }

        private void btnChangePort_Click(
            object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            try
            {
                serialPort.PortName = comboBoxPorts.Text;
                serialPort.Open();

                textBoxData.AppendText(
                    comboBoxPorts.Text + " opened.\r\n");
            }

            catch (Exception)
            {
                textBoxData.AppendText(
                    "Cannot open " + comboBoxPorts.Text + ".\r\n");
            }

        }
    }
}
