using System;
using System.Windows.Forms;

namespace dotStar
{
    public partial class Main : Form
    {
        char[] commands = {
            'R', 'G', 'B', 'S', 'M', 'Q'
        };

        String[] modeName = {
            "Breather", "Chaser", "Static", "Manual", "Gradient"
        };

        enum Command
        {
            Red,
            Green,
            Blue,
            Speed,
            Mode,
            Status
        }

        enum Mode
        {
            Breather,
            Chaser,
            Static,
            Manual,
            Gradient
        }

        /* Change speed */
        private void scrollDelay_Scroll(
            object sender, ScrollEventArgs e)
        {
            lblDelay.Text = string.Format(
                "Delay: {0}", scrollDelay.Value);


            if (serialPort.IsOpen)
            {
                int i = (int)Command.Speed;
                serialPort.WriteLine(commands[i] + scrollDelay.Value.ToString());
            }
        }

        /* Change mode */
        private void comboBoxModes_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                int i = (int)Command.Mode;
                serialPort.WriteLine(
                    commands[i] + comboBoxModes.SelectedIndex.ToString());
            }

        }

        /* Query button */
        private void btnQuery_Click(
            object sender, System.EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                int i = (int)Command.Status;
                serialPort.WriteLine(
                    commands[i] + comboBoxModes.SelectedIndex.ToString());
            }
        }
    }
}