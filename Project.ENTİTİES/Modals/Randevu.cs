using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Randevu:BaseEntity
    {
       public DateTime RandevuZamani { get; set; }
        

        //Relational Properties
        public virtual Hasta Hasta { get; set; }
    }
}
