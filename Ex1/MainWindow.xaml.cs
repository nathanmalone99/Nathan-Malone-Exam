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

        //wgen window is loaded it will show the 2 oblects I created
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            accounts = new List<Account>();

            CurrentAccount cur1 = new CurrentAccount() {FirstName = "Nathan", LastName = "Malone", AccountNumber = 1001, Balance = 5000, InterestDate = 11/01/2021};
            SavingsAccount sav2 = new SavingsAccount() {FirstName = "Raymond", LastName = "Gallagher", AccountNumber = 2785, Balance = 2743, InterestDate = 11/01/2021};

            accounts.Add(cur1);
            accounts.Add(sav2);

            UpdateListBox(accounts);

            cbxCurrent_Account.IsChecked = true;
            cbxSavings_Account.IsChecked = true;
        }

        //method for updating the display
        public void UpdateListBox(List<Account> accounts)
        {
            accounts.Sort();

            lbx_Accounts.ItemsSource = null;
            lbx_Accounts.ItemsSource = accounts;
        }

        private void lbx_Accounts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selected = lbx_Accounts.SelectedItem as Account;

            if(selected != null)
            {
                tblkFirstname.Text = selected.FirstName;
                tblkLastName.Text = selected.LastName;
                

                if (selected is CurrentAccount)
                {
                    CurrentAccount cur = selected as CurrentAccount;

                    tblkAccountNumber.Text = cur.AccountNumber.ToString();
                    tblkBalance.Text = cur.Balance.ToString();
                    tblkInterestDate.Text = cur.InterestDate.ToString();

                    cbxCurrent_Account.IsChecked = true;
                }

                else if(selected is SavingsAccount)
                {
                    SavingsAccount sav = selected as SavingsAccount;

                    tblkAccountNumber.Text = sav.AccountNumber.ToString();
                    tblkBalance.Text = sav.Balance.ToString();
                    tblkInterestDate.Text = sav.InterestDate.ToString();

                    cbxSavings_Account.IsChecked = true;
                }
            }
        }
    }
}
