using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    public class Predmet_zaloga
    {
        public int Код_предмета { get; set; }
        public string Предмет_залога { get; set; }
        public int Вес { get; set; }
        public bool Наличие_камней { get; set; }
        public string Проба { get; set; }
        public string Металл { get; set; }
    }
}
