   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullK*clr-namespace:COD_Market_Office.Page.StockCOD_Market_Office.Page.Stock  5   	   ,    &COD_Market_Office.Page.Stock.EditStock   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:COD_Market_Office.Page.Stock     5   	     � Title$  	EditStock��5   	   $
��auto��6   $	��800��6)    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6K    � SizeToContent$ Height=�6p   .��5	      � $��8q�6    � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��250 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ imgItem��5      $��Uniform=�6!   $��0��63   $��0��6C   $��2��6P   �� 5   
   $��1��6   $��0��6   $��0 8 4 8q�6-   .��6>   	Nama Item6I   �� 5   
   -   5         ��Name$ tbName��5   >   $��1��6   $��1��6   $��0 8 4 8q�6-   .��6N   	Nama Item6Y   �� 5   
   $��2��6   $��0��6   $��0 8 4 8q�6-   .��6>   Harga Retail6L   �� 5   
   -   5        $ tbRetailPrice��5   >   $��2��6   $��1��6   $��0 8 4 8q�6-   .��6U   	Nama Item6`   �� 5   
   $��3��6   $��0��6   $��0 8 4 8q�6-   .��6>   Harga Grosir6L   �� 5   
   -   5        $ 	tbGrocery��5   >   $��3��6   $��1��6   $��0 8 4 8q�6-   .��6Q   	Nama Item6\   �� 5   
   $��4��6   $��0��6   $��0 8 4 8q�6-   .��6>   Stok6D   �� 5   
   -   5         ��Name$ tbStock��5      $��4��6#   $��1��60   $	��0 8q�6@   �� 5   
   -   5        $��Simpan��5      $��0��6"   $��5��62   $��2��6?   $��4q�6S   6_   5       5!      