//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace app_for_shashluk
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProductDB : DbContext
    {
        public ProductDB()
            : base("name=ProductDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Buyer> Buyer { get; set; }
        public virtual DbSet<Check> Check { get; set; }
        public virtual DbSet<Payment_type> Payment_type { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Type_product> Type_product { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
