namespace Riski_ocenka
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lab2_5 = new System.Windows.Forms.Label();
            this.lab2_1 = new System.Windows.Forms.Label();
            this.lab2_4 = new System.Windows.Forms.Label();
            this.lab2_2 = new System.Windows.Forms.Label();
            this.lab2_3 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb2_1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.lb12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb22_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb22_1 = new System.Windows.Forms.TextBox();
            this.gb2_2 = new System.Windows.Forms.GroupBox();
            this.tb2_5 = new System.Windows.Forms.TextBox();
            this.tb2_4 = new System.Windows.Forms.TextBox();
            this.tb2_3 = new System.Windows.Forms.TextBox();
            this.tb2_2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.gb2_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Звіт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Закрити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Розраховувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lab2_5);
            this.groupBox3.Controls.Add(this.lab2_1);
            this.groupBox3.Controls.Add(this.lab2_4);
            this.groupBox3.Controls.Add(this.lab2_2);
            this.groupBox3.Controls.Add(this.lab2_3);
            this.groupBox3.Location = new System.Drawing.Point(12, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 190);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Категорії важкості профзахворювання";
            // 
            // lab2_5
            // 
            this.lab2_5.AutoSize = true;
            this.lab2_5.Location = new System.Drawing.Point(21, 155);
            this.lab2_5.Name = "lab2_5";
            this.lab2_5.Size = new System.Drawing.Size(202, 26);
            this.lab2_5.TabIndex = 54;
            this.lab2_5.Text = "Помірна тимчасова непрацездатність \r\nабо лікарняний лист менше 3 тижнів";
            this.lab2_5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab2_1
            // 
            this.lab2_1.AutoSize = true;
            this.lab2_1.Location = new System.Drawing.Point(22, 16);
            this.lab2_1.Name = "lab2_1";
            this.lab2_1.Size = new System.Drawing.Size(201, 39);
            this.lab2_1.TabIndex = 50;
            this.lab2_1.Text = "Непрацездатність, прогресуюча \r\nнавіть у відсутність подальшої \r\nекспозиції і обу" +
    "мовлює зміну професії";
            this.lab2_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab2_4
            // 
            this.lab2_4.AutoSize = true;
            this.lab2_4.Location = new System.Drawing.Point(30, 120);
            this.lab2_4.Name = "lab2_4";
            this.lab2_4.Size = new System.Drawing.Size(193, 26);
            this.lab2_4.TabIndex = 53;
            this.lab2_4.Text = "Важка тимчасова непрацездатність \r\nабо лікарняний лист понад 3 тижні";
            this.lab2_4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab2_2
            // 
            this.lab2_2.AutoSize = true;
            this.lab2_2.Location = new System.Drawing.Point(56, 66);
            this.lab2_2.Name = "lab2_2";
            this.lab2_2.Size = new System.Drawing.Size(167, 26);
            this.lab2_2.TabIndex = 51;
            this.lab2_2.Text = "Постійна непрацездатність \r\nабо необхідність зміни професії";
            this.lab2_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lab2_3
            // 
            this.lab2_3.AutoSize = true;
            this.lab2_3.Location = new System.Drawing.Point(35, 100);
            this.lab2_3.Name = "lab2_3";
            this.lab2_3.Size = new System.Drawing.Size(188, 13);
            this.lab2_3.TabIndex = 52;
            this.lab2_3.Text = "Постійна помірна непрацездатність";
            this.lab2_3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(485, 89);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(56, 20);
            this.tb2.TabIndex = 9;
            this.tb2.Text = "0";
            this.tb2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_KeyPress);
            // 
            // tb2_1
            // 
            this.tb2_1.Location = new System.Drawing.Point(37, 26);
            this.tb2_1.Name = "tb2_1";
            this.tb2_1.Size = new System.Drawing.Size(56, 20);
            this.tb2_1.TabIndex = 4;
            this.tb2_1.Text = "0";
            this.tb2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 39);
            this.label5.TabIndex = 43;
            this.label5.Text = "число робітників \r\nданої проф. групи\r\n(N)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(485, 142);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(56, 20);
            this.tb3.TabIndex = 10;
            this.tb3.Text = "0";
            this.tb3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 39);
            this.label1.TabIndex = 46;
            this.label1.Text = "число років \r\nспостережень\r\n(L)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(434, 203);
            this.tb12.Name = "tb12";
            this.tb12.ReadOnly = true;
            this.tb12.Size = new System.Drawing.Size(78, 20);
            this.tb12.TabIndex = 49;
            this.tb12.Text = "0";
            // 
            // lb12
            // 
            this.lb12.AutoSize = true;
            this.lb12.Location = new System.Drawing.Point(390, 179);
            this.lb12.Name = "lb12";
            this.lb12.Size = new System.Drawing.Size(164, 13);
            this.lb12.TabIndex = 48;
            this.lb12.Text = "Іпр=((n1*K1)+...+(n*K))/(N*L)*100";
            this.lb12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 26);
            this.label9.TabIndex = 53;
            this.label9.Text = "Професія \r\nабо посада";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb22_2
            // 
            this.tb22_2.AutoCompleteCustomSource.AddRange(new string[] {
            "Агломератчікі",
            "Бригадири",
            "Бризгальщікі розливних машин і шлаковозних ковшів",
            "Верхові, старші верхові",
            "Водопровідники доменних печей",
            "Вивантажувачі агломератів",
            "Газівники, старші газівники, підручні газівників",
            "Горнові",
            "Горнові, старші горнові, підручні горнових",
            "Грохотувальники",
            "Дезінтеграторщікі",
            "Дробильники",
            "Желобщікі, старші желобщікі, бригадири желобщіков, підручні желобщіков",
            "Завантажники шихти",
            "Муляри й бригадири мулярів на гарячих роботах",
            "Кантувальники скіпових ям",
            "Катали, старші катали",
            "Клеточніков, старші Клеточніков",
            "Ковшеві",
            "Колошникові, бригадири колошника",
            "Кранівники (машиністи) на гарячих ділянках робіт",
            "Кранівники (машиністи) на гарячих ділянках робіт та їх помічники",
            "Машиністи вагон-ваг і електровозів у тунелях та їх помічники",
            "Машиністи кантувальних лебідок на розливних машинах",
            "Машиністи ексгаустерів",
            "Паллетчікі",
            "Печові",
            "Прожарювачі",
            "Робочі бункерів і підбункерних приміщень",
            "Робітники і старші робітники на очищенні колошникового пилу і газопроводів",
            "Робочі під аглострічок і з прибирання пилу",
            "Розмелювач агломерату",
            "Спікальник",
            "Стропальники (чальщікі) на гарячих ділянках робіт",
            "Тельферісти на гарячих ділянках робіт",
            "Транспортувальники повернення агломерату",
            "Тушільщікі агломерату",
            "Формувальники, старші формувальники",
            "Чистильники колосників",
            "Чугунщікі, старші чугунщікі",
            "Шихтувальники агломерату",
            "Шлаковики"});
            this.tb22_2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb22_2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb22_2.Location = new System.Drawing.Point(81, 53);
            this.tb22_2.Name = "tb22_2";
            this.tb22_2.Size = new System.Drawing.Size(460, 20);
            this.tb22_2.TabIndex = 2;
            this.tb22_2.Tag = "";
            this.tb22_2.Text = "Горнові";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 51;
            this.label2.Text = "Виробництво\r\nабо цех";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tb22_1
            // 
            this.tb22_1.AutoCompleteCustomSource.AddRange(new string[] {
            "Агломераційний цех",
            "Доменний цех",
            "Мартенівський цех",
            "Цех підготовки складів",
            "Ливарний цех",
            "Обжимний цех",
            "Цех гарячої прокатки тонкого листа",
            "Цех холодної прокатки № 1",
            "Цех холодної прокатки № 2",
            "Цех холодної прокатки № 3"});
            this.tb22_1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb22_1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb22_1.Location = new System.Drawing.Point(81, 12);
            this.tb22_1.Name = "tb22_1";
            this.tb22_1.Size = new System.Drawing.Size(460, 20);
            this.tb22_1.TabIndex = 1;
            this.tb22_1.Text = "Доменний цех";
            // 
            // gb2_2
            // 
            this.gb2_2.Controls.Add(this.tb2_5);
            this.gb2_2.Controls.Add(this.tb2_4);
            this.gb2_2.Controls.Add(this.tb2_3);
            this.gb2_2.Controls.Add(this.tb2_2);
            this.gb2_2.Controls.Add(this.tb2_1);
            this.gb2_2.Location = new System.Drawing.Point(247, 79);
            this.gb2_2.Name = "gb2_2";
            this.gb2_2.Size = new System.Drawing.Size(140, 190);
            this.gb2_2.TabIndex = 3;
            this.gb2_2.TabStop = false;
            this.gb2_2.Text = "Число захворювань (n)";
            // 
            // tb2_5
            // 
            this.tb2_5.Location = new System.Drawing.Point(37, 159);
            this.tb2_5.Name = "tb2_5";
            this.tb2_5.Size = new System.Drawing.Size(56, 20);
            this.tb2_5.TabIndex = 8;
            this.tb2_5.Text = "0";
            this.tb2_5.TextChanged += new System.EventHandler(this.tb2_5_TextChanged);
            this.tb2_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_5_KeyPress);
            // 
            // tb2_4
            // 
            this.tb2_4.Location = new System.Drawing.Point(37, 124);
            this.tb2_4.Name = "tb2_4";
            this.tb2_4.Size = new System.Drawing.Size(56, 20);
            this.tb2_4.TabIndex = 7;
            this.tb2_4.Text = "0";
            this.tb2_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_4_KeyPress);
            // 
            // tb2_3
            // 
            this.tb2_3.Location = new System.Drawing.Point(37, 97);
            this.tb2_3.Name = "tb2_3";
            this.tb2_3.Size = new System.Drawing.Size(56, 20);
            this.tb2_3.TabIndex = 6;
            this.tb2_3.Text = "0";
            this.tb2_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_3_KeyPress);
            // 
            // tb2_2
            // 
            this.tb2_2.Location = new System.Drawing.Point(37, 70);
            this.tb2_2.Name = "tb2_2";
            this.tb2_2.Size = new System.Drawing.Size(56, 20);
            this.tb2_2.TabIndex = 5;
            this.tb2_2.Text = "0";
            this.tb2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb2_2_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.chex,
            this.posada,
            this.index});
            this.dataGridView1.Location = new System.Drawing.Point(12, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(529, 118);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "№";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // chex
            // 
            this.chex.HeaderText = "Цех";
            this.chex.Name = "chex";
            // 
            // posada
            // 
            this.posada.HeaderText = "Посада";
            this.posada.Name = "posada";
            // 
            // index
            // 
            this.index.HeaderText = "Індекс";
            this.index.Name = "index";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(198, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Додати данні";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 57;
            this.button5.TabStop = false;
            this.button5.Text = "Видалити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(93, 399);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 58;
            this.button6.TabStop = false;
            this.button6.Text = "Видалити обрані";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 431);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gb2_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb22_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb22_1);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.lb12);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(570, 470);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Розрахунок індексу професійного ризику";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gb2_2.ResumeLayout(false);
            this.gb2_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb2_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.Label lb12;
        private System.Windows.Forms.Label lab2_5;
        private System.Windows.Forms.Label lab2_1;
        private System.Windows.Forms.Label lab2_4;
        private System.Windows.Forms.Label lab2_2;
        private System.Windows.Forms.Label lab2_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb22_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb22_1;
        private System.Windows.Forms.GroupBox gb2_2;
        private System.Windows.Forms.TextBox tb2_5;
        private System.Windows.Forms.TextBox tb2_4;
        private System.Windows.Forms.TextBox tb2_3;
        private System.Windows.Forms.TextBox tb2_2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn chex;
        private System.Windows.Forms.DataGridViewTextBoxColumn posada;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}