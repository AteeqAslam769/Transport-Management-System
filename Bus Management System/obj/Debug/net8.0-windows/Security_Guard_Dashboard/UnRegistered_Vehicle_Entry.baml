   M S B A M L   `   `   `  ����  Transport Management SyatemU    OTransport_Management_System.Security_Guard_Dashboard.UnRegistered_Vehicle_Entry   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$   UnRegistered_Vehicle_Entry��5       N� 
Background �#F0F0F0.��5      �  � RowDefinitions 5   
   �� 5      $	��180 �6   6+   �� 5      6   .+�5   
   � $��0��6    5      �� 5      $	��120 �6    6/   �� 5      6"   .+�5      � $��0��6    � ColumnDefinitions 5      �� 5      6)   �� 5      6)   .+�5      �� -   5         ��Name$ 
RegTextBox��5      $��0��6.   $��30��6>   $	��250��6J   
�������$��Enter Registration Number��6h   $��4,4,0,0q�6�   $��14(�6�   $��Right=�6�   $��0,0,20,0q�6  6  �� 5      -   5        $ TypeTextBox��5      $��1��6/   $��30��6?   $	��250��6K   
�������$��Enter Vehicle Type��6i   $��4,4,0,0q�6�   $��14(�6�   $
��Left=�6�   $��20,0,0,0q�6�   6  5      � 5       $��1��6    5!      �� 5"      6)   �� 5#      6)   .+�5%      �� -   5        $��30��5%      $	��100��6%   $��Entered��61   $��18(�6C   $��0,0,20,0q�6R   $��Center=�6d   $��Right=�6   6�   �� 5&      -   5        $��1��5&      $��30��6)   $	��100��65   $��Exited��6A   $��18(�6R   $��20,0,0,0q�6a   $��Center=�6s   $
��Left=�6�   6�   5'      5(      &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ VehicleMovmentGrid��5)       $��1��6   $��
20,20,20,0q�6<   $	��150��6P      AutoGenerateColumns$ False��6]      
IsReadOnly$
 True��6y   $	��Top=�6�      Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 120 6E   
   Header$
 Vehicle Movment Id��6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6&   �� *
MovementId+6o     5,      $		 170 6T   $!
 Vehicle Registration Number��6`    6&   �� *VehicleRegistrationNumber+6�     5-      $	 80 6F   $
 Vehicle Type��6Q    6&   �� *VehicleType+6i     5.      $		 110 6I   $
 Movement Status��6U    6&   �� *MovementStatus+6p     5/      $	 90 6H   $
 Vehicle Status��6S    6&   �� *VehicleStatus+6m     50      $	 * 6?   $

 Date��6I    6&   �� *Date+6Y     51      $	 * 6?   $

 Time��6I    6&   �� *Time+6Y     52      $	 * 6>   $	
 Day��6H    6&   �� *Day+6W   54      56      57      