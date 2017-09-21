using System.Windows.Forms;



namespace dotStar
{
    public partial class Main : Form
    {
        private string serialData;

        public Main()
        {
            InitializeComponent();
            UpdateCOMportList();

            comboBoxModes.Items.AddRange(modeName);
            comboBoxModes.SelectedIndex = 0;
        }


    }
}
