using Project.ENTİTİES.Modals;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
   public  class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BransMap());
            modelBuilder.Configurations.Add(new DoktorHemsireMap());
            modelBuilder.Configurations.Add(new DoktorMap());
            modelBuilder.Configurations.Add(new HastaMap());
            modelBuilder.Configurations.Add(new HemsireMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new RandevuMap());

        }

        public DbSet<Brans> Branslar { get; set; }

        public DbSet<DoktorHemsire> DoktorHemsireler{ get; set; }

        public DbSet<Doktor> Doktorlar { get; set; }

        public DbSet<Hasta> Hastalar { get; set; }

        public DbSet<Hemsire> Hemsireler { get; set; }

        public DbSet<Personel> Personeller { get; set; }

        public DbSet<Randevu> Randevular { get; set; }
    }
}
