using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riski_ocenka
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // RTB_Report.ForeColor = Color.Black;
           // RTB_Report.Font = new Font("Arial", 12);
           // RTB_Report.AppendText(string.Format(" -------Общие данные --------\r\n"));
        }

        private void reportDocument1_InitReport(object sender, EventArgs e)
        {
            
        }
    }
}
