   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  5      +    %COD_Market_Office.Page.Item.MerekList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:COD_Market_Office.Page.Item     5      $��8q�5   7   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnBack��5      $��0��6"   $��0��62      btnback#��[  6?     btnBack#��[ 6`   6�   �� 5   
   $��Manajemen Merek��6   $��0��6*   $��1��67   $��3��6G   $��Center=�6[   $��Center=�6x   �� 5   
   -   5        $ btnAdd��5      $��Tambah��6!   $��1��62   $��0��6?   $
��Left=�6P   6k   �� 5   
   $��Semua merek��6   $��Center=�6&   $��Center=�6C   $��1��6^   $��1��6n   �� 5   
   -   5         ��Name$ lblKategori��5   �   $!��Merek Terdaftar di Kategori��6   $��Center=�66   $��3��6S   $��1��6c   $��Center=�6p   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblAllMerek��5       $��2��6   $��0��65   $��2��6E   $��0 4 4 0q�6Y    � ContextMenu 5      �� 5      .@�5      m� -   5        $
��Ubah��5      6-   5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5"      $
 Nama��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6L    63   �� *nama+6L     5#      $ Tampil��6%    65   �� *	isVisible+5%        5&   
   -   5        $ tblMerek��5&       $��2��6   $��3��62   $��0 4 0 0q�6B    5'        5(      $ Id��6%    61   �� *id+  5)      $
 Nama��6%   $	 * 6L    63   �� *nama+6L     5*      $ Tampil��6%    65   �� *	isVisible+5,      �� 5-   
   -   5        $ btnRegister��5-      $��	Daftar >>��6&   $��2��6:   $��1��6J   $��2��6W   $��Center=�6h   $��0 4 4 0q�6�   6�   5.      5/      