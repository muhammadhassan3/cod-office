   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullK*clr-namespace:COD_Market_Office.Page.OrderCOD_Market_Office.Page.Order  .    (COD_Market_Office.Page.Order.CourierTask   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:COD_Market_Office.Page.Order       � Title$  CourierTask��$	��450��$	��800��.��� $��8q� � RowDefinitions �� $
��auto ��� $��* ��� $
��auto � � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��0��$��0��$��0 0 8 8q�.��
Nama Kurir�� -    ��Name$ 	cbCourier��$��0��$��1��$��0 0 0 8q�&   System.Windows.Controls.DataGrid  -     Name$ tblTask��$��1��$��0��$��2��   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Pilih��   CellTemplate �� .R���  d� 	IsChecked �� *
isSelected+	 �� UpdateSourceTrigger$	 PropertyChanged=�0  *System.Windows.Controls.DataGridTextColumn  $ Nomor Pesanan��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *	noOrder+  $ Nama Pelanggan��
 �� *	user_name+  $ Alamat Pengiriman��
 �� *alamat+  $ Metode Pembayaran��
 �� *metode_name+�� -   $��Simpan��$��0��$��2��$��2��$��0 8 0 0q�