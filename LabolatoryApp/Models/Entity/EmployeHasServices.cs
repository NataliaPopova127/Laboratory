//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabolatoryApp.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeHasServices
    {
        public int Id_Employee { get; set; }
        public int Id_Services { get; set; }
        public Nullable<bool> isDelete { get; set; }
    
        public virtual Employes Employes { get; set; }
        public virtual Services Services { get; set; }
    }
}
