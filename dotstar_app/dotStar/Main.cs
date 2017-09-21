using System.Drawing;
using System.Windows.Forms;



namespace dotStar
{
    public partial class Main : Form
    {
        private string serialData;
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
