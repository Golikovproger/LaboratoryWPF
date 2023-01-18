using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfApp1;

namespace app
{
    class Context : DbContext
    {
        public Context()
            : base("LaboratoryEntities")
        { }

        public DbSet<Manager> Accountant { get; set; }
        public DbSet<LoginInput> LoginInput { get; set; }
        public DbSet<Admins> Administrator { get; set; }
        public DbSet<AnalyzerOperationOrder> AnalyzerOperationOrder { get; set; }
        public DbSet<BarcodePatient> BarcodePatient { get; set; }
        public DbSet<Laborants> DataOfLaboratoryAssistants { get; set; }
        public DbSet<AnalyzerOperation> DataOnAnalyzerOperation { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompany { get; set; }
        public DbSet<InsuranceCompanyAccounts> InsuranceCompanyAccounts { get; set; }
        public DbSet<Services> LaboratoryServices { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<OrderLaboratoryServices> OrderLaboratoryServices { get; set; }
        public DbSet<Patients> PatientData { get; set; }
        public DbSet<ServiceRendered> ServiceRendered { get; set; }


    }
}