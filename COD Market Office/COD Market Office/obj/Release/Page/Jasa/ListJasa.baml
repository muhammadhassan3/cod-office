   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=null?$clr-namespace:COD_Market_Office.PageCOD_Market_Office.Page  %    COD_Market_Office.Page.ListJasa   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:COD_Market_Office.Page     $��8 0 8 0q�.���   � ColumnDefinitions  �� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto � � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $��* �.+��� -      btnBack#��[    btnback#��[ �� $��Kategori��$��1��$��0��$��0 0 0 8q��� -    ��Name$ btnAdd��$��2��$��0��$��Tambah��$��0 0 4 8q��� -   $ btnEdit��$��2��$��1��$
��Ubah��$��0 0 4 8q��� -   $ 	btnDelete��$��2��$��2��$��Hapus��$��0 0 4 8q�$y�Hidden=�&   System.Windows.Controls.DataGrid  -     Name$ dataKat��$��3��$��3��$	��350��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+  $
 Nama�� �� *nama+  $ Tampil�� �� *	isVisible+  $ Terdapat Gambar�� �� *isImageAvailable+  -   $ dataItem��$��3��$��3��$��3��$��8 0 0 0q�   $ Id�� �� *id+  $ 	Nama Jasa�� �� *nama+  $ Alamat�� �� *alamat+  $
 Telp�� �� *telp+  $ 	Deskripsi��   MaxWidth$	 250Q� �� *text+  $ 
Total View�� �� *	viewers+  $ Paket�� �� *packageList+  $ Blokir�� �� *	isBlocked+  $ Tampil�� �� *	isVisible+  $ Latitude�� �� *
latitude+  $ 	Longitude�� �� *	longitude+