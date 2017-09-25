using System;
using System.Windows.Forms;

namespace dotStar
{
    public partial class Main : Form
    {
        char[] commands = {
            'R', 'G', 'B', 'S', 'M', 'Q', 'P', 'C'
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
            Status,
            SetPixel,
            ClearPixel
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

            scrollDelay.Enabled = comboBoxModes.SelectedIndex != (int)Mode.Static;

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

        private void scrollColorRed_Scroll(
            object sender, ScrollEventArgs e)
        {
            drawLed();

            if (serialPort.IsOpen)
            {
                int i = (int)Command.Red;
                serialPort.WriteLine(
                    commands[i] + scrollColorRed.Value.ToString());
            }
        }

        private void scrollColorGreen_Scroll(
            object sender, ScrollEventArgs e)
        {
            drawLed();

            if (serialPort.IsOpen)
            {
                int i = (int)Command.Green;
                serialPort.WriteLine(
                    commands[i] + scrollColorGreen.Value.ToString());
            }
        }

        private void scrollColorBlue_Scroll(
            object sender, ScrollEventArgs e)
        {
            drawLed();

            if (serialPort.IsOpen)
            {
                int i = (int)Command.Blue;
                serialPort.WriteLine(
                    commands[i] + scrollColorBlue.Value.ToString());
            }
        }

        private void checkListLEDs_ItemCheck(
            object sender, ItemCheckEventArgs e)
        {
            int i = 0;
            int ledIndex = checkListLEDs.SelectedIndex;

            if (e.NewValue == CheckState.Checked)
            {
                i = (int)Command.SetPixel;
            }

            if (e.NewValue == CheckState.Unchecked)
            {
                i = (int)Command.ClearPixel;
            }

            if (serialPort.IsOpen)
            {
                serialPort.WriteLine(commands[i] + "" + ledIndex);
                return;
            }
        }

    }
}