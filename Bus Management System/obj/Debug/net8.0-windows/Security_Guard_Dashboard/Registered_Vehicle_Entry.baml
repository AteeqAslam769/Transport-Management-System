   M S B A M L   `   `   `  ����  Transport Management SyatemS    MTransport_Management_System.Security_Guard_Dashboard.Registered_Vehicle_Entry   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Registered_Vehicle_Entry��5       N� 
Background �#F0F0F0.��5      �  � RowDefinitions 5   
   �� 5      $	��180 �6   6+   �� 5      $	��180 �6   6+   .+�5   
   � $��0��6    5      �� 5      $��35 �6    6.   �� 5      $	��100 �6    6/   �� 5      $��60 �6    6.   .+�5      �� $��Registered Vehicles��6   $��	20,0,20,0q�62   $��17(�6E   $
��Bold"�6S   6g   &   System.Windows.Controls.DataGrid  5      -   5          Name$ VehicleGrid��5   M   $��1��6   $	��100��6$      AutoGenerateColumns$ False��61   
����������#3498DB   
IsReadOnly$
 True��6�   $��	20,0,20,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H      Header$! Vehicle Registration Number��6R   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� *
Vehicle_Id+6y     5      $ * 6J   $ Vehicle Type��6T   	 6)   �� *Vehicle_Type+6l     5       $ * 6D   $ Current Status��6N   	 6)   �� *Status+6h   5"      � 5$      $��2��6   
 � ColumnDefinitions
 5%      �� 5&      6)   �� 5'      6)   .+�5)      �� -   5         ��Name$ EnteredButton��5)      $��Right=�60   $��0��6L   $��30��6\   $	��100��6h   $��Entered��6t   $
��bold"�6�   ���	#FF00AB00
�������$��5q�6�   $y�	Collapsed=�6�   �� 5*      -   5        $ ExitedButton��5*      $
��Left=�6/   $��1��6J   $��30��6Z   $	��100��6f   $��Exited��6r   $
��bold"�6�   ���	#FFF52525
�������$��5q�6�   $y�	Collapsed=�6�   5+      5,      � 5.   
   $��1��6   
 5/      �� 50      $��9* �6#   �� 51      $	��11* �6#    53      �� 54      $��30 �6    6.   �� 55      $	��100 �6!   60   �� 56      $��70 �6    6.   .+�58      �� $��Vehicles Entries��6   $
��Bold"�6/   $��18(�6A   $��	20,0,20,0q�6O   $��2��6b   6x     59      -   5        $ VehicleMovmentGrid��59      $��	20,0,20,0q�63   $	��100��6F   $ False��6S   $
 True��6o   $��1��6�   $��2��6�    5:        5;      $	 120 6I   $ Vehicle Movment Id��6U   	 6*   �� *
MovementId+6s     5<      $	 170 6X   $! Vehicle Registration Number��6d   	 6*   �� *VehicleRegistrationNumber+6�     5=      $ 80 6J   $ Vehicle Type��6U   	 6*   �� *VehicleType+6m     5>      $	 110 6M   $ Movement Status��6Y   	 6*   �� *MovementStatus+6t     5?      $ 90 6L   $ Vehicle Status��6W   	 6*   �� *VehicleStatus+6q     5@      $ * 6C   $
 Date��6M   	 6*   �� *Date+6]     5A      $ * 6C   $
 Time��6M   	 6*   �� *Time+6]     5B      $ * 6B   $	 Day��6L   	 6*   �� *Day+6[   5D      �� 5E      -   5        $ VehicleMovementGridButton��5E      $��30��68   $	��100��6D   $��2��6P   ���	#FFF52525
�������$
��Bold"�6�   $y�	Collapsed=�6�   $��2��6�   .��6�   Delete Entry6�   5G      5I      5J      