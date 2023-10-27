using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class DoktorHemsire:BaseEntity
    {
        public int DoktorID { get; set; }
        public int HemsireID { get; set; }
        //Relational Properties
        public virtual Doktor Doktor { get; set; }

        public virtual  Hemsire Hemsire { get; set; }
    }

}
