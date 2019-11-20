namespace Thetis
{
    partial class frmSeqLog
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
            this.btnCopyImageToClipboard = new System.Windows.Forms.ButtonTS();
            this.btnCopyToClipboard = new System.Windows.Forms.ButtonTS();
            this.labelTS6 = new System.Windows.Forms.LabelTS();
            this.labelTS5 = new System.Windows.Forms.LabelTS();
            this.labelTS4 = new System.Windows.Forms.LabelTS();
            this.labelTS3 = new System.Windows.Forms.LabelTS();
            this.labelTS2 = new System.Windows.Forms.LabelTS();
            this.labelTS1 = new System.Windows.Forms.LabelTS();
            this.btnClear = new System.Windows.Forms.ButtonTS();
            this.txtLog = new System.Windows.Forms.TextBoxTS();
            this.panelTS1 = new System.Windows.Forms.PanelTS();
            this.panelTS2 = new System.Windows.Forms.PanelTS();
            this.SuspendLayout();
            // 
            // btnCopyImageToClipboard
            // 
            this.btnCopyImageToClipboard.Enabled = false;
            this.btnCopyImageToClipboard.Image = null;
            this.btnCopyImageToClipboard.Location = new System.Drawing.Point(580, 58);
            this.btnCopyImageToClipboard.Name = "btnCopyImageToClipboard";
            this.btnCopyImageToClipboard.Size = new System.Drawing.Size(97, 61);
            this.btnCopyImageToClipboard.TabIndex = 9;
            this.btnCopyImageToClipboard.Text = "Copy Image To Clipboard";
            this.btnCopyImageToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyImageToClipboard.Click += new System.EventHandler(this.btnCopyImageToClipboard_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Enabled = false;
            this.btnCopyToClipboard.Image = null;
            this.btnCopyToClipboard.Location = new System.Drawing.Point(683, 58);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(97, 61);
            this.btnCopyToClipboard.TabIndex = 8;
            this.btnCopyToClipboard.Text = "Copy Text To Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // labelTS6
            // 
            this.labelTS6.AutoSize = true;
            this.labelTS6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTS6.ForeColor = System.Drawing.Color.Red;
            this.labelTS6.Image = null;
            this.labelTS6.Location = new System.Drawing.Point(52, 141);
            this.labelTS6.Name = "labelTS6";
            this.labelTS6.Size = new System.Drawing.Size(404, 13);
            this.labelTS6.TabIndex = 7;
            this.labelTS6.Text = "If you see -ve numbers please post details on the apache-labs forums.";
            // 
            // labelTS5
            // 
            this.labelTS5.AutoSize = true;
            this.labelTS5.Image = null;
            this.labelTS5.Location = new System.Drawing.Point(9, 34);
            this.labelTS5.Name = "labelTS5";
            this.labelTS5.Size = new System.Drawing.Size(343, 13);
            this.labelTS5.TabIndex = 6;
            this.labelTS5.Text = "A snapshot is taken when a sequence error is detected. s0 is the latest.";
            // 
            // labelTS4
            // 
            this.labelTS4.AutoSize = true;
            this.labelTS4.Image = null;
            this.labelTS4.Location = new System.Drawing.Point(52, 115);
            this.labelTS4.Name = "labelTS4";
            this.labelTS4.Size = new System.Drawing.Size(388, 13);
            this.labelTS4.TabIndex = 5;
            this.labelTS4.Text = "+ve = the packet arriving is greater than expected. This is likely to be packet l" +
    "oss";
            // 
            // labelTS3
            // 
            this.labelTS3.AutoSize = true;
            this.labelTS3.Image = null;
            this.labelTS3.Location = new System.Drawing.Point(52, 88);
            this.labelTS3.Name = "labelTS3";
            this.labelTS3.Size = new System.Drawing.Size(398, 13);
            this.labelTS3.TabIndex = 4;
            this.labelTS3.Text = "-ve = the packet arriving is older, and has a sequence number lower than expected" +
    "";
            // 
            // labelTS2
            // 
            this.labelTS2.AutoSize = true;
            this.labelTS2.Image = null;
            this.labelTS2.Location = new System.Drawing.Point(52, 64);
            this.labelTS2.Name = "labelTS2";
            this.labelTS2.Size = new System.Drawing.Size(281, 13);
            this.labelTS2.TabIndex = 3;
            this.labelTS2.Text = "0 = there is no delta so expected packet number is correct";
            // 
            // labelTS1
            // 
            this.labelTS1.AutoSize = true;
            this.labelTS1.Image = null;
            this.labelTS1.Location = new System.Drawing.Point(9, 17);
            this.labelTS1.Name = "labelTS1";
            this.labelTS1.Size = new System.Drawing.Size(621, 13);
            this.labelTS1.TabIndex = 2;
            this.labelTS1.Text = "This log shows inbound (radio->pc) UDP packet sequence errors. The numbers are a " +
    "delta from the next expected packet number.";
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClear.Image = null;
            this.btnClear.Location = new System.Drawing.Point(0, 532);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(792, 31);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "HOLDER";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 166);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(792, 360);
            this.txtLog.TabIndex = 0;
            // 
            // panelTS1
            // 
            this.panelTS1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.panelTS1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.panelTS1.BackColor = System.Drawing.Color.Red;
            this.panelTS1.BackgroundImage = global::Thetis.Properties.Resources.warning4;
            this.panelTS1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTS1.Location = new System.Drawing.Point(28, 88);
            this.panelTS1.Name = "panelTS1";
            this.panelTS1.Size = new System.Drawing.Size(18, 16);
            this.panelTS1.TabIndex = 10;
            // 
            // panelTS2
            // 
            this.panelTS2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.panelTS2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.panelTS2.BackgroundImage = global::Thetis.Properties.Resources.warning4;
            this.panelTS2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTS2.Location = new System.Drawing.Point(28, 112);
            this.panelTS2.Name = "panelTS2";
            this.panelTS2.Size = new System.Drawing.Size(18, 16);
            this.panelTS2.TabIndex = 11;
            // 
            // frmSeqLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 563);
            this.Controls.Add(this.panelTS2);
            this.Controls.Add(this.panelTS1);
            this.Controls.Add(this.btnCopyImageToClipboard);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.labelTS6);
            this.Controls.Add(this.labelTS5);
            this.Controls.Add(this.labelTS4);
            this.Controls.Add(this.labelTS3);
            this.Controls.Add(this.labelTS2);
            this.Controls.Add(this.labelTS1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSeqLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SEQ Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSeqLog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBoxTS txtLog;
        private System.Windows.Forms.ButtonTS btnClear;
        private System.Windows.Forms.LabelTS labelTS1;
        private System.Windows.Forms.LabelTS labelTS2;
        private System.Windows.Forms.LabelTS labelTS3;
        private System.Windows.Forms.LabelTS labelTS4;
        private System.Windows.Forms.LabelTS labelTS5;
        private System.Windows.Forms.LabelTS labelTS6;
        private System.Windows.Forms.ButtonTS btnCopyToClipboard;
        private System.Windows.Forms.ButtonTS btnCopyImageToClipboard;
        private System.Windows.Forms.PanelTS panelTS1;
        private System.Windows.Forms.PanelTS panelTS2;
    }
}