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
    
    public partial class Analyzer
    {
        public int Code_Service { get; set; }
        public System.DateTime DateOfStart { get; set; }
        public System.DateTime DateOfWork { get; set; }
        public bool isDelete { get; set; }
    
        public virtual Services Services { get; set; }
    }
}
