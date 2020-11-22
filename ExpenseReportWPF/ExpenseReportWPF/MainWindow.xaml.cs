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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExpenseReportWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<ExpenseItem> expenses = new List<ExpenseItem>();
            expenses.Add(new ExpenseItem()
                {
                    Date = new DateTime(2020, 11, 20),
                    ExpenseName = "New Steam Game",
                    ExpenseType = "Entertainment",
                    Amount = 4.99
                }
            );

            expenses.Add(new ExpenseItem()
                {
                    Date = new DateTime(2020, 11, 21),
                    ExpenseName = "Waitrose online order",
                    ExpenseType = "Groceries",
                    Amount = 70.59
                }
            );

            expenses.Add(new ExpenseItem()
                {
                    Date = new DateTime(2020, 11, 20),
                    ExpenseName = "Amazon new power cord",
                    ExpenseType = "Misc",
                    Amount = 7.59
                }
            );

            dgTest.ItemsSource = expenses;
        }

        public class ExpenseItem
        {
            public DateTime Date { get; set; }
            public string ExpenseName { get; set; }
            public string ExpenseType { get; set; }
            public double Amount { get; set; }

        }
    }
}
