using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data;

namespace bd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var s = db.Sotrudniki.ToList();
                foreach (Sotrudnik c in s)
                {
                    dataGridView1.Rows.Add(c.Код_сотрудника, c.ФИО, c.Должность, c.Дата_найма, c.Дата_Рождения, c.Телефон, c.Адрес, c.Оклад);
                }

                var d = db.Dogovori.ToList();
                foreach (Dogovor l in d)
                {
                    dataGridView2.Rows.Add(l.Номер_договора, l.Код_сотрудника, l.Код_клиента, l.Код_предмета, l.Дата_заказа, l.Цена_изделия, l.Дата_платежа);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Hide();
        }
    }
}