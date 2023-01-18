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
    
    public partial class Patients
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patients()
        {
            this.BarcodePatient = new HashSet<BarcodePatient>();
            this.Orders = new HashSet<Orders>();
        }
    
        public int IdPatient { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Guid { get; set; }
        public string Email { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string EIN { get; set; }
        public string TypeOfInsurancePolicy { get; set; }
        public string Telephone { get; set; }
        public string PassportSeries { get; set; }
        public string PassportNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int IdInsuranceCompany { get; set; }
        public string IP { get; set; }
        public string HistoryAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BarcodePatient> BarcodePatient { get; set; }
        public virtual InsuranceCompany InsuranceCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
