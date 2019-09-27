using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcLED
{
    public partial class PrintWindow : Form
    {
        public PrintWindow(string title, string html)
        {
            InitializeComponent();

            webBrowser.Navigate("about:blank");
            webBrowser.Document.Write(html);
            webBrowser.Document.Title = title;
        }
        
        private void BPageSetup_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPageSetupDialog();
        }

        private void BPrintSetup_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPropertiesDialog();
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
            Close();
        }
    }
}
