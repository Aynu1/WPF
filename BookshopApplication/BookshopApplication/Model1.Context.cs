//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookshopApplication
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bookshopEntities : DbContext
    {
        public bookshopEntities()
            : base("name=bookshopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<catalog> catalogs { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<february> februaries { get; set; }
    }
}
