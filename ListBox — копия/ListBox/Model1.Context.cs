﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ListBox
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlowersMagEntities : DbContext
    {
        public FlowersMagEntities()
            : base("name=FlowersMagEntities")
        {
        }
        private static FlowersMagEntities _context;
        public static FlowersMagEntities GetContext()
        {
            if (_context == null)
            {
                _context = new FlowersMagEntities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Dostavka> Dostavkas { get; set; }
        public virtual DbSet<Flower> Flowers { get; set; }
        public virtual DbSet<Postavshik> Postavshiks { get; set; }
        public virtual DbSet<Sotrudnik> Sotrudniks { get; set; }
        public virtual DbSet<SposobOplati> SposobOplatis { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Uslugi> Uslugis { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }
        public virtual DbSet<FlowerZakaz> FlowerZakazs { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
