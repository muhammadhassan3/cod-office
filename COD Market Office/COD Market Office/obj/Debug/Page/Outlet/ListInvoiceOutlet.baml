   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullM+clr-namespace:COD_Market_Office.Page.OutletCOD_Market_Office.Page.Outlet  5      5    /COD_Market_Office.Page.Outlet.ListInvoiceOutlet   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:COD_Market_Office.Page.Outlet     5      $��8 0 8 0q�5   7   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� -   5           btnBack#��[  5      $��0��64   $��0��6A     btnback#��[ 6Q   6r   �� 5   
   $��Cari : ��6   $��1��6"   $��0��6/   �� 5   
   -   5         ��Name$ tbSearch��5   1   $��1��6   $��1��6!   61   �� 5   
   $
��Cari��6   $��1��6    $��2��6-   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
tblInvoice��5      $��2��6'   $��0��64   $��3��6D   $��0 8 0 8q�6X    � ContextMenu 5      �� 5      .@�5      m� $��Setujui��6   �� 5      m� 5      $��Tolak��6   5         Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5#      $ Nama Tagihan��6%    6;   �� *name+  5$      $ Outlet��6%    65   �� *outlet_name+  5%      $ Nominal��6%    66   �� *value_format+  5&      $ Tenggat Waktu Pembayaran��6%    6G   �� *	expiredAt+  5'      $ Tanggal Dibuat��6%    6=   �� *	createdAt+  5(      $ 
Keterangan��6%    69   �� *ket+5*      � 5+   
   $��3��6   $��0��6   $��0 0 8 0q�6,   $��3��6=     5,      �� 5-      $
��auto �6#   �� 5.      $��* �6#   �� 5/      $��3* �6#    51      �� 52      $
��auto �6    �� 53      $
��auto �6    �� 54      $
��auto �6    �� 55      $
��auto �6    �� 56      $��* �6    .+�58      �� $��Nama Tagihan : ��6   $��8 8 0 0q�6/   $��0��6@   $��0��6P   �� 59      $��Outlet Tertagih : ��6   $��8 8 0 0q�62   $��0��6C   $��1��6S   �� 5:      $��Keterangan : ��6   $��8 8 0 0q�6-   $��0��6>   $��2��6N   �� 5;      $��Tenggat Waktu : ��6   $��8 8 0 0q�60   $��0��6A   $��3��6Q   �� 5<      $��Nominal Pembayaran : ��6   $��8 8 0 0q�65   $��0��6F   $��4��6V   $	��Top=�6c   �� 5=      -   5        $ tvName��5=   b   $��8 8 0 0q�6   $��1��6)   $��0��69   $��Right=�6F   6b   �� 5>      -   5        $ tvOutlet��5>   b   $��8 8 0 0q�6   $��1��6)   $��1��69   $��Right=�6F   6b   �� 5?      -   5        $ tvInfo��5?   b   $��8 8 0 0q�6   $��1��6)   $��2��69   $��Right=�6F   6b   �� 5@      -   5        $ tvDate��5@   b   $��8 8 0 0q�6   $��1��6)   $��3��69   $��Right=�6F   6b   �� 5A      -   5        $ tvPrice��5A   b   $��8 8 0 0q�6   $��1��6)   $��4��69   $��Right=�6F   $	��Top=�6s   �� 5B      -	   5         ��Name$ image��5B      $��0��6#   $��2��60   $��Uniform=�6@   $��5��6R   5C      5D      5E      