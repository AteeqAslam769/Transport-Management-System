   M S B A M L   `   `   `  ����V  RTransport Management Syatem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�[clr-namespace:Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_PagesMTransport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages  5      c    ]Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.View_Users_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      mlocal[clr-namespace:Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages     5        N� Title$  View_Users_Page��5	       N� 
Background �#f2f2f2.��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      5      �� 5      5      .+�5      � $��1��6    5      �� 5      5      �� 5       5"      .+�5$      �� -   5        $��1��5$      $��20��6)   $��60��65   $
��Left=�6@   $��20q�6[   .��6}   Search6�   �� 5%      -   5         ��Name$ AdminSearchTextBox��5%   *   $��0��6   $��Center=�6G   $��	0,10,0,10q�6i   $��30��6|   $
��Left=�6�   $	��230��6�   $��Enter Email��6�   
�������6�   5&      �� 5'      -   5         ��Name$ AdminsLabel��5'   !   $��0��6   $��Admins��66   $��30(�6G   $
��Bold"�6U   $	��Top=�6g   $��0,0,0,10q�6�   5(      &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ AdminsDataGrid��5)   N   $��1��6   $��0,0,10,0q�6       AutoGenerateColumns$ False��62   ��6f   �� *Admins+   Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6L      
IsReadOnly$
 True��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6V     5,      $	 Email��6%   $
 * 6N   $
 True��6X    64   �� *Email+6X     5-      $
	 Role��6%   $
 * 6L   $
 True��6V    63   �� *Role+6V   50      � 52   
   $��2��6    53      �� 54      56      �� 57      59      .+�5;      � $��1��6    5<      �� 5=      5?      �� 5@      5B      .+�5D      �� -   5        $��1��5D      $��20��6)   $��60��65   $
��Left=�6@   $��20q�6[   .��6�   Search6�   �� 5E      -   5        $  SecurityGuardSearchTextBox��5E   *   $��0��6   $��12(�6N   $��Center=�6\   $��	0,10,0,10q�6~   $��30��6�   $
��Left=�6�   $	��230��6�   $��Enter Email��6�   
�������6�   5F      �� 5H      -   5        $ SecurityGuardLabel��5H   1   $��2��6   $��0��6!   $��Security Guards��6M   $��30(�6g   $
��Bold"�6u   $	��Top=�6�   $��	0,10,0,10q�6�   5I        5J   
   -   5        $ SecurityGuardDataGrid��5J   N   $��3��6   $��0,0,10,0q�6    $ False��62   ��6m   �� *SecurityGuards+ 5K        5L      $
	 Name��6%   $
 * 6L   $
 True��6V    63   �� *Name+6V     5M      $	 Email��6%   $
 * 6N   $
 True��6X    64   �� *Email+6X     5N      $
	 Role��6%   $
 * 6L   $
 True��6V    63   �� *Role+6V   5Q      5R      5S      