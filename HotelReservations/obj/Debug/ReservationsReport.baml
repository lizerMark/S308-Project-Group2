   M S B A M L   `   `   `  ����L  HHotelReservations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HotelReservationsHotelReservations  5   	   *    $HotelReservations.ReservationsReport   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HotelReservations     5   	   -   5          �Name$  winReservationsReport��5   	    � Title$ ReservationsReport��5   	   $	��388��6$   $	��694��61   .��5	      � ���	#FFE6E6F0.+�5
   
   �� -   5         ��Name$ lblReservationsReportP5��5
      $��Reservations Report��61   $
��Left=�6O   $��31��6j   $	��Top=�6v   $	��214��6�   $��16(�6�   $��Verdana)�6�   �� 5   
   -   5         ��Name$ btnMainMenuP5��5      $��	Main Menu��6(   $
��Left=�6<   $��	38,39,0,0q�6W   $	��Top=�6j   $	��115��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnNewReservationP5��5      $��New Reservation��6.   $
��Left=�6H   $��187.631,39,0,0q�6c   $	��Top=�6{   $	��115��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnRoomManagementP5��5      $��Room Management��6.   $
��Left=�6H   $��344.631,39,0,0q�6c   $	��Top=�6{   $	��123��6�   $��Verdana)�6�   �� 5   
   -   5        $ btnReservationsReportP5��5      $��Reservations Report��62   $
��Left=�6P   $��500,39,-107,0q�6k   $	��Top=�6�   $	��124��6�   $��Verdana)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateCheckOutP5��5      $
��Left=�6-   $��104,137,0,0q�6H   $	��Top=�6]   $	��100��6u   $��10.667(�6�     5   
   -   5        $ dateCheckInP5��5      $
��Left=�6,   $��
104,87,0,0q�6G   $	��Top=�6[   $	��100��6s   $��10.667(�6      Text$	 ddd��6�   �� 5   
   -	   5        $ lblCheckInDateLabelP5��5      $��Check-In Date:��6/   $
��Left=�6H   $��5,87,0,0q�6c   $	��Top=�6u   $��32��6�   $	��113��6�   $��Verdana)�6�   $��10.667(�6�   �� 5   
   -
   5        $ lblCheckOutDateP5��5      $��Check-Out Date:��6+   $
��Left=�6E   $��	5,136,0,0q�6`   $	��Top=�6s   $��32��6�   $	��123��6�   $��Verdana)�6�   $��10.667(�6�   �� 5   
   -   5        $ lblLastNameP5��5      $��
Last Name:��6'   $
��Left=�6<   $��	5,184,0,0q�6W   $	��Top=�6j   $��32��6�   $	��123��6�   $��Verdana)�6�   $��10.667(�6�   �� 5   
   -   5        $ lblRoomTypeP5��5      $��
Room Type:��6'   $
��Left=�6<   $��	5,236,0,0q�6W   $	��Top=�6j   $��32��6�   $	��123��6�   $��Verdana)�6�   $��10.667(�6�   �� 5   
   -   5         ��Name$ txtLastNameP5��5      $
��Left=�6)   $��23��6D   $��104,186,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $��Li��6y   $	��Top=�6�   $	��100��6�   $��10.667(�6�   �� 5   
   -   5         ��Name$ cboRoomTypeP5��5      $
��Left=�6*   $��106,237,0,0q�6E   $	��Top=�6Z   $��99��6r   	 �� SelectedIndex$	 0��6}   $��10.667(�6�   .@�5      �� $��One King��6   5      �� 5   
   -   5        $ btnSubmitP5��5      $��Submit��6&   $
��Left=�67   $��104,291,0,0q�6R   $	��Top=�6g   $��67��6   $��10.667(�6�   �� 5   
   -   5        
 ��Name$
 imgP5��5      $
��Left=�6   $��50��6:   $��636,317,0,-10q�6F   $	��Top=�6]   $��50��6u   $��Images/Image1.png��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgReportP5��5      $
��Left=�6(   $��
251,87,0,0q�6C   $	��Top=�6W   $	��222��6o   $	��373��6|   5      5      