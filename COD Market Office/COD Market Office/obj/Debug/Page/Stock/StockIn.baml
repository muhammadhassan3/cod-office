   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullK*clr-namespace:COD_Market_Office.Page.StockCOD_Market_Office.Page.Stock  5      *    $COD_Market_Office.Page.Stock.StockIn   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:COD_Market_Office.Page.Stock     5      .��5	      � $��8q�6     � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5           btnback#��[  5        btnBack#��[ 62   $��0��6U   $��0��6b   6r   �� 5   
   $��Outlet��6   $��Center=�6!   $��0��6<   $��1��6I   �� 5   
   -   5         ��Name$ cbOutlet��5   x   $��0��6   $��2��6    $��2��60   $��4 8 4 8q�6D   6x   �� 5   
   -   5        $��0��5      $��4��6   #��[  6.   $��Right=�6i   .��5      �� $��/Assets/plus.ico��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblKat��5      $��1��6H   $��0��6U   $��3��6e   $��0 4 4 0q�6y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%     5      $
 Nama��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63   5         5!   
   -   5        $ tblMerek��5!      $��1��6L   $��3��6Y   $��0 4 4 0q�6j    5"        5#      $ Id��6%     5$      $
 Nama��6%   $ * 63   5&        5'   
   -   5        $ tblItem��5'      $��1��6J   $��4��6W   $��0 4 0 0q�6g    � ContextMenu 5(      �� 5)      .@�5*      m� -   5        $
��Ubah��5*      6-   5+       5-        5.      $ Id��6%     5/      $
 Nama��6%     50      $ 
Harga Beli��6%     51      $ Diskon��6%     52      $ Grosir��6%     53      $ Minimal Grosir��6%     54      $ Potongan Harga Grosir��6%     55      $
 Stok��6%     56      $ 
Harga Jual��6%   58      59      5:      