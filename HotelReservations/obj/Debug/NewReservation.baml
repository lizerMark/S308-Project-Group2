   M S B A M L   `   `   `  ����L  HHotelReservations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HotelReservationsHotelReservations  5   	   &     HotelReservations.NewReservation   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HotelReservations     5   	   -   5          �Name$  winNewReservation��5   	    � Title$ NewReservation��5   	   $	��388��6    $	��694��6-   .��5	      � ���	#FFE6E6F0.+�5
   
   �� -   5         ��Name$ btnMainMenuP2��5
      $��	Main Menu��6(   $
��Left=�6<   $��	48,39,0,0q�6W   $	��Top=�6j   $	��115��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnNewReservationP2��5      $��New Reservation��6.   $
��Left=�6H   $��
199,39,0,0q�6c   $	��Top=�6w   $	��115��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnRoomManagementP2��5      $��Room Management��6.   $
��Left=�6H   $��
344,39,0,0q�6c   $	��Top=�6w   $	��119��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnReservationsReportP2��5      $��Reservations Report��62   $
��Left=�6P   $��
499,39,0,0q�6k   $	��Top=�6   $	��124��6�   $��Verdana)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateCheckOutP2��5      $
��Left=�6-   $��134,204,0,0q�6H   $	��Top=�6]   $	��120��6u     5   
   -   5        $ dateCheckInP2��5      $
��Left=�6,   $��134,154,0,0q�6G   $	��Top=�6\   $	��120��6t   �� 5   
   -   5         ��Name$ cboRoomTypeP2��5      $
��Left=�6*   $��134,105,0,0q�6E   $	��Top=�6Z   $	��120��6r    �� SelectedIndex$ 0��6~   .@�5      �� $��One King��6   5      �� 5   
   -	   5         ��Name$ sldRoomNumberP2��5      $
��Left=�6*   $��134,254,0,0q�6E   $	��Top=�6Z   $	��120��6r    � Minimum$ 1Q�6~   �� 5   
   -
   5         ��Name$ lblRoomTypeLabelP2��5      $��
Room Type:��6,   $
��Left=�6A   $��	8,101,0,0q�6\   $	��Top=�6o   $��32��6�   $��88��6�   $��Verdana)�6�   �� 5   
   -   5        $ lblCheckInDateLabelP2��5      $��Check-In Date:��6/   $
��Left=�6H   $��	8,154,0,0q�6c   $	��Top=�6v   $��32��6�   $	��113��6�   $��Verdana)�6�   �� 5   
   -   5        $ lblCheckOutDateP2��5      $��Check-Out Date:��6+   $
��Left=�6E   $��	8,203,0,0q�6`   $	��Top=�6s   $��32��6�   $	��123��6�   $��Verdana)�6�   �� 5   
   -   5        $ lblRoomNumbersLabelP2��5      $��Number of Rooms:��6/   $
��Left=�6J   $��	8,249,0,0q�6e   $	��Top=�6x   $��32��6�   $	��123��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnGetQuoteP2��5      $��	Get Quote��6(   $
��Left=�6<   $��134,319,0,0q�6W   $	��Top=�6l   $	��120��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnProceedQuoteP2��5      $��Proceed With Quote��6,   $
��Left=�6I   $��406,319,0,0q�6d   $	��Top=�6y   $	��128��6�   $��Verdana)�6�   �� 5   
   -   5        $ lblNewReservationP2��5      $��New Reservation��6-   $
��Left=�6G   $��31��6b   $	��Top=�6n   $	��214��6�   $��16(�6�   $��Verdana)�6�   �� 5   
   -   5        	 ��Name$	 imgP2��5      $
��Left=�6   $��50��6:   $��636,319,0,-12q�6F   $	��Top=�6]   $��50��6u   $��Images/Image1.png��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 
dtgQuoteP2��5      $
��Left=�6'   $��344,101,0,0q�6B   $	��Top=�6W   $	��171��6o   $	��279��6|   5      5      