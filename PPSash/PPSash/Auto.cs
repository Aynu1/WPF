//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPSash
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public partial class Auto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auto()
        {
            this.SelledAutoes = new HashSet<SelledAuto>();
        }
        public string GetPhoto
        {
            get
            {
                if (Image is null)
                    return null;
                return Directory.GetCurrentDirectory() + @"\Images\" + Image.Trim();
            }
        }
        public int Id_auto { get; set; }
        public string GosNomer { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public Nullable<int> YearBorn { get; set; }
        public Nullable<float> Price { get; set; }
        public Nullable<float> PriceDay { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> DateVidacha { get; set; }
    
        public virtual TypeAuto TypeAuto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SelledAuto> SelledAutoes { get; set; }
    }
}
