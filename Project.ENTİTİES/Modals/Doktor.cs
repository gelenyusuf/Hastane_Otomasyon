using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Doktor:BaseEntity
    {
        public string DoktorIsmi { get; set; }
        public string DoktorBrans { get; set; }

        public int? BransID { get; set; }
        //Relational properties
        public virtual  List<Hasta>  Hastalar{ get; set; }
        public virtual Brans Brans { get; set; }

        public virtual List<DoktorHemsire> DoktorHemsireler { get; set; }

    }
}
