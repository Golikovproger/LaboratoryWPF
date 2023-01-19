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
using IronBarCode;
using IronSoftware.Drawing;
using app;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для NewOrder.xaml
    /// </summary>
    public partial class NewOrderPage : Window
    {
        Context context = new Context();
       
        public NewOrderPage()
        {
            InitializeComponent();
            BarcodeName.Text = context.BarcodePatient.Max(a => a.Id+1).ToString();
        }

        private void CreateNewOrder_Click(object sender, RoutedEventArgs e)
        {
            IronBarCode.License.LicenseKey = "IRONBARCODE.MAKSIMGOLIKOV19.18683-424C4949F3-T7O6YS72AT5OHZDN-XZ2YABQJ7M4Q-WO5U2P2XYVDO-EM6ECLSFENYC-OWENHZ3LN3LW-22Z52Z-TMUBSE2473WIUA-DEPLOYMENT.TRIAL-RWEYXA.TRIAL.EXPIRES.17.FEB.2023";
            Random rnd = new Random();
            int uniqcode = rnd.Next(100000,999999);
            string b = BarcodeName.Text + DateTime.Now.ToShortDateString().Replace(".", "") + uniqcode.ToString() ; //id+uniqcode+date
            var myBarcode = BarcodeWriter.CreateBarcode(b, BarcodeWriterEncoding.Code128);
            myBarcode.ResizeTo(290, 120);

            myBarcode.AddBarcodeValueTextBelowBarcode();
            myBarcode.SaveAsPdf("EAN8.pdf");
            MessageBox.Show("Штрих код успешно сохранен");
            this.Close();
        }
    }
}
