//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mdam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            this.FlowerZakazs = new HashSet<FlowerZakaz>();
            this.Uslugis = new HashSet<Uslugi>();
        }
    
        public int IDZakaza { get; set; }
        public int ClientID { get; set; }
        public string ClientAdres { get; set; }
        public string ClientCity { get; set; }
        public string DataZakaza { get; set; }
        public string DataDostavki { get; set; }
        public int DostavkaID { get; set; }
        public string DostavkaPrice { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Dostavka Dostavka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlowerZakaz> FlowerZakazs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uslugi> Uslugis { get; set; }
    }
}
