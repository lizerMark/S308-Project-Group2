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
    /// Interaction logic for ReservationsReport.xaml
    /// </summary>
    public partial class ReservationsReport : Window
    {
        public ReservationsReport()
        {
            InitializeComponent();

            //Declare variables
            DateTime datDateCheckInP5 = dateCheckInP5.SelectedDate.Value;
            DateTime datDateCheckOutP5 = dateCheckOutP5.SelectedDate.Value;
            string strLastNameP5 = txtLastNameP5.Text.Trim();
            string strRoomTypeP5 = cboRoomTypeP5.SelectedIndex.ToString();
        //Create Nav bar

            //Validate filters

            //"Submit" button
            //1) Import all reservation data
            //2) Apply filters (date range, last name, or both)
            //3) Display filtered results

        }
    }
}
