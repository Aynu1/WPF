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
    
    public partial class SposobOplati
    {
        public int SposobOplatiID { get; set; }
        public string SposobOplati1 { get; set; }
    
        public virtual Client Client { get; set; }
    }
}