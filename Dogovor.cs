using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Dogovor
    {
        public int Номер_договора { get; set; }
        public int Код_клиента { get; set; }
        public int Код_предмета { get; set; }
        public int Код_сотрудника { get; set; }
        public string Дата_заказа { get; set; }
        public int Цена_изделия { get; set; }
        public string Дата_платежа { get; set; }
    }
}