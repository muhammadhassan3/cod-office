   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  5      *    $COD_Market_Office.Page.Item.ItemList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:COD_Market_Office.Page.Item     5      $��8q�5   7   .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ btnBack��5         btnBack#��[  6"     btnback#��[ 6E   6f   �� 5   
   $��Daftar Barang��6   $��0��6(   $��1��65   $��3��6E   $��Center=�6Y   $��Center=�6v   �� 5   
   $��Kategori��6   $��1��6#   $��0��60   $��2��6@   $��Center=�6T   �� 5   
   $��Merek��6   $��1��6    $��2��6-   $��Center=�6=   �� 5   
   $
��Item��6   $��1��6   $��3��6,   $��Center=�6<   �� 5   
   -   5        $ 	btnAddKat��5      $��Tambah��6$   $��0��65   $��2��6E   $��2��6k   $
��Left=�6   �� 5   
   -   5        $ btnShowMerek��5      $��Tambah��6'   $��2��68   $��2��6H   $
��Left=�6n   �� 5   
   -   5        $ 
btnAddItem��5      $��Tambah��6%   $��3��66   $��2��6F   $
��Left=�6m   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblKat��5      $��3��6#   $��0��60   $��2��6@   $��0 4 4 0q�6T    � ContextMenu 5      �� 5       .@�5!      m� -   5        $
��Ubah��5!      6-   5"         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5&      $
 Nama��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63    6=   �� *nama+  5'      $ Tampil��6%    65   �� *	isVisible+5)        5*   
   -   5        $ tblMerek��5*       $��3��6   $��2��62   $��0 4 4 0q�6B    5+        5,      $ Id��6%    61   �� *id+  5-      $
 Nama��6%   $ * 63    6=   �� *nama+  5.      $ Tampil��6%    65   �� *	isVisible+50        51   
   -   5        $ tblItem��51   0   $��3��6   $��3��6    $��0 4 0 0q�6A    52      �� 53      .@�54      m� -	   5        $
��Ubah��54      6-   55       57        58      $ Id��6%    61   �� *id+  59      $ Nama Barang��6%   $ * 6:    6D   �� *nama+  5:      $ Barcode��6%    66   �� *	barcode+  5;      $ Tampil��6%    65   �� *	isVisible+  5<      $ PPN(%)��6%    65   �� *ppn+5>      5?      5@      