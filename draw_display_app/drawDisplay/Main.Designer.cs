namespace drawDisplay
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
            this.panelDrawArea = new System.Windows.Forms.Panel();
            this.lblCursorX = new System.Windows.Forms.Label();
            this.lblCursorY = new System.Windows.Forms.Label();
            this.textBoxDrawSize = new System.Windows.Forms.TextBox();
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
            this.textBoxDrawSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxDrawSize.TabIndex = 3;
            this.textBoxDrawSize.Text = "1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
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
    }
}

