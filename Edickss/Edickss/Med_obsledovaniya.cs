//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Edickss
{
    using System;
    using System.Collections.Generic;
    
    public partial class Med_obsledovaniya
    {
        public int ID { get; set; }
        public System.DateTime Data_obsledovaniya { get; set; }
        public string Mesto { get; set; }
        public string Zakluchenie_vracha { get; set; }
    
        public virtual Sotrudniki Sotrudniki { get; set; }
    }
}
