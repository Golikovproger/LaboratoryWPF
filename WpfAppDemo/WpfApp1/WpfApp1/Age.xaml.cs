using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Age.xaml
    /// </summary>
    public partial class Age : Window
    {
        public Age()
        {
            InitializeComponent();
            ((LineSeries)GraphicChart.Series[0]).ItemsSource =
                new KeyValuePair<DateTime, int>[]
                {
                    new KeyValuePair<DateTime, int>(DateTime.Now, 100),
                    new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(1), 120),
                    new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(2), 120),
                    new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(3), 90),
                    new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(4), 130)
                };
        }
    }
}
