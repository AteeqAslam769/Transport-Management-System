   M S B A M L   `   `   `  ����  Transport Management Syateme    _Transport_Management_System.Super_Admin_Dashboard.Super_Admin_Dashboard_Pages.Edit_Vehicle_Page   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Edit_Vehicle��5       N� 
Background �#f2f2f2.��5      � -   5         �Name$ mainGrid��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $ ��Vehicle Found With Details��6   $��Center=�6B   $��0,5,0,0q�6_   $��	ExtraBold"�6p   $��24(�6�   ���#3333336�   �� 5   
   $��2��6   $��Vehicle ID:��6   $��Center=�63   $��
180,10,0,0q�6N   $��18(�6b   $
��Bold"�6p   ���#3333336�   �� 5   
   -   5         ��Name$ VehicleIDTextBox��5      $��2��6,   $��
180,10,0,0q�69   $	��300��6M   $��34��6Y   $��12(�6e   $
��Bold"�6s   $��8q�6�   $��1q�5      ���#cccccc���#ffffff6<   �� 5   
   $��3��6   $��Vehicle Type:��6   $��Center=�65   $��
180,10,0,0q�6P   $��18(�6d   $
��Bold"�6r   ���#3333336�   �� 5   
   -   5         ��Name$ VehicleTypeComboBox��5      $��3��60   $��
180,10,0,0q�6=   $	��300��6Q   $��34��6]   $��12(�6i   $
��Bold"�6w   $��1q�5       ���#cccccc���#ffffff.@�5!      �� $	��Car��6   $
��Bold"�6)   �� 5"      $��Truck��6   $
��Bold"�6+   �� 5#      $��
Motorcycle��6   $
��Bold"�60   �� 5$      $��Bicycle��6   $
��Bold"�6-   �� 5%      $	��Van��6   $
��Bold"�6)   �� 5&      $	��Bus��6   $
��Bold"�6)   5'      �� 5*   
   -   5         ��Name$ 
editbutton��5*      $��4��6%   $��Update Vehicle��62   $��Center=�6K   $��Center=�6h   $	��200��6�   $��40��6�   $��18(�6�   ���	#FF3366CC
�������$��0q�5+   ;   $
��Bold"�6O   $��0,20,0,0q�6a    J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-         Color$ #666666��6#   	   	Direction$		 315Q�63   
   ShadowDepth$
 3Q�6C      Opacity$	 0.5Q�6S   5/      50      51      