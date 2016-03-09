using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Riski_ocenka
{
    public partial class Form3 : Form
    {
        private DataSet ds = null;
        private DataTable dt = null;
        private Form8 f8;
        private double ipz = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* var kr = 0;
            var ktt = 0;
            //int ipz = 0;

            var checkedButton1 = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var checkedButton2 = groupBox2.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (checkedButton1 == null) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії ризику профзахворювання!");
                return;
            }
            kr = Convert.ToInt32(checkedButton1.Tag);
            if (checkedButton2 == null) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії важкості профзахворювання!");
                return;
            }
            ktt = Convert.ToInt32(checkedButton2.Tag);
            var ipz = 1/(double) (kr*ktt);
            ipz = Math.Round(ipz, 3);
            tb11.Text = Convert.ToString(ipz);
            tb11.Select(tb11.Text.Length, 4);
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // XmlDocument doc = new XmlDocument();
            // doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", null));
            // doc.Save(@".\dataset.xml");
           // var kr = 0;
            //var ktt = 0;

            /*if (kr = 0) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії ризику профзахворювання!");
                return;
            }
            if (ktt = 0) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії ризику профзахворювання!");
                return;
            }
             */
            var ds = new DataSet();
            var dt = new DataTable();
            dt.Columns.Add("id", typeof (short));
            dt.Columns.Add("chex", typeof (string));
            dt.Columns.Add("posada", typeof (string));
            dt.Columns.Add("zax", typeof(string));
            dt.Columns.Add("index", typeof (double));
           // var chex = tb3_1.Text;
           // var posada = tb3_2.Text;
           // var zax = tb3_3.Text;
           // var index = tb11.Text;
           // dataGridView1.Rows.Add(1, chex, posada, zax, index);
            //add datagridview data to table
            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema(@"ds3.xml");
            //Создаём отчёт 
            //ReportDocument myReport = new ReportDocument();
            //Задаём форму (которую создавали в пункте 3)
            //myReport.Load(@".\CrystalReport3.rpt");
            //DataSet ds = new DataSet();
            //Указываем источнику данных вновь сформированный XML файл.
            //ds.ReadXml(@".\ds3.xml");
            //Указываем отчёту откуда брать данные.
            //myReport.SetDataSource(ds);
            //Создаём форму.
            //Form8 f8 = new Form8();
            //Указываем отчёт для CrystalReportViewer
            //f8.crv3.ReportSource = myReport;
            //Открываем форму.
            //f8.Show();
            
            if (f8 == null)
            {
                f8 = new Form8();
                f8.MdiParent = MdiParent;
                f8.FormClosed += f8_FormClosed;
                var cryR = new ReportDocument();
                cryR.Load(@"CrystalReport3.rpt");
                cryR.SetDataSource(ds);
                f8.crv3.ReportSource = cryR;
                f8.crv3.Refresh();
                f8.Show();
            }
            else
            {
                f8.Activate();
            }
        }

        private void f8_FormClosed(object sender, FormClosedEventArgs e)
        {
            f8 = null;
            //throw new NotImplementedException();
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

        private void button4_Click(object sender, EventArgs e)
        {
            var kr = 0;
            var ktt = 0;
            //int ipz = 0;

            var checkedButton1 = groupBox1.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);
            var checkedButton2 = groupBox2.Controls.OfType<RadioButton>()
                .FirstOrDefault(r => r.Checked);

            if (checkedButton1 == null) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії ризику профзахворювання!");
                return;
            }
            kr = Convert.ToInt32(checkedButton1.Tag);
            if (checkedButton2 == null) // проверка, что какая-то радиобатон выбрана
            {
                MessageBox.Show("Виберіть будь ласка значення \nз категорії важкості профзахворювання!");
                return;
            }
            ktt = Convert.ToInt32(checkedButton2.Tag);
            var ipz = 1 / (double)(kr * ktt);
            ipz = Math.Round(ipz, 3);
            tb11.Text = Convert.ToString(ipz);
            tb11.Select(tb11.Text.Length, 4);

            var chex = tb3_1.Text;
            var posada = tb3_2.Text;
            var zax = tb3_3.Text;
            var index = tb11.Text;
            dataGridView1.Rows.Add(1, chex, posada, zax, index);
        }
    }
}