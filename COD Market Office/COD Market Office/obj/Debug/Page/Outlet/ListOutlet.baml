   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullM+clr-namespace:COD_Market_Office.Page.OutletCOD_Market_Office.Page.Outlet  5      .    (COD_Market_Office.Page.Outlet.ListOutlet   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:COD_Market_Office.Page.Outlet     5      $��8 0 8 0q�5   7   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5           btnback#��[  5   '     btnBack#��[ 6H   �� 5   
   $��Cari :��6   $��1��6!   $��0��6.   �� 5   
   -   5         ��Name$ tbSearch��5      $��1��6$   $��1��61   $��8 0 8 0q�6A   �� 5   
   -   5        $��1��5      $��2��6   $
��Cari��6.   6=   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	tblOutlet��5   D   $��2��6   $��0��6    $��3��60   $��0 8 0 0q�6W    � ContextMenu 5      �� 5      .@�5      m� -   5        $��	Tambahkan��5      62   m� 5      -   5        $
��Ubah��5      6-   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5!      $ Nama Outlet��6%    6:   �� *nama+  5"      $ Alamat Outlet��6%    6<   �� *alamat+  5#      $ 	Kabupaten��6%    68   �� *
kab_name+  5$      $ Provinsi��6%    67   �� *	prov_name+  5%      $ Alamat Email��6%    6;   �� *email+  5&      $ Nomor Telepon��6%    6<   �� *telp+  5'      $ Koordinat Latitude��6%    6A   �� *
latitude+  5(      $ Koordinat Longitude��6%    6B   �� *	longitude+  5)      $ Membuka Toko��6%    6;   �� *isShop+  5*      $ Tampil��6%    65   �� *	isVisible+5,      5-      5.      