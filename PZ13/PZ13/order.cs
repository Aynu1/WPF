//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PZ13
{
    using System;
    using System.Collections.Generic;
    
    public partial class order
    {
        public int order_ID { get; set; }
        public System.DateTime o_time { get; set; }
        public int o_number { get; set; }
    
        public virtual book book { get; set; }
        public virtual user user { get; set; }
    }
}
