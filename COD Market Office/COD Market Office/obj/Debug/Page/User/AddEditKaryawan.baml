   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.UserCOD_Market_Office.Page.User  5   	   1    +COD_Market_Office.Page.User.AddEditKaryawan   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:COD_Market_Office.Page.User     5   	     � Title$  AddEditKaryawan��5   	   $
��auto��6!   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;    � 
ResizeMode$ NoResize=�6`    � ShowInTaskbar .   � SizeToContent$ Height=�5	   	    � Topmost . .��5
      � $��8q�6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Nomor Telepon��6   $��0��6(   $��0��65   �� 5   
   -   5         ��Name$ tbTelp��5      $��0��6"   $��1��6/   $��8q�6?   �� 5   
   -   5        $��2��5      $��0��6!      btnback#��[  6.   .��5      �� $��/Assets/search.ico��6   5      �� 5   
   $��1��6   $��0��6   $
��Nama��6-   �� 5   
   -   5        	 ��Name$	 lblName��5   Y   $��1��6   $��1��6   $
��Nama��6-   $��Center=�6<   6Y   �� 5   
   $��2��6   $��0��6   $��Sebagai��6-   $��Center=�6?   �� 5    
   -   5        
 ��Name$
 cbGrant��5    <   $��2��6   $��1��6    $��4q�61   6<   �� 5!   
   -   5         ��Name$ 	cbEnabled��5!   <   $��3��6   $��0��6    $��4q�61   $��3��6O   $��Center=�6c   $��Blokir��6�   �� 5"   
   -   5         ��Name$ btnSave��5"      $��0��6;   $��4��6K   $��3��6X   $��Simpan��6l   $��4q�6}   5#      5$      