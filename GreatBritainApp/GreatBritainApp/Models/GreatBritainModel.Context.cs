﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreatBritainApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GreatBritainEntities : DbContext
    {
        private static GreatBritainEntities _context;

        public static GreatBritainEntities GetContext()
        {
            if (_context == null)
            {
                _context = new GreatBritainEntities();
            }
            return _context;
        }
        public GreatBritainEntities()
            : base("name=GreatBritainEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Productcsv> Productcsvs { get; set; }
        public virtual DbSet<productxlsx> productxlsxes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
