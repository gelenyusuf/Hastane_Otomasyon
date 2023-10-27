using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Personel:BaseEntity
    {
        public string  PersonelIsmi { get; set; }

        public string PersonelSoyIsmi { get; set; }

        //Relational Properties
        public virtual List<Hasta> Hastalar { get; set; }
    }
}
