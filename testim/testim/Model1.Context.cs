﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testim
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class testPrimerEntities : DbContext
    {
        public testPrimerEntities()
            : base("name=testPrimerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dolzgnost> Dolzgnosts { get; set; }
        public virtual DbSet<Med_obsledovaniya> Med_obsledovaniya { get; set; }
        public virtual DbSet<Otdel> Otdels { get; set; }
        public virtual DbSet<Otpuska> Otpuskas { get; set; }
        public virtual DbSet<Pasportnie_dannie> Pasportnie_dannie { get; set; }
        public virtual DbSet<Pooshreniya> Pooshreniyas { get; set; }
        public virtual DbSet<Shtatnoe_raspisanie> Shtatnoe_raspisanie { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Komandirovki> Komandirovkis { get; set; }
        public virtual DbSet<Soc_lgoti> Soc_lgoti { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Uvolneniya> Uvolneniyas { get; set; }
    }
}
