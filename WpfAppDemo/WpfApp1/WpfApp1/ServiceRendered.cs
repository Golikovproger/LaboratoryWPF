//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceRendered
    {
        public int IdOrder { get; set; }
        public int IdService { get; set; }
        public int IdAnalyzerOperation { get; set; }
        public int IdAssistant { get; set; }
        public System.DateTime DateAndTimeOfCompletion { get; set; }
    
        public virtual AnalyzerOperation AnalyzerOperation { get; set; }
        public virtual Laborants Laborants { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Services Services { get; set; }
    }
}
