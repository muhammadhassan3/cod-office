   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.JasaCOD_Market_Office.Page.Jasa  5   	   ,    &COD_Market_Office.Page.Jasa.AddKatJasa   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:COD_Market_Office.Page.Jasa     5   	     � Title$  Tambah Kategori Jasa��5   	   $	��400��6&   $	��800��63    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ NoResize=�6d    � ShowInTaskbar .   � Topmost . .��5	      � $��8q�6    � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ image��5      $	��200��6   $��2��6,   $��0��6@   $��Center=�6P   $��8q�6m   $��Uniform=�6x   $	��500��6�   �� 5   
   -   5        $��Pilih File...��5      $��1��6)   $��0��66   $��8q�6F   6Q   �� 5   
   -   5         ��Name$ fileSize��5   ~   $��1��6   $��1��6   $
��Size��6-   $��Center=�6<   $��8q�6W   $��Right=�6b   6~   �� 5   
   $��2��6   $��0��6   $��Nama Kategori��6-   �� 5   
   -   5        	 ��Name$	 tbName��5   /   $��2��6   $��1��6   6/   �� 5   
   -   5        
 ��Name$
 	cbVisible��5   A   $��Tampil��6   $��0��6$   $��3��64   $��2��6T   $��Center=�6h   �� 5   
   -   5         ��Name$ btnSave��5      $��Simpan��6"   $��Center=�63   $��Center=�6P   $��4��6�   $��2��6�   $��0��5      5      5      