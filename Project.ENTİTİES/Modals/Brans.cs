using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Brans:BaseEntity
    {
        public string  DoktorBransi { get; set; }
        //Relational Properties
        public virtual  List<Doktor> Doktorlar { get; set; }
    }
}
