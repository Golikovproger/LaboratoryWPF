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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LaboratoryEntities1 : DbContext
    {
        public LaboratoryEntities1()
            : base("name=LaboratoryEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<AnalyzerOperation> AnalyzerOperation { get; set; }
        public virtual DbSet<AnalyzerOperationOrder> AnalyzerOperationOrder { get; set; }
        public virtual DbSet<BarcodePatient> BarcodePatient { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompany { get; set; }
        public virtual DbSet<Laborants> Laborants { get; set; }
        public virtual DbSet<LoginInput> LoginInput { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<ServiceRendered> ServiceRendered { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<InsuranceCompanyAccounts> InsuranceCompanyAccounts { get; set; }
        public virtual DbSet<OrderLaboratoryServices> OrderLaboratoryServices { get; set; }
    }
}
