using System;
using System.Windows.Forms;

namespace Riski_ocenka
{
    public partial class MDI : Form
    {
        private Form1 f1;
        private Form2 f2;
        private Form3 f3;
        //private int childFormNumber = 0;

        public MDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            /*Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
            */
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void popMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new Form1();
                f1.MdiParent = this;
                f1.FormClosed += f1_FormClosed;
                f1.Show();
            }
            else
                f1.Activate();
        }

        private void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
            //throw new NotImplementedException();
        }

        private void rIPRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new Form2();
                f2.MdiParent = this;
                f2.FormClosed += f2_FormClosed;
                f2.Show();
            }
            else
                f2.Activate();
        }

        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f2 = null;
            // throw new NotImplementedException();
        }

        private void rIPZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new Form3();
                f3.MdiParent = this;
                f3.FormClosed += f3_FormClosed;
                f3.Show();
            }
            else
                f3.Activate();
        }

        private void f3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f3 = null;
            //throw new NotImplementedException();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var box = new AboutBox1();
            box.ShowDialog(this);
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
        }

        /* Form6 f6;
        private void tab2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f6 == null)
            {
                f6 = new Form6();
                f6.MdiParent = this;
                f6.FormClosed += new FormClosedEventHandler(f6_FormClosed);
                f6.Show();

            }
            else
                f6.Activate();
        }

        private void f6_FormClosed(object sender, FormClosedEventArgs e)
        {
            f6 = null;

            //throw new NotImplementedException();
        }
        */

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "help.chm");
        }
    }
}