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
    
    public partial class Komandirovki
    {
        public int ID_Sotrudnika { get; set; }
        public string Kuda_komandirovan { get; set; }
        public double nomer_prikaza { get; set; }
        public System.DateTime Date_prikaza { get; set; }
        public System.DateTime Date_nachala { get; set; }
        public System.DateTime Date_okonchaniya { get; set; }
        public double Kolvo_dney { get; set; }
        public string Cel_komandirovki { get; set; }
    
        public virtual Sotrudniki Sotrudniki { get; set; }
    }
}
