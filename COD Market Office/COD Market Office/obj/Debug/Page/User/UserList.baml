   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.UserCOD_Market_Office.Page.User  5      *    $COD_Market_Office.Page.User.UserList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:COD_Market_Office.Page.User     5      .��5	      � $��8q�6     � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5           btnback#��[  5        btnBack#��[ 62   $��0��6l   $��0��6|   �� 5   
   $��0��6   $��1��6   $��Center=�6-   $��Center=�6J   $��4 0 4 0q�6e   .��6v   Cari6|   �� 5   
   -   5         ��Name$ tbSearch��5      $��2��6$   $��0��64   $��Center=�6A   $��4q�6\   �� 5   
   -   5        $��3��5      $��0��6!   #��[  6.   .��5      �� $��/Assets/search.ico��6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ tblUser��5   D   $��1��6   $��0��6    $��4��60    � ContextMenu 5      �� 5      .@�5      m� -   5        $
��Ubah��5      6-   5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5"      $
 Nama��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63    6=   �� *nama+  5#      $ Nomor Telepon��6%    6<   �� *telp+  5$      $ Alamat��6%   $ * 65    6?   �� *alamat+  5%      $ Diblokir��6%    67   �� *	isBlocked+5'      5(      5)      