using System.Drawing;
using System.Windows.Forms;

namespace dotStar
{
    public partial class Main : Form
    {
        private string serialData;
        private int ledAmount = 48;
        Graphics drawArea;
        Color color;

        public Main()
        {
            InitializeComponent();
            UpdateCOMportList();

            comboBoxModes.Items.AddRange(modeName);
            comboBoxModes.SelectedIndex = 0;

            drawArea = pictureLED.CreateGraphics();
            color = new Color();

            checkListLEDs.Items.Clear();
            for (int i = 0; i < ledAmount; i++)
            {
                string item = "LED" + i;
                checkListLEDs.Items.Add(item);
            }
        }

        void drawLed()
        {
            color = Color.FromArgb(
                    255, 
                    scrollColorRed.Value,
                    scrollColorGreen.Value,
                    scrollColorBlue.Value
                );

            SolidBrush brush = new SolidBrush(color);

            drawArea.FillEllipse(brush, 0, 0, 50, 50);
        }


    }
}
