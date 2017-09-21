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
            this.textBoxData.Location = new System.Drawing.Point(12, 346);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.Size = new System.Drawing.Size(195, 144);
            this.textBoxData.TabIndex = 0;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 306);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // btnChangePort
            // 
            this.btnChangePort.Location = new System.Drawing.Point(139, 306);
            this.btnChangePort.Name = "btnChangePort";
            this.btnChangePort.Size = new System.Drawing.Size(68, 21);
            this.btnChangePort.TabIndex = 2;
            this.btnChangePort.Text = "Open";
            this.btnChangePort.UseVisualStyleBackColor = true;
            this.btnChangePort.Click += new System.EventHandler(this.btnChangePort_Click);
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(12, 33);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModes.TabIndex = 3;
            this.comboBoxModes.SelectedIndexChanged += new System.EventHandler(this.comboBoxModes_SelectedIndexChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(9, 17);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(34, 13);
            this.lblMode.TabIndex = 4;
            this.lblMode.Text = "Mode";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(9, 290);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
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
            this.scrollDelay.Location = new System.Drawing.Point(23, 110);
            this.scrollDelay.Maximum = 500;
            this.scrollDelay.Minimum = 1;
            this.scrollDelay.Name = "scrollDelay";
            this.scrollDelay.Size = new System.Drawing.Size(195, 17);
            this.scrollDelay.TabIndex = 6;
            this.scrollDelay.Value = 1;
            this.scrollDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollDelay_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(23, 85);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(49, 13);
            this.lblDelay.TabIndex = 7;
            this.lblDelay.Text = "Delay:  1";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(213, 467);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(37, 23);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "?";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // scrollColorRed
            // 
            this.scrollColorRed.Location = new System.Drawing.Point(8, 30);
            this.scrollColorRed.Maximum = 255;
            this.scrollColorRed.Name = "scrollColorRed";
            this.scrollColorRed.Size = new System.Drawing.Size(192, 17);
            this.scrollColorRed.TabIndex = 9;
            this.scrollColorRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorRed_Scroll);
            // 
            // scrollColorGreen
            // 
            this.scrollColorGreen.Location = new System.Drawing.Point(8, 53);
            this.scrollColorGreen.Maximum = 255;
            this.scrollColorGreen.Name = "scrollColorGreen";
            this.scrollColorGreen.Size = new System.Drawing.Size(192, 17);
            this.scrollColorGreen.TabIndex = 10;
            this.scrollColorGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorGreen_Scroll);
            // 
            // scrollColorBlue
            // 
            this.scrollColorBlue.Location = new System.Drawing.Point(8, 76);
            this.scrollColorBlue.Maximum = 255;
            this.scrollColorBlue.Name = "scrollColorBlue";
            this.scrollColorBlue.Size = new System.Drawing.Size(192, 17);
            this.scrollColorBlue.TabIndex = 11;
            this.scrollColorBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollColorBlue_Scroll);
            // 
            // groupBoxRGB
            // 
            this.groupBoxRGB.Controls.Add(this.scrollColorRed);
            this.groupBoxRGB.Controls.Add(this.scrollColorBlue);
            this.groupBoxRGB.Controls.Add(this.scrollColorGreen);
            this.groupBoxRGB.Location = new System.Drawing.Point(15, 144);
            this.groupBoxRGB.Name = "groupBoxRGB";
            this.groupBoxRGB.Size = new System.Drawing.Size(221, 112);
            this.groupBoxRGB.TabIndex = 12;
            this.groupBoxRGB.TabStop = false;
            this.groupBoxRGB.Text = "RGB LED Control";
            // 
            // pictureLED
            // 
            this.pictureLED.Location = new System.Drawing.Point(242, 161);
            this.pictureLED.Name = "pictureLED";
            this.pictureLED.Size = new System.Drawing.Size(107, 82);
            this.pictureLED.TabIndex = 13;
            this.pictureLED.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 502);
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
    }
}

