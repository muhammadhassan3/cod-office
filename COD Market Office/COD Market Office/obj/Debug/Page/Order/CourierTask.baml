   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullK*clr-namespace:COD_Market_Office.Page.OrderCOD_Market_Office.Page.Order  5   	   .    (COD_Market_Office.Page.Order.CourierTask   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:COD_Market_Office.Page.Order     5   	     � Title$  CourierTask��5   	   $	��450��6   $	��800��6*   .��5	      � $��8q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6   $��0 0 8 8q�6-   .��6>   
Nama Kurir6J   �� 5   
   -   5         ��Name$ 	cbCourier��5      $��0��6&   $��1��63   $��0 0 0 8q�6C   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblTask��5   D   $��1��6   $��0��6    $��2��60      Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Pilih��6)      CellTemplate 5      �� 5      .R�5      ��  d� 	IsChecked 6'   �� *
isSelected+	 �� UpdateSourceTrigger$	 PropertyChanged=�5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ Nomor Pesanan��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6<   �� *	noOrder+  5      $ Nama Pelanggan��6%   
 6=   �� *	user_name+  5       $ Alamat Pengiriman��6%   
 6@   �� *alamat+  5!      $ Metode Pembayaran��6%   
 6@   �� *metode_name+5#      �� 5$   
   -   5        $��Simpan��5$      $��0��6"   $��2��62   $��2��6?   $��0 8 0 0q�6S   6d   5%      5&      