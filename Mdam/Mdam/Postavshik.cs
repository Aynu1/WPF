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
    
    public partial class Postavshik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postavshik()
        {
            this.Flowers = new HashSet<Flower>();
        }
    
        public int IDPostavshika { get; set; }
        public string FIO { get; set; }
        public string Adres { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flower> Flowers { get; set; }
    }
}
