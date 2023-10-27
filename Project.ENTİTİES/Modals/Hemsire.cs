using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Hemsire:BaseEntity
    {
        public string HemsireIsmi { get; set; }

        public string HemsireSoyIsmi { get; set; }
        //Relational Properties

        public virtual List<Hasta> Hastalar{ get; set; }

        public virtual List<DoktorHemsire> DoktorHemsireler { get; set; }
    }
}
