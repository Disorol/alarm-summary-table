using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace table_Misha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            table.Items.Add(new Data_item() { Date_time = new DateTime(2023, 7, 14,  05, 23, 14), Location_tag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", Trip_value = "NaN", Live_value = "NAN", Units = "КГ/Ч" });
            table.Items.Add(new Data_item() { Date_time = new DateTime(2023, 7, 18, 05, 23, 14), Location_tag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", Trip_value = "NaN", Live_value = "NAN", Units = "КГ/Ч" });
        }
        /* hi */
        public class Data_item
        {
            public DateTime Date_time { get; set; }
            public string Location_tag { get; set; }
            public string Source { get; set; }
            public string Condition { get; set; }
            public string Prionity { get; set; }
            public string Description { get; set; }
            public string Trip_value { get; set; }
            public string Live_value { get; set; }
            public string Units { get; set; }
        }

        

    }
}
