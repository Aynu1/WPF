//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlowersMagazine2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlowersMagEntities : DbContext
    {
        private static FlowersMagEntities _context;
        public FlowersMagEntities()
            : base("name=FlowersMagEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public static FlowersMagEntities GetContext()
        {
            if (_context == null)
                _context = new FlowersMagEntities();
            return _context;
        }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dostavka> Dostavka { get; set; }
        public virtual DbSet<Flowers> Flowers { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudnik { get; set; }
        public virtual DbSet<SposobOplati> SposobOplati { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<Uslugi> Uslugi { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
        public virtual DbSet<FlowerZakaz> FlowerZakaz { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}
