   M S B A M L   `   `   `  ����V  RTransport Management Syatem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Transport_Management_System.Admin_Dashboard+Transport_Management_System.Admin_Dashboard  5      C    =Transport_Management_System.Admin_Dashboard.Show_Vehicle_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Transport_Management_System.Admin_Dashboard     5        N� Title$  Show_Vehicle_Page��5	       N� 
Background �#f2f2f2.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      5      �� 5      5      .+�5      � $��1��6    5      �� 5      5      �� 5      5!      .+�5#      �� -   5        $��1��5#      $��20��6)   $��60��65   $
��Left=�6@   $��20q�6[   .��6   Search6�   �� 5$      -   5         ��Name$ VehicleTextBox��5$   *   $��0��6   $��Center=�6C   $��	0,10,0,10q�6e   $��30��6x   $
��Left=�6�   $	��230��6�   $'��!Enter Vehicle Registration Number��6�   
�������$��11(�6�   5%      �� 5&      -   5         ��Name$ VehicleLabel��5&   !   $��0��6   $��Vehicles��67   $��30(�6J   $
��Bold"�6X   $	��Top=�6j   $��0,0,0,10q�6�   5'      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ VehicleGrid��5(   N   $��1��6   $��0,0,10,0q�6       AutoGenerateColumns$ False��62   ��6c   �� *
Vehicles+   Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn	   Header$!	 Vehicle Registration Number��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6i      
IsReadOnly$
 True��6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *
Vehicle_Id+6s     5+      $	 Vehicle Type��6%   $
 * 6\   $
 True��6f    6;   �� *Vehicle_Type+6f     5,      $	 Location Status��6%   $
 * 6Y   $
 True��6c    6>   �� *Status+6c   50      � 52   
   $��2��6    53      �� 54      $	��93* �6#   �� 55      $
��288* �6#   �� 56      $
��380* �6#   58      59      5:      