using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var s = db.Sotrudniki.ToList();
                foreach (Sotrudnik c in s)
                {
                    dataGridView1.Rows.Add(c.Код_сотрудника, c.ФИО, c.Должность, c.Дата_найма, c.Дата_Рождения, c.Телефон, c.Адрес, c.Оклад);
                }
            }
        }
    }
}
