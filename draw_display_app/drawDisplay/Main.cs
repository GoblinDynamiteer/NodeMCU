using System.Drawing;
using System.Windows.Forms;

namespace drawDisplay
{
    public partial class frmMain : Form
    {
        Graphics graphics;
        Brush brush = Brushes.White;

        Display display;

        bool draw;

        public frmMain()
        {
            InitializeComponent();
            SetPanel();

            graphics = panelDrawArea.CreateGraphics();
            display = new Display();

            lblCursorX.Text = "X:";
            lblCursorY.Text = "Y:";

            draw = false;
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

                //display.SetPixel(true, e.Location.X, e.Location.Y);
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

    }
}
