namespace bd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fio = new DataGridViewTextBoxColumn();
            dolg = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            dateofb = new DataGridViewTextBoxColumn();
            tele = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            oklad = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            number = new DataGridViewTextBoxColumn();
            codes = new DataGridViewTextBoxColumn();
            codecl = new DataGridViewTextBoxColumn();
            codepr = new DataGridViewTextBoxColumn();
            datez = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            datepl = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fio, dolg, date, dateofb, tele, adress, oklad });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(838, 196);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Код сотрудника";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // fio
            // 
            fio.HeaderText = "ФИО";
            fio.Name = "fio";
            fio.ReadOnly = true;
            // 
            // dolg
            // 
            dolg.HeaderText = "Должность";
            dolg.Name = "dolg";
            dolg.ReadOnly = true;
            // 
            // date
            // 
            date.HeaderText = "Дата найма";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // dateofb
            // 
            dateofb.HeaderText = "Дата Рождения";
            dateofb.Name = "dateofb";
            dateofb.ReadOnly = true;
            // 
            // tele
            // 
            tele.HeaderText = "Телефон";
            tele.Name = "tele";
            tele.ReadOnly = true;
            // 
            // adress
            // 
            adress.HeaderText = "Адрес";
            adress.Name = "adress";
            adress.ReadOnly = true;
            // 
            // oklad
            // 
            oklad.HeaderText = "Оклад";
            oklad.Name = "oklad";
            oklad.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { number, codes, codecl, codepr, datez, price, datepl });
            dataGridView2.Location = new Point(62, 214);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(743, 204);
            dataGridView2.TabIndex = 1;
            // 
            // number
            // 
            number.HeaderText = "Номер договора";
            number.Name = "number";
            number.ReadOnly = true;
            // 
            // codes
            // 
            codes.HeaderText = "Код сотрудника";
            codes.Name = "codes";
            codes.ReadOnly = true;
            // 
            // codecl
            // 
            codecl.HeaderText = "Код клиента";
            codecl.Name = "codecl";
            codecl.ReadOnly = true;
            // 
            // codepr
            // 
            codepr.HeaderText = "Код предмета";
            codepr.Name = "codepr";
            codepr.ReadOnly = true;
            // 
            // datez
            // 
            datez.HeaderText = "Дата заказа";
            datez.Name = "datez";
            datez.ReadOnly = true;
            // 
            // price
            // 
            price.HeaderText = "Цена изделия";
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // datepl
            // 
            datepl.HeaderText = "Дата платежа";
            datepl.Name = "datepl";
            datepl.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(775, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Form2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fio;
        private DataGridViewTextBoxColumn dolg;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn dateofb;
        private DataGridViewTextBoxColumn tele;
        private DataGridViewTextBoxColumn adress;
        private DataGridViewTextBoxColumn oklad;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn number;
        private DataGridViewTextBoxColumn codes;
        private DataGridViewTextBoxColumn codecl;
        private DataGridViewTextBoxColumn codepr;
        private DataGridViewTextBoxColumn datez;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn datepl;
        private Button button1;
    }
}