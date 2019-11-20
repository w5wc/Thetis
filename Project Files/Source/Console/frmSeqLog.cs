using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thetis
{
    public partial class frmSeqLog : Form
    {
        public delegate void ClearButtonHandler();
        private event ClearButtonHandler clearButtonEvents;

        public frmSeqLog()
        {
            InitializeComponent();
            btnClear.Text = "Close";
            btnCopyImageToClipboard.Enabled = false;
            btnCopyToClipboard.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnClear.Text = "Close";
            btnCopyImageToClipboard.Enabled = false;
            btnCopyToClipboard.Enabled = false;
            txtLog.Text = "";
            log.Clear();
            clearButtonEvents();
            this.Close();
        }

        private StringBuilder log = new StringBuilder();
        public void LogString(string s)
        {
            log.Insert(0, s + System.Environment.NewLine);
            if (log.Length > 16000) log.Remove(16000, log.Length - 16000);

            txtLog.Text = log.ToString();

            btnClear.Text = "Clear Log + Close";
            btnCopyImageToClipboard.Enabled = true;
            btnCopyToClipboard.Enabled = true;
        }

        private void frmSeqLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        public event ClearButtonHandler ClearButtonEvent {
            add {
                clearButtonEvents += value;
            }
            remove {
                clearButtonEvents -= value;
            }
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtLog.Text);
        }

        private void btnCopyImageToClipboard_Click(object sender, EventArgs e)
        {
            using (Bitmap bmp = new Bitmap(txtLog.Width, txtLog.Height))
            {
                txtLog.DrawToBitmap(bmp, new Rectangle(new Point(0, 0), txtLog.Size));
                Clipboard.SetImage(bmp);
            }
        }
    }
}
