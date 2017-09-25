namespace dotStar
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnChangePort = new System.Windows.Forms.Button();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.scrollSpeed = new System.Windows.Forms.HScrollBar();
            this.scrollDelay = new System.Windows.Forms.HScrollBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.scrollColorRed = new System.Windows.Forms.HScrollBar();
            this.scrollColorGreen = new System.Windows.Forms.HScrollBar();
            this.scrollColorBlue = new System.Windows.Forms.HScrollBar();
            this.groupBoxRGB = new System.Windows.Forms.GroupBox();
            this.pictureLED = new System.Windows.Forms.PictureBox();
            this.checkListLEDs = new System.Windows.Forms.CheckedListBox();
            this.groupBoxRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLED)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(24, 665);
            this.textBoxData.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(386, 273);
            this.textBoxData.TabIndex = 0;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(24, 588);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(238, 33);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // btnChangePort
            // 
            this.btnChangePort.Location = new System.Drawing.Point(278, 588);
            this.btnChangePort.Margin = new System.Windows.Forms.Padding(6);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(136, 40);
            this.btnChangePort.TabIndex = 2;
            this.btnChangePort.Text = "Open";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(24, 63);
            this.comboBoxModes.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(238, 33);
            this.comboBoxModes.TabIndex = 3;
            this.comboBoxModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModes_SelectedIndexChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(18, 33);
            this.lblMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(66, 25);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Mode";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(18, 558);
            this.lblPort.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(51, 25);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port";
            // 
            // scrollSpeed
            // 
            this.scrollSpeed.Location = new System.Drawing.Point(16, 43);
            this.scrollSpeed.Name = "scrollSpeed";
            this.scrollSpeed.Size = new System.Drawing.Size(149, 17);
            this.scrollSpeed.TabIndex = 0;
            // 
            // scrollDelay
            // 
            this.scrollDelay.Location = new System.Drawing.Point(46, 212);
            this.scrollDelay.Maximum = 500;
            this.scrollDelay.Minimum = 1;
            this.scrollDelay.Name = "scrollDelay";
            this.scrollDelay.Size = new System.Drawing.Size(390, 17);
            this.scrollDelay.TabIndex = 6;
            this.scrollDelay.Value = 1;
            this.scrollDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollDelay_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(46, 163);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(97, 25);
            this.lblDelay.TabIndex = 7;
            this.lblDelay.Text = "Delay:  1";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(426, 898);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(74, 44);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "?";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // scrollColorRed
            // 
            this.scrollColorRed.Location = new System.Drawing.Point(16, 58);
            this.scrollColorRed.Maximum = 255;
            this.scrollColorRed.Name = "scrollColorRed";
            this.scrollColorRed.Size = new System.Drawing.Size(384, 17);
            this.scrollColorRed.TabIndex = 9;
            this.scrollColorRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorRed_Scroll);
            // 
            // scrollColorGreen
            // 
            this.scrollColorGreen.Location = new System.Drawing.Point(16, 102);
            this.scrollColorGreen.Maximum = 255;
            this.scrollColorGreen.Name = "scrollColorGreen";
            this.scrollColorGreen.Size = new System.Drawing.Size(384, 17);
            this.scrollColorGreen.TabIndex = 10;
            this.scrollColorGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorGreen_Scroll);
            // 
            // scrollColorBlue
            // 
            this.scrollColorBlue.Location = new System.Drawing.Point(16, 146);
            this.scrollColorBlue.Maximum = 255;
            this.scrollColorBlue.Name = "scrollColorBlue";
            this.scrollColorBlue.Size = new System.Drawing.Size(384, 17);
            this.scrollColorBlue.TabIndex = 11;
            this.scrollColorBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorBlue_Scroll);
            // 
            // groupBoxRGB
            // 
            this.groupBoxRGB.Controls.Add(this.scrollColorRed);
            this.groupBoxRGB.Controls.Add(this.scrollColorBlue);
            this.groupBoxRGB.Controls.Add(this.scrollColorGreen);
            this.groupBoxRGB.Location = new System.Drawing.Point(30, 277);
            this.groupBoxRGB.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxRGB.Name = "groupBoxRGB";
            this.groupBoxRGB.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxRGB.Size = new System.Drawing.Size(442, 215);
            this.groupBoxRGB.TabIndex = 12;
            this.groupBoxRGB.TabStop = false;
            this.groupBoxRGB.Text = "RGB LED Control";
            // 
            // pictureLED
            // 
            this.pictureLED.Location = new System.Drawing.Point(484, 310);
            this.pictureLED.Margin = new System.Windows.Forms.Padding(6);
            this.pictureLED.Name = "pictureLED";
            this.pictureLED.Size = new System.Drawing.Size(214, 158);
            this.pictureLED.TabIndex = 13;
            this.pictureLED.TabStop = false;
            // 
            // checkListLEDs
            // 
            this.checkListLEDs.FormattingEnabled = true;
            this.checkListLEDs.Items.AddRange(new object[] {
            "LED0"});
            this.checkListLEDs.Location = new System.Drawing.Point(484, 506);
            this.checkListLEDs.Name = "checkListLEDs";
            this.checkListLEDs.Size = new System.Drawing.Size(253, 264);
            this.checkListLEDs.TabIndex = 14;
            this.checkListLEDs.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkListLEDs_ItemCheck);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 965);
            this.Controls.Add(this.checkListLEDs);
            this.Controls.Add(this.pictureLED);
            this.Controls.Add(this.groupBoxRGB);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.scrollDelay);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.comboBoxModes);
            this.Controls.Add(this.btnChangePort);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.textBoxData);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "DotStar Controller App";
            this.groupBoxRGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnChangePort;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.HScrollBar scrollSpeed;
        private System.Windows.Forms.HScrollBar scrollDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.HScrollBar scrollColorRed;
        private System.Windows.Forms.HScrollBar scrollColorGreen;
        private System.Windows.Forms.HScrollBar scrollColorBlue;
        private System.Windows.Forms.GroupBox groupBoxRGB;
        private System.Windows.Forms.PictureBox pictureLED;
        private System.Windows.Forms.CheckedListBox checkListLEDs;
    }
}

