namespace Riski_ocenka
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.crv2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport21 = new Riski_ocenka.CrystalReport2();
            this.SuspendLayout();
            // 
            // crv2
            // 
            this.crv2.ActiveViewIndex = 0;
            this.crv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv2.Location = new System.Drawing.Point(0, 0);
            this.crv2.Name = "crv2";
            //this.crv2.ReportSource = this.CrystalReport21;
            this.crv2.ShowLogo = false;
            this.crv2.Size = new System.Drawing.Size(704, 501);
            this.crv2.TabIndex = 0;
            this.crv2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.crv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звіт";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form7_FormClosed);
            this.ResumeLayout(false);

        }

        private Form7 f7;
        private void Form7_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            f7 = null;
           // throw new System.NotImplementedException();
        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv2;
        public CrystalReport2 CrystalReport21;




    }
}