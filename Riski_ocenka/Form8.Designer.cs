namespace Riski_ocenka
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.crv3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv3
            // 
            this.crv3.ActiveViewIndex = -1;
            this.crv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv3.Location = new System.Drawing.Point(0, 0);
            this.crv3.Name = "crv3";
            this.crv3.Size = new System.Drawing.Size(704, 501);
            this.crv3.TabIndex = 0;
            this.crv3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crv3.Load += new System.EventHandler(this.crv3_Load);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.crv3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Звіт";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crv3;
    }
}