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
    using System.Collections.Generic;
    using System.IO;
    public partial class Flowers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flowers()
        {
            this.FlowerZakaz = new HashSet<FlowerZakaz>();
        }
        public string GetPhoto
        {
            get
            {
                if (image is null)
                    return null;
                return Directory.GetCurrentDirectory() + @"\Images\" + image.Trim();
            }
        }
        public int FlowerID { get; set; }
        public string Naimenovanie { get; set; }
        public double Price { get; set; }
        public Nullable<int> Kolichestvo { get; set; }
        public string image { get; set; }
    
        public virtual Postavshik Postavshik { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlowerZakaz> FlowerZakaz { get; set; }
    }
}
