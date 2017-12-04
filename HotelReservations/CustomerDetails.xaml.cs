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

namespace HotelReservations
{
    /// <summary>
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : Window
    {
        public CustomerDetails()
        {
            InitializeComponent();

            //Declare variables
            string strFirstNameP4 = txtFirstNameP4.Text.Trim();

            string strLastNameP4 = txtLastNameP4.Text.Trim();

            string strPhoneP4 = txtPhoneP4.Text.Trim();

            string strEmailP4 = txtEmailP4.Text.Trim();

            string strCreditCardTypeP4 = cboCreditCard.SelectedIndex.ToString();

            string strCardNumberP4 = txtCardP4.Text.Trim();

            //Set up Nav Bar

            //Validate Input (everything but email is required)

            //Confirm button exports to the file and also clears the form
        }
    }
}
