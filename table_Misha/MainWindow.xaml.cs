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
using table_Misha.Model;

namespace table_Misha
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            table.Items.Add(new DataItem() {ImageSource = "/Data/img/red-question-mark.png", DateAndTime = new DateTime(2023, 7, 14,  05, 23, 14), LocationTag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", TripValue = "NaN", LiveValue = "NAN", Units = "КГ/Ч" });
            table.Items.Add(new DataItem() {ImageSource = "/Data/img/yellow-question-mark.png", DateAndTime = new DateTime(2023, 7, 18, 05, 23, 14), LocationTag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", TripValue = "NaN", LiveValue = "NAN", Units = "КГ/Ч" });
            table.Items.Add(new DataItem() {ImageSource = "/Data/img/red-question-mark.png", DateAndTime = new DateTime(2024, 7, 18, 05, 23, 14), LocationTag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", TripValue = "NaN", LiveValue = "NAN", Units = "КГ/Ч" });
            table.Items.Add(new DataItem() {ImageSource = "/Data/img/yellow-exclamation-mark.png", DateAndTime = new DateTime(2053, 7, 18, 05, 23, 14), LocationTag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", TripValue = "NaN", LiveValue = "NAN", Units = "КГ/Ч" });
            table.Items.Add(new DataItem() {ImageSource = "/Data/img/red-exclamation-mark.png", DateAndTime = new DateTime(2029, 7, 18, 05, 23, 14), LocationTag = "RIF", Source = "FI1740", Condition = "BAD PV", Prionity = "L 00", Description = "HOT WATER E_1717", TripValue = "NaN", LiveValue = "NAN", Units = "КГ/Ч" });
        }
    }
}
