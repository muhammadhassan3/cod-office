   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.JasaCOD_Market_Office.Page.Jasa  5      1    +COD_Market_Office.Page.Jasa.ListInvoiceJasa   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:COD_Market_Office.Page.Jasa     5      .��5	      � $��8q�6     � ColumnDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��2* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ btnBack��5         btnback#��[  6"     btnBack#��[ 6C   $��0��6f   6s   �� 5   
   -   5         ��Name$ 	cbShowAll��5   �   $��Tampilkan Semua��6   $��0��6-   $��2��6:   $��Right=�6J   $��Center=�6f    d� IsThreeState .  6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblData��5   D   $��1��6   $��0��6    $��3��60   $��0 8 0 8q�6U    � ContextMenu 5      �� 5      .@�5      m� -   5        $��Approve��5      60   �� 5      m� 5      -   5        $��Tolak��5      6.   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� *id+  5      $ Nama Pembeli��6%   	 6;   �� *
owner_name+  5       $ Nomor Pesanan��6%   	 6<   �� *nomor+  5!      $ Pembelian Paket��6%   	 6>   �� *
paket_name+  5"      $ 	Nama Jasa��6%   	 68   �� *	jasa_name+  5#      $ Nominal��6%   	 66   �� *harga_format+  5$      $ Tanggal Pesanan��6%   	 6>   �� *	createdAt+  5%      $ Terdapat Foto��6%   	 6<   �� *isImageAvailable+  5&      $ Tanggal Kadaluarsa��6%   	 6A   �� *	expired+  5'      $ Status��6%   	 65   �� *status+5)      � 5*   
   $��2��6   $��0��6   $��0 0 8 0q�6,     5+      �� 5,      $
��auto �6#   �� 5-      $��* �6#   �� 5.      $
��auto �6#    50      �� 51      $
��auto �6    �� 52      $
��auto �6    �� 53      $
��auto �6    �� 54      $
��auto �6    �� 55      $
��auto �6    �� 56      $
��auto �6    �� 57      $
��auto �6    .+�59      �� $��Nomor Pesanan : ��6   $��8 8 0 0q�60   $��0��6A   $��0��6Q   �� 5:      $��Nama Pembeli : ��6   $��8 8 0 0q�6/   $��0��6@   $��1��6P   �� 5;      $��Pembelian Paket : ��6   $��8 8 0 0q�62   $��0��6C   $��2��6S   �� 5<      $��Jasa : ��6   $��8 8 0 0q�6'   $��0��68   $��3��6H   �� 5=      $��Nominal Pembelian : ��6   $��8 8 0 0q�64   $��0��6E   $��4��6U   �� 5>      -   5        
 ��Name$
 tvNomor��5>   b   $��8 8 0 0q�6   $��1��6)   $��0��69   $��Right=�6F   6b   �� 5?      -   5        $
 tvNama��5?   b   $��8 8 0 0q�6   $��1��6)   $��1��69   $��Right=�6F   6b   �� 5@      -   5        $
 tvPaket��5@   b   $��8 8 0 0q�6   $��1��6)   $��2��69   $��Right=�6F   6b   �� 5A      -	   5        $
 tvJasa��5A   b   $��8 8 0 0q�6   $��1��6)   $��3��69   $��Right=�6F   6b   �� 5B      -
   5        $
 tvPrice��5B   b   $��8 8 0 0q�6   $��1��6)   $��4��69   $��Right=�6F   6b   5D      �� 5E   
   -   5         ��Name$ image��5E      $��2��6   $��1��6,   $��Uniform=�6<   5F      5G      