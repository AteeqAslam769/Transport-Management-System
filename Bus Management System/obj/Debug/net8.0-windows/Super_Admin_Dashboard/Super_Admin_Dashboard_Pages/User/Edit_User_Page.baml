   M S B A M L   `   `   `  ����V  RTransport Management Syatem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�[clr-namespace:Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_PagesMTransport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages  5      b    \Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Edit_User_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      mlocal[clr-namespace:Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages     5        N� Title$  	Edit_User��5	       N� 
Background �#f2f2f2.��5      � -   5         �Name$ mainGrid��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��User Found With Details��6   $��Center=�6?   $��0,5,0,0q�6\   $��	ExtraBold"�6m   $��24(�6�   ���#3333336�   �� 5   
   $��2��6   $��Name:��6   $��Center=�6-   $��
180,10,0,0q�6H   $��18(�6\   $
��Bold"�6j   ���#3333336|   �� 5   
   -   5         ��Name$ NameTextBox��5      $��2��6'   $��
180,10,0,0q�64   $	��300��6H   $��34��6T   $��12(�6`   $
��Bold"�6n   $��8q�6�   $��1q�5       ���#cccccc���#ffffff6<   �� 5#   
   $��3��6   $��Email:��6   $��Center=�6.   $��
180,10,0,0q�6I   $��18(�6]   $
��Bold"�6k   ���#3333336}   �� 5$   
   -   5        $ EmailTextBox��5$      $��3��6(   $��
180,10,0,0q�65   $	��300��6I   $��34��6U   $��12(�6a   $��8q�6o   $
��Bold"�6{   $��1q�5%      ���#cccccc���#ffffff6<   �� 5(   
   $��4��6   $��	Password:��6   $��Center=�61   $��
180,10,0,0q�6L   $��18(�6`   $
��Bold"�6n   ���#3333336�   G� 5)   
   -   5         G�Name$ PasswordBox��5)      $��4��6+   $��
180,10,0,0q�68   $	��300��6L   $��34��6X   $��12(�6d   $��8q�6r   $
��Bold"�6~   $��1q�5*      ���#cccccc���#ffffff6@   �� 5-   
   $��5��6   $��Role:��6   $��Center=�6-   $��
180,10,0,0q�6H   $��18(�6\   $
��Bold"�6j   ���#3333336|   �� 5.   
   -   5         ��Name$ RoleComboBox��5.      $��5��6)   $��
180,10,0,0q�66   $	��300��6J   $��34��6V   $��12(�6b   $
��Bold"�6p   $��8q�6�   $��1q�5/      ���#cccccc���#ffffff.@�50      �� $��Admin��6   6-   �� 51      $��Security Guard��6   66   53      �� 56   
   -   5         ��Name$ 
editbutton��56      $��7��6%   $��Update User��62   $��Center=�6H   $��Center=�6e   $	��200��6�   $��40��6�   $��18(�6�   ���	#FF3366CC
�������$��0q�57   ;   $
��Bold"�6O   $��0,20,0,0q�6a    J� Effect 59      3  -System.Windows.Media.Effects.DropShadowEffect  5:      	   Color$	 #666666��6#   
   	Direction$	
 315Q�63      ShadowDepth$ 3Q�6C      Opacity$	 0.5Q�6S   5<      5=      5>      