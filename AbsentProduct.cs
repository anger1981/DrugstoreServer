//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerOfSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class AbsentProduct
    {
        public int ID { get; set; }
        public int ID_PH { get; set; }
        public int ID_PR { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime Updating { get; set; }
    
        public virtual Pharmacy Pharmacy { get; set; }
    }
}
