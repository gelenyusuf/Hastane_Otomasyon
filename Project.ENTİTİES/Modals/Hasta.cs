using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public class Hasta:BaseEntity
    {
        public string  HastaIsmi { get; set; }

        public string  HastaSoyIsmi { get; set; }

        public string HastaSikayeti { get; set; }

        public int? DoktorID { get; set; }
        public int? HemsireID{ get; set; }

        

        //Relational Properties
        public int? PersonelID { get; set; }
        public virtual Doktor Doktor { get; set; }

        public virtual Personel Personel{ get; set; }
        public virtual Hemsire Hemsire { get; set; }

        public virtual Randevu Randevu { get; set; }

    }
}
