//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReadyProduct
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public partial class Product
    {
        public string GetPhoto
        {
            get
            {
                if (Photo is null)
                    return null;
                return Directory.GetCurrentDirectory() + @"\Images\" + Photo.Trim();
            }
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<float> Gramm { get; set; }
        public string Photo { get; set; }
        public Nullable<float> Price { get; set; }
    
        public virtual Type_product Type_product { get; set; }
    }
}
