using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Modals
{
    public abstract class BaseEntity
    {

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        //Oluşturulma zamanı

        public DateTime? ModifiedDate { get; set; }
        //Değiştirilme zamanı

        public DateTime? DeletedDate { get; set; }
        //silinme zamanı
        public DataStatus  Status { get; set; }
        
    }
}
