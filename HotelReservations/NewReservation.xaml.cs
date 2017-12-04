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
    /// Interaction logic for NewReservation.xaml
    /// </summary>
    public partial class NewReservation : Window
    {
        public NewReservation()
        {
            InitializeComponent();
            //Declare variables

            string strRoomTypeP2 = cboRoomTypeP2.SelectedIndex.ToString();

            string strCheckInDateP2 = dateCheckInP2.ToString();

            string strCheckOutDateP2 = dateCheckOutP2.ToString();

            string strNumberOfRoomsP2 = sldRoomNumberP2.ToString();



            //Set up Nav bar

            //Validate the input

            //Import room data

            //"Get quote" button (with calculations) and display report

            //Proceed with quote should export to JSON (??????)

            //Link Proceed with Quote to Customer Details
        }

    }
}
