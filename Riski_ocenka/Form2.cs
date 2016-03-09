using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Riski_ocenka
{
    public partial class Form2 : Form
    {
        private DataSet ds = null;
        private DataTable dt = null;
        private Form7 f7;
        private double ipr = 0;
        private int L;
        private int N;
        private int n1, n2, n3, n4, n5;
        private int sum, sum1;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   n = Convert.ToInt32(tb2_1.Text);
            N = Convert.ToInt32(tb2.Text);
            L = Convert.ToInt32(tb3.Text);

            var checkedButton3 = groupBox3.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if (checkedButton3 == null) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії ризику профзахворювання!");
                return;
            }
            else
            {
                Kt = Convert.ToInt32(checkedButton3.Tag);

                for (int i = 0; i <= n; i++)
                {
                    sum = i*Kt + sum;
                }
                double ipr = ((double) sum/(N*L))*100;
                tb12.Text = Convert.ToString(ipr);
            }
        }
            */
            /*n1 = Convert.ToInt32(tb2_1.Text);
            n2 = Convert.ToInt32(tb2_2.Text);
            n3 = Convert.ToInt32(tb2_3.Text);
            n4 = Convert.ToInt32(tb2_4.Text);
            n5 = Convert.ToInt32(tb2_5.Text);
            N = Convert.ToInt32(tb2.Text);
            L = Convert.ToInt32(tb3.Text);

            sum = n1 + n2*2 + n3*3 + n4*4 + n5*5;
            sum1 = n1 + n2 + n3 + n4 + n5;
            if (sum1>N)
            MessageBox.Show("Кілкість захворювань n(i) \n введено не вірно!");
        else
            {
                double ipr = ((double)sum / (N * L)) * 100;
                ipr = Math.Round(ipr, 4);
                tb12.Text = Convert.ToString(ipr);
            }
            */
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb2_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb2_3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb2_4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void tb2_5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char) Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(tb2_1.Text);
            n2 = Convert.ToInt32(tb2_2.Text);
            n3 = Convert.ToInt32(tb2_3.Text);
            n4 = Convert.ToInt32(tb2_4.Text);
            n5 = Convert.ToInt32(tb2_5.Text);
            N = Convert.ToInt32(tb2.Text);
            L = Convert.ToInt32(tb3.Text);

            sum = n1 + n2*2 + n3*3 + n4*4 + n5*5;
            sum1 = n1 + n2 + n3 + n4 + n5;
            if (sum1 > N)
                MessageBox.Show("Кілкість захворювань n(i) \n введено не вірно!");
            else
            {
                var ipr = ((double) sum/(N*L))*100;
                ipr = Math.Round(ipr, 4);
                tb12.Text = Convert.ToString(ipr);
            }

            var chex = tb22_1.Text;
            var posada = tb22_2.Text;
            var index = tb12.Text;
            dataGridView1.Rows.Add(1, chex, posada, index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ds = new DataSet();
            var dt = new DataTable();
            dt.Columns.Add("id", typeof (short));
            dt.Columns.Add("chex", typeof (string));
            dt.Columns.Add("posada", typeof (string));
            dt.Columns.Add("index", typeof (double));

            //add datagridview data to table
            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);
            }
            ds.Tables.Add(dt);
            //ds.WriteXmlSchema("sample.xml");
            ds.WriteXmlSchema(@"ds2.xml");

            //transefer data to crystalreportviewer
            if (f7 == null)
            {
                f7 = new Form7();
                f7.MdiParent = MdiParent;
                f7.FormClosed += f7_FormClosed;
                var cryR = new ReportDocument();
                cryR.Load(@"CrystalReport2.rpt");
                cryR.SetDataSource(ds);
                f7.crv2.ReportSource = cryR;
                f7.crv2.Refresh();
                f7.Show();
            }
            else
            {
                f7.Activate();
            }
        }

        private void f7_FormClosed(object sender, FormClosedEventArgs e)
        {
            f7 = null;
            // throw new NotImplementedException();
        }

        private void tb2_5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}