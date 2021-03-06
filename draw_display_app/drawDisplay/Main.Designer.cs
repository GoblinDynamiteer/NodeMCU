﻿namespace drawDisplay
{
    partial class frmMain
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
            this.panelDrawArea = new System.Windows.Forms.Panel();
            this.lblCursorX = new System.Windows.Forms.Label();
            this.lblCursorY = new System.Windows.Forms.Label();
            this.textBoxDrawSize = new System.Windows.Forms.TextBox();
            this.textBoxXBMArray = new System.Windows.Forms.TextBox();
            this.btnGenXBM = new System.Windows.Forms.Button();
            this.btnShowPix = new System.Windows.Forms.Button();
            this.btnXBMCode = new System.Windows.Forms.Button();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelDrawArea
            // 
            this.panelDrawArea.Location = new System.Drawing.Point(76, 97);
            this.panelDrawArea.Name = "panelDrawArea";
            this.panelDrawArea.Size = new System.Drawing.Size(128, 64);
            this.panelDrawArea.TabIndex = 0;
            this.panelDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrawArea_MouseDown);
            this.panelDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrawArea_MouseMove);
            this.panelDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawArea_MouseUp);
            // 
            // lblCursorX
            // 
            this.lblCursorX.AutoSize = true;
            this.lblCursorX.Location = new System.Drawing.Point(76, 178);
            this.lblCursorX.Name = "lblCursorX";
            this.lblCursorX.Size = new System.Drawing.Size(35, 13);
            this.lblCursorX.TabIndex = 1;
            this.lblCursorX.Text = "label1";
            // 
            // lblCursorY
            // 
            this.lblCursorY.AutoSize = true;
            this.lblCursorY.Location = new System.Drawing.Point(169, 178);
            this.lblCursorY.Name = "lblCursorY";
            this.lblCursorY.Size = new System.Drawing.Size(35, 13);
            this.lblCursorY.TabIndex = 2;
            this.lblCursorY.Text = "label2";
            // 
            // textBoxDrawSize
            // 
            this.textBoxDrawSize.Location = new System.Drawing.Point(76, 216);
            this.textBoxDrawSize.Name = "textBoxDrawSize";
            this.textBoxDrawSize.Size = new System.Drawing.Size(58, 20);
            this.textBoxDrawSize.TabIndex = 3;
            this.textBoxDrawSize.Text = "1";
            // 
            // textBoxXBMArray
            // 
            this.textBoxXBMArray.Location = new System.Drawing.Point(260, 97);
            this.textBoxXBMArray.Multiline = true;
            this.textBoxXBMArray.Name = "textBoxXBMArray";
            this.textBoxXBMArray.ReadOnly = true;
            this.textBoxXBMArray.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxXBMArray.Size = new System.Drawing.Size(381, 401);
            this.textBoxXBMArray.TabIndex = 4;
            // 
            // btnGenXBM
            // 
            this.btnGenXBM.Location = new System.Drawing.Point(260, 58);
            this.btnGenXBM.Name = "btnGenXBM";
            this.btnGenXBM.Size = new System.Drawing.Size(82, 23);
            this.btnGenXBM.TabIndex = 5;
            this.btnGenXBM.Text = "Show Bytes";
            this.btnGenXBM.UseVisualStyleBackColor = true;
            this.btnGenXBM.Click += new System.EventHandler(this.btnGenXBM_Click);
            // 
            // btnShowPix
            // 
            this.btnShowPix.Location = new System.Drawing.Point(361, 58);
            this.btnShowPix.Name = "btnShowPix";
            this.btnShowPix.Size = new System.Drawing.Size(75, 23);
            this.btnShowPix.TabIndex = 6;
            this.btnShowPix.Text = "Show Pixels";
            this.btnShowPix.UseVisualStyleBackColor = true;
            this.btnShowPix.Click += new System.EventHandler(this.btnShowPix_Click);
            // 
            // btnXBMCode
            // 
            this.btnXBMCode.Location = new System.Drawing.Point(456, 58);
            this.btnXBMCode.Name = "btnXBMCode";
            this.btnXBMCode.Size = new System.Drawing.Size(154, 23);
            this.btnXBMCode.TabIndex = 7;
            this.btnXBMCode.Text = "Generate XBM Code";
            this.btnXBMCode.UseVisualStyleBackColor = true;
            this.btnXBMCode.Click += new System.EventHandler(this.btnXBMCode_Click);
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(76, 272);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(150, 21);
            this.comboBoxPorts.TabIndex = 8;
            this.comboBoxPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxPorts_SelectedIndexChanged);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(76, 299);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(150, 199);
            this.textBoxData.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(379, 505);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(141, 61);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "SEND DATA TO DISPLAY!";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(151, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 617);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.btnXBMCode);
            this.Controls.Add(this.btnShowPix);
            this.Controls.Add(this.btnGenXBM);
            this.Controls.Add(this.textBoxXBMArray);
            this.Controls.Add(this.textBoxDrawSize);
            this.Controls.Add(this.lblCursorY);
            this.Controls.Add(this.lblCursorX);
            this.Controls.Add(this.panelDrawArea);
            this.Name = "frmMain";
            this.Text = "drawDisplay APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDrawArea;
        private System.Windows.Forms.Label lblCursorX;
        private System.Windows.Forms.Label lblCursorY;
        private System.Windows.Forms.TextBox textBoxDrawSize;
        private System.Windows.Forms.TextBox textBoxXBMArray;
        private System.Windows.Forms.Button btnGenXBM;
        private System.Windows.Forms.Button btnShowPix;
        private System.Windows.Forms.Button btnXBMCode;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;
    }
}

