namespace CalcLED
{
    partial class PrintWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintWindow));
            this.bPageSetup = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.bPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPageSetup
            // 
            this.bPageSetup.Location = new System.Drawing.Point(0, 600);
            this.bPageSetup.Margin = new System.Windows.Forms.Padding(0);
            this.bPageSetup.Name = "bPageSetup";
            this.bPageSetup.Size = new System.Drawing.Size(230, 40);
            this.bPageSetup.TabIndex = 3;
            this.bPageSetup.Text = "Page setup";
            this.bPageSetup.UseVisualStyleBackColor = true;
            this.bPageSetup.Click += new System.EventHandler(this.BPageSetup_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(460, 600);
            this.webBrowser.TabIndex = 1;
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(230, 600);
            this.bPrint.Margin = new System.Windows.Forms.Padding(0);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(230, 40);
            this.bPrint.TabIndex = 5;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // PrintWindow
            // 
            this.AcceptButton = this.bPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 639);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bPageSetup);
            this.Controls.Add(this.webBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrintWindow";
            this.ShowInTaskbar = false;
            this.Text = "PrintWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bPageSetup;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button bPrint;
    }
}