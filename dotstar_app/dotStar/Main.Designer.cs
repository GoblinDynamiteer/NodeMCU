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
            this.scrollDelay.Location = new System.Drawing.Point(12, 108);
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
            this.lblDelay.Location = new System.Drawing.Point(12, 83);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 502);
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
    }
}

