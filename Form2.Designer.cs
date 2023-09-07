namespace bd
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fio = new DataGridViewTextBoxColumn();
            dolg = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            dateofb = new DataGridViewTextBoxColumn();
            tele = new DataGridViewTextBoxColumn();
            adress = new DataGridViewTextBoxColumn();
            oklad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fio, dolg, date, dateofb, tele, adress, oklad });
            dataGridView1.Location = new Point(34, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(838, 411);
            dataGridView1.TabIndex = 1;
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
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 435);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}