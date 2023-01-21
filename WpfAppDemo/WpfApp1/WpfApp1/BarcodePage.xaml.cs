using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using IronBarCode;
using IronSoftware.Drawing;
using app;
using System.Data.Entity;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для BarcodePage.xaml
    /// </summary>
    public partial class BarcodePage : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Context context = new Context();
      
        TimeSpan time { get; set; }
        TimeSpan timeClosed = new TimeSpan(3,1,0);

        public BarcodePage()
        {
            InitializeComponent();
            var bitmapImage = new BitmapImage();
            timer.Start();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);

            gridPatient.ItemsSource = context.PatientData.ToList();
            analizatorGrid.ItemsSource = context.OrderLaboratoryServices.Select(a => new { a.IdOrder, a.IdService, a.ServiceStatus }).ToList();
            //bitmapImage.BeginInit();
            ////bitmapImage.UriSource = new Uri($"C:\\Users\\mrsas\\Desktop\\LaboratoryWPF\\WpfAppDemo\\WpfApp1\\WpfApp1\\Sources\\{User.userType}.png");
            //bitmapImage.EndInit();
            //avatarImg.Source = bitmapImage;

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (time == timeClosed)
            {
                this.Close();
            }
            else
                time += timer.Interval;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewOrderPage order = new NewOrderPage();
            order.Show();
        }
       
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            timer.Stop();
            LoginInput lg = new LoginInput();
            lg.login = User.login;
            
            lg.time = time;
            context.LoginInput.Add(lg);
            context.SaveChangesAsync();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<Patients> patient = new List<Patients>();
            patient.AddRange(context.PatientData.Where(a => a.IdPatient.ToString() == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.Guid == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.HistoryAddress == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.InsurancePolicyNumber == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.IP == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.Login == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.PassportNumber == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.PassportSeries == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.Password == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.Telephone == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.TypeOfInsurancePolicy == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.FullName == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.Email == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.EIN == txtSearch.Text).ToList());
            patient.AddRange(context.PatientData.Where(a => a.DateOfBirth.ToString() == txtSearch.Text).ToList());
            gridPatient.ItemsSource = patient;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            ResetTable();

        }
        private void ResetTable()
        {
            context.PatientData.Load();
            gridPatient.ItemsSource = context.PatientData.Local.ToList();
            gridPatient.Items.Refresh();
        }
    }
}
