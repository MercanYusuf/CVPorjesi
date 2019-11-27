using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using YusufCv.Models.Entity;

namespace YusufCv.Models.dataContext
{
    public class dataContext:DbContext
    {
        public dataContext():base("YusufCV")
        {
            
        }
     public DbSet<Hakkimda> Hakkimda { get; set; }
     public DbSet<Deneyimler> Deneyimler { get; set; }
     public DbSet<Egitim> Egitim { get; set; }
     public DbSet<Hobiler> Hobiler { get; set; }
     public DbSet<SosyalMedya> SosyalMedya { get; set; }
     public DbSet<Proje> Proje { get; set; }
     public DbSet<ProgramalamaDili> ProgramalamaDili { get; set; }
     public DbSet<Kimlik> Kimlik { get; set; }
     
        public DbSet<Admin> Admin { get; set; }
    }
}