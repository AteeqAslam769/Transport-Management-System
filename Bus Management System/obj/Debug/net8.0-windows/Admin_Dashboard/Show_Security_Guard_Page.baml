   M S B A M L   `   `   `  ����V  RTransport Management Syatem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulli9clr-namespace:Transport_Management_System.Admin_Dashboard+Transport_Management_System.Admin_Dashboard  5      J    DTransport_Management_System.Admin_Dashboard.Show_Security_Guard_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Klocal9clr-namespace:Transport_Management_System.Admin_Dashboard     5        N� Title$  Show_Security_Guard_Page��5	       N� 
Background �#f2f2f2.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      5      �� 5      5      .+�5      � $��1��6    5      �� 5      5      �� 5       5"      .+�5$      �� -   5        $��1��5$      $��20��6)   $��60��65   $
��Left=�6@   $��20q�6[   .��6�   Search6�   �� 5%      -   5         ��Name$  SecurityGuardSearchTextBox��5%   *   $��0��6   $��12(�6N   $��Center=�6\   $��	0,10,0,10q�6~   $��30��6�   $
��Left=�6�   $	��230��6�   $��Enter Email��6�   
�������6�   5&      �� 5(      -   5         ��Name$ SecurityGuardLabel��5(   1   $��2��6   $��0��6!   $��Security Guards��6M   $��30(�6g   $
��Bold"�6u   $	��Top=�6�   $��	0,10,0,10q�6�   5)      &   System.Windows.Controls.DataGrid  5*   
   -   5          Name$ SecurityGuardDataGrid��5*   N   $��1��6   $��0,0,10,0q�6       AutoGenerateColumns$ False��62   ��6m   �� *SecurityGuards+   Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6L      
IsReadOnly$
 True��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6V     5-      $	 Email��6%   $
 * 6N   $
 True��6X    64   �� *Email+6X     5.      $
	 Role��6%   $
 * 6L   $
 True��6V    63   �� *Role+6V   51      52      53      