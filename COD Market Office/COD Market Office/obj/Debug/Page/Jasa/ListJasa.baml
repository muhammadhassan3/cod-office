   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null?$clr-namespace:COD_Market_Office.PageCOD_Market_Office.Page  5      %    COD_Market_Office.Page.ListJasa   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:COD_Market_Office.Page     5      $��8 0 8 0q�5   7   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5           btnBack#��[  5        btnback#��[ 64   6U   �� 5   
   $��Kategori��6   $��1��6$   $��0��61   $��0 0 0 8q�6A   �� 5   
   -   5         ��Name$ btnAdd��5      $��2��6!   $��0��6.   $��Tambah��6>   $��0 0 4 8q�6O   6`   �� 5   
   -   5        $ btnEdit��5      $��2��6"   $��1��6/   $
��Ubah��6?   $��0 0 4 8q�6N   6_   �� 5   
   -   5        $ 	btnDelete��5      $��2��6$   $��2��61   $��Hapus��6A   $��0 0 4 8q�6Q   $y�Hidden=�6b   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataKat��5   4   $��3��6   $��3��6    $	��350��6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5       $
 Nama��6%    63   �� *nama+  5!      $ Tampil��6%    65   �� *	isVisible+  5"      $ Terdapat Gambar��6%    6>   �� *isImageAvailable+5$        5&   
   -   5        $ dataItem��5&   U   $��3��6   $��3��6#   $��3��67   $��8 0 0 0q�6D    5'        5(      $ Id��6%    61   �� *id+  5)      $ 	Nama Jasa��6%    68   �� *nama+  5*      $ Alamat��6%    65   �� *alamat+  5+      $
 Telp��6%    63   �� *telp+  5,      $ 	Deskripsi��6%      MaxWidth$	 250Q�68    6G   �� *text+  5-      $ 
Total View��6%    69   �� *	viewers+  5.      $ Paket��6%    64   �� *packageList+  5/      $ Blokir��6%    65   �� *	isBlocked+  50      $ Tampil��6%    65   �� *	isVisible+  51      $ Latitude��6%    67   �� *
latitude+  52      $ 	Longitude��6%    68   �� *	longitude+55      56      57      