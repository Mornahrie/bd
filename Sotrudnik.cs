using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class Sotrudnik
    {
        public int Код_сотрудника { get; set; }
        public string ФИО { get; set; }
        public string Должность { get; set; }
        public string Дата_найма { get; set; }
        public string Дата_Рождения { get; set; }
        public string Телефон { get; set; }
        public string Адрес { get; set; }
        public int Оклад { get; set; }
    }
}