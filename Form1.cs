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
                    dataGridView1.Rows.Add(c.���_����������, c.���, c.���������, c.����_�����, c.����_��������, c.�������, c.�����, c.�����);
                }

                var d = db.Dogovori.ToList();
                foreach (Dogovor l in d)
                {
                    dataGridView2.Rows.Add(l.�����_��������, l.���_����������, l.���_�������, l.���_��������, l.����_������, l.����_�������, l.����_�������);
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