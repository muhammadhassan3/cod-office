   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.JasaCOD_Market_Office.Page.Jasa  1    +COD_Market_Office.Page.Jasa.ListInvoiceJasa   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ;local)clr-namespace:COD_Market_Office.Page.Jasa     .��� $��8q�  � ColumnDefinitions  �� $��* ��� $��* � � RowDefinitions �� $
��auto ��� $��2* ��� $��3* �.+��� -    ��Name$ btnBack��   btnback#��[    btnBack#��[ $��0���� -    ��Name$ 	cbShowAll��$��Tampilkan Semua��$��0��$��2��$��Right=�$��Center=� d� IsThreeState .  &   System.Windows.Controls.DataGrid  -     Name$ tblData��$��1��$��0��$��3��$��0 8 0 8q� � ContextMenu �� .@�m� -   $��Approve���� m� -   $��Tolak��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *id+  $ Nama Pembeli��	 �� *
owner_name+  $ Nomor Pesanan��	 �� *nomor+  $ Pembelian Paket��	 �� *
paket_name+  $ 	Nama Jasa��	 �� *	jasa_name+  $ Nominal��	 �� *harga_format+  $ Tanggal Pesanan��	 �� *	createdAt+  $ Terdapat Foto��	 �� *isImageAvailable+  $ Tanggal Kadaluarsa��	 �� *	expired+  $ Status��	 �� *status+� $��2��$��0��$��0 0 8 0q�  �� $
��auto ��� $��* ��� $
��auto � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��Nomor Pesanan : ��$��8 8 0 0q�$��0��$��0���� $��Nama Pembeli : ��$��8 8 0 0q�$��0��$��1���� $��Pembelian Paket : ��$��8 8 0 0q�$��0��$��2���� $��Jasa : ��$��8 8 0 0q�$��0��$��3���� $��Nominal Pembelian : ��$��8 8 0 0q�$��0��$��4���� -   
 ��Name$
 tvNomor��$��8 8 0 0q�$��1��$��0��$��Right=��� -   $
 tvNama��$��8 8 0 0q�$��1��$��1��$��Right=��� -   $
 tvPaket��$��8 8 0 0q�$��1��$��2��$��Right=��� -	   $
 tvJasa��$��8 8 0 0q�$��1��$��3��$��Right=��� -
   $
 tvPrice��$��8 8 0 0q�$��1��$��4��$��Right=��� -    ��Name$ image��$��2��$��1��$��Uniform=�