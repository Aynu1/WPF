//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qwer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Otdel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Otdel()
        {
            this.Shtatnoe_raspisanie = new HashSet<Shtatnoe_raspisanie>();
            this.Sotrudnikis = new HashSet<Sotrudniki>();
        }
    
        public int kod_otdela { get; set; }
        public string Name_otdela { get; set; }
        public double Kabinet { get; set; }
        public string Phone_otdela { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shtatnoe_raspisanie> Shtatnoe_raspisanie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sotrudniki> Sotrudnikis { get; set; }
    }
}
