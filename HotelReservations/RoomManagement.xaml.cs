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
    /// Interaction logic for RoomManagement.xaml
    /// </summary>
    public partial class RoomManagement : Window
    {
        public RoomManagement()
        {
            InitializeComponent();
            //Declare Variables
            int intAdminRoomNumberKingP3 = Convert.ToInt32(txtRoomNumberKingP3.Text.Trim());
            int intAdminRoomNumberKingDeluxeP3 = Convert.ToInt32(txtRoomNumberKingDeluxeP3.Text.Trim());
            int intAdminRoomNumberQueenP3 = Convert.ToInt32(txtRoomNumberQueensP3.Text.Trim());
            int intAdminRoomNumberQueenDeluxeP3 = Convert.ToInt32(txtRoomNumberQueensDeluxeP3.Text.Trim());
            int intAdminRoomNumberKingSuiteP3 = Convert.ToInt32(txtRoomNumberKingSuiteP3.Text.Trim());
            int intAdminRoomNumberPresidentialP3 = Convert.ToInt32(txtRoomNumberPresidentialP3.Text.Trim());
            int intInputRoomNumberKingP3 = Convert.ToInt32(txtRoomNumberKing1P3.Text.Trim());
            int intInputRoomNumberKingDeluxeP3 = Convert.ToInt32(txtRoomNumberKingDeluxe1P3.Text.Trim());
            int intInputRoomNumberQueenP3 = Convert.ToInt32(txtRoomNumberQueens1P3.Text.Trim());
            int intInputRoomNumberQueenDeluxeP3 = Convert.ToInt32(txtRoomNumberQueensDeluxe1P3.Text.Trim());
            int intInputRoomNumberKingSuiteP3 = Convert.ToInt32(txtRoomNumberKingSuite1P3.Text.Trim());
            int intInputRoomNumberPresidentialP3 = Convert.ToInt32(txtRoomNumberPresidential1P3.Text.Trim());

            string strAdminRoomNumberKingP3 = Convert.ToString(txtRoomNumberKingP3.Text.Trim());
            string strAdminRoomNumberKingDeluxeP3 = Convert.ToString(txtRoomNumberKingDeluxeP3.Text.Trim());
            string strAdminRoomNumberQueenP3 = Convert.ToString(txtRoomNumberQueensP3.Text.Trim());
            string strAdminRoomNumberQueenDeluxeP3 = Convert.ToString(txtRoomNumberQueensDeluxeP3.Text.Trim());
            string strAdminRoomNumberKingSuiteP3 = Convert.ToString(txtRoomNumberKingSuiteP3.Text.Trim());
            string strAdminRoomNumberPresidentialP3 = Convert.ToString(txtRoomNumberPresidentialP3.Text.Trim());
            string strInputRoomNumberKingP3 = Convert.ToString(txtRoomNumberKing1P3.Text.Trim());
            string strInputRoomNumberKingDeluxeP3 = Convert.ToString(txtRoomNumberKingDeluxe1P3.Text.Trim());
            string strInputRoomNumberQueenP3 = Convert.ToString(txtRoomNumberQueens1P3.Text.Trim());
            string strInputRoomNumberQueenDeluxeP3 = Convert.ToString(txtRoomNumberQueensDeluxe1P3.Text.Trim());
            string strInputRoomNumberKingSuiteP3 = Convert.ToString(txtRoomNumberKingSuite1P3.Text.Trim());
            string strInputRoomNumberPresidentialP3 = Convert.ToString(txtRoomNumberPresidential1P3.Text.Trim());

            //Validate input (fields are not required but are either intergers or doubles)

            if (!Int32.TryParse(strInputRoomNumberKingP3, out intInputRoomNumberKingP3)) 
            {
                MessageBox.Show("Please enter a valid price.");
                    }
            if (!Int32.TryParse(strInputRoomNumberKingDeluxeP3, out intInputRoomNumberKingDeluxeP3))
            {
                MessageBox.Show("Please enter a valid price.");
            }

            double dblAdminPriceKingP3 = Convert.ToDouble(txtPriceKingP3.Text.Trim());
            double dblAdminPriceKingDeluxeP3 = Convert.ToDouble(txtPriceKingDeluxeP3.Text.Trim());
            double dblAdminPriceQueenP3 = Convert.ToDouble(txtPriceQueensP3.Text.Trim());
            double dblAdminPriceQueenDeluxeP3 = Convert.ToDouble(txtPriceQueenDeluxeP3.Text.Trim());
            double dblAdminPriceKingSuiteP3 = Convert.ToDouble(txtPriceKingSuiteP3.Text.Trim());
            double dblAdminPricePresidentialP3 = Convert.ToDouble(txtPricePresidentialP3.Text.Trim());
            double dblInputPriceKingP3 = Convert.ToDouble(txtPriceKing1P3.Text.Trim());
            double dblInputPriceKingDeluxeP3 = Convert.ToDouble(txtPriceKingDeluxe1P3.Text.Trim());
            double dblInputPriceQueenP3 = Convert.ToDouble(txtPriceQueens1P3.Text.Trim());
            double dblInputPriceQueenDeluxeP3 = Convert.ToDouble(txtPriceQueenDeluxe1P3.Text.Trim());
            double dblInputPriceKingSuiteP3 = Convert.ToDouble(txtPriceKingSuite1P3.Text.Trim());
            double dblInputPricePresidentialP3 = Convert.ToDouble(txtPricePresidential1P3.Text.Trim());

            string strAdminPriceKingP3 = Convert.ToString(txtPriceKingP3.Text.Trim());
            string strAdminPriceKingDeluxeP3 = Convert.ToString(txtPriceKingDeluxeP3.Text.Trim());
            string strAdminPriceQueenP3 = Convert.ToString(txtPriceQueensP3.Text.Trim());
            string strAdminPriceQueenDeluxeP3 = Convert.ToString(txtPriceQueenDeluxeP3.Text.Trim());
            string strAdminPriceKingSuiteP3 = Convert.ToString(txtPriceKingSuiteP3.Text.Trim());
            string strAdminPricePresidentialP3 = Convert.ToString(txtPricePresidentialP3.Text.Trim());
            string strInputPriceKingP3 = Convert.ToString(txtPriceKing1P3.Text.Trim());
            string strInputPriceKingDeluxeP3 = Convert.ToString(txtPriceKingDeluxe1P3.Text.Trim());
            string strInputPriceQueenP3 = Convert.ToString(txtPriceQueens1P3.Text.Trim());
            string strInputPriceQueenDeluxeP3 = Convert.ToString(txtPriceQueenDeluxe1P3.Text.Trim());
            string strInputPriceKingSuiteP3 = Convert.ToString(txtPriceKingSuite1P3.Text.Trim());
            string strInputPricePresidentialP3 = Convert.ToString(txtPricePresidential1P3.Text.Trim());

            //Set up nav bar

            //Import from text file to left-hand text boxes upon opening

            //Validate input (fields are not required but are either intergers or doubles)


            //Submit change button is reflected by left-hand text box changing and export

            //ASK ABOUT ROOM QUANTITY (IS IT NUMBER BUILT OR NUMBER AVAILABLE?)
        }
    }
}
