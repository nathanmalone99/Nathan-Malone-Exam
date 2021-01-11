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

namespace Ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Account> accounts;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            accounts = new List<Account>();

            CurrentAccount acc1 = new CurrentAccount() {FirstName = "Nathan", LastName = "Malone", AccountNumber = 1001, Balance = 5000, InterestDate = 11/01/2021};
            SavingsAccount acc2 = new SavingsAccount() {FirstName = "Raymond", LastName = "Gallagher", AccountNumber = 2785, Balance = 2743, InterestDate = 11/01/2021};

            accounts.Add(acc1);
            accounts.Add(acc2);

            UpdateListBox(accounts);

            cbxCurrent_Account.IsChecked = true;
            cbxSavings_Account.IsChecked = true;
        }


        public void UpdateListBox(List<Account> accounts)
        {
            accounts.Sort();

            lbx_Accounts.ItemsSource = null;
            lbx_Accounts.ItemsSource = accounts;
        }
    }
}
