   M S B A M L   `   `   `  ����  Transport Management Syatem>    8Transport_Management_System.Super_Admin_Dashboard_Window   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Super Admin Dashboard��5   	   $	��450��6'   $	��800��64   ���#f2f2f2 � 
ResizeMode$ NoResize=�5   	    � Icon 5      �� 5   
    �� 	UriSource$; 5C:\Users\Ateeq\Desktop\EAD\Final Project\Bus_logo.ico?�6   .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      6   .+�5   
    � -   5          �Name$ 	MainFrame��5   *   $��1��6   $	��390��6     � NavigationUIVisibility$ Hidden=�6=   o� 5   
   $	��Top=�6   
���   �$��40��6:   $��0��6F    K� ZIndex$ 1��6S   
�������.@�5      m� -   5        $��	Home Page��5      $��0,0,2,0q�6*   
�������$
��Bold"�6X   $	��100��6j   $��40��6v   5      m� 5      $��Manage Users��6   $��0,0,2,0q�6-   
�������$
��Bold"�6[   $	��120��6m   $��Center=�6z   $��40��6�   .@�5      m� -   5        $��
View Users��5      ���#3336A   m� 5      -   5        $��Add User��5      ���#3336?   m� 5      -   5        $��
Edit Users��5      ���#3336A   m� 5      -   5        $��Delete Users��5      ���#3336C   5      m� 5"      $��Manage Vehicles��6   $��0,0,2,0q�60   
�������$
��Bold"�6^   $	��120��6p   $��40��6|   .@�5$      m� -   5        $��View Vehicle��5$      ���#3336C   m� 5%      -   5        $��Add Vehicle��5%      ���#3336B   m� 5&      -	   5        $��Edit Vehicle��5&      ���#3336C   m� 5'      -
   5        $��Delete Vehicle��5'      ���#3336E   5(      m� 5)      -   5        $��Logout��5)      $
��Bold"�6'   $��0,0,2,0q�69   
�������$	��100��6g   $
��Left=�6t   $��40��6�   6�   5*      � 50   
   $��1��6   .+�51      �� -   5         ��Name$ delstack��51      $��1��6+   $��Center=�68   $��Center=�6S   $y�	Collapsed=�6p   .+�52      �� -   5        	 ��Name$	 DelStackLable��52      $��Center=�6/   $��16(�6L   $��0,0,0,10q�6Z   $
��Bold"�6l   .��6~   .,Enter Email Of The Person You Want To Delete6�   �� 54      -   5        
 ��Name$
 
delTextBox��54      $��16(�6.   $	��200��6<   $��30��6H   $��Center=�6T   $��0,0,0,10q�6q   �� 56      -   5         ��Name$ DelStackButton��56   A   $��20��6   $��80��6%   $��Delete��60   6Y   57      �� 58      -   5        $ 	editstack��58      $��1��6,   $��Center=�69   $��Center=�6T   $y�Visible=�6q   .+�59      �� -   5        $	 EditStackLable��59      $��Center=�60   $��16(�6M   $��0,0,0,10q�6[   $
��Bold"�6m   .��6   ,*Enter Email Of The Person You Want To Edit6�   �� 5;      -   5        $
 editTextBox��5;      $��16(�6/   $	��200��6=   $��30��6I   $��Center=�6U   $��0,0,0,10q�6r   �� 5=      -   5        $ EditStackButton��5=   ?   $��20��6   $��80��6%   $
��Edit��60   6X   5>      5?      5@      5A      