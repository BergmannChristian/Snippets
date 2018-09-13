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

namespace Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Tracking user spending and total credit.
        static double CurrentUserCredit = 0.0;
        static double TotalMoneySpent = 0.0;



        public MainWindow()
        {
            InitializeComponent();
        }

        //Add value to the CurrentUserCredit variable.
        public void FundDeposit(double depositAmount)
        {
            double newBalance = CurrentUserCredit + depositAmount;

            if (newBalance > 5)
            {
                //Need to add an error message.
                return;
            }

            CurrentUserCredit = newBalance;

            DepositTicker(depositAmount);
            RefreshCreditDisplay();
        }
        //Increments a specified ticker on the GUI for each deposit made, based on the amount deposited.
        public void DepositTicker(double depositAmount)
        {
            switch (depositAmount)
            {
                case 1.00:
                    dollarTick.Text = (Int32.Parse(dollarTick.Text) + 1).ToString();
                    break;
                case 0.25:
                    quarterTick.Text = (Int32.Parse(quarterTick.Text) + 1).ToString();
                    break;
                case 0.10:
                    dimeTick.Text = (Int32.Parse(dimeTick.Text) + 1).ToString();
                    break;
                case 0.05:
                    nickelTick.Text = (Int32.Parse(nickelTick.Text) + 1).ToString();
                    break;
                case 0.01:
                    pennyTick.Text = (Int32.Parse(pennyTick.Text) + 1).ToString();
                    break;
            }
        }

        //Subtract value from the CurrentUserCredit variable.
        public void PurchaseItem(int itemPrice)
        {
            double newBalance = CurrentUserCredit - itemPrice; 

            if (newBalance < 0)
            {
                //need an error message
                return;
            }

            CurrentUserCredit = newBalance;
            TotalMoneySpent = TotalMoneySpent + itemPrice;
            RefreshCreditDisplay();
        }

        //Update GUI credit display with the current recorded amount of user credit.
        public void RefreshCreditDisplay()
        {
            userCreditDisplay.Text = "$" + CurrentUserCredit.ToString();
        }
        
        //All deposit buttons; 1.00, .25, .10, .05, .01
        private void DepositDollar_Click(object sender, RoutedEventArgs e)
        {
            FundDeposit(1.00);
        }
        private void DepositQuarter_Click(object sender, RoutedEventArgs e)
        {
            FundDeposit(0.25);
        }
        private void DepositDime_Click(object sender, RoutedEventArgs e)
        {
            FundDeposit(0.10);
        }
        private void DepositNickel_Click(object sender, RoutedEventArgs e)
        {
            FundDeposit(0.05);
        }
        private void DepositPenny_Click(object sender, RoutedEventArgs e)
        {
            FundDeposit(0.01);
        }
    }
}
