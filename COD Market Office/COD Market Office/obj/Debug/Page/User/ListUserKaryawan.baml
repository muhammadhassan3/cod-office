   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.UserCOD_Market_Office.Page.User  5      2    ,COD_Market_Office.Page.User.ListUserKaryawan   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:COD_Market_Office.Page.User     5      .��5	      � $��8q�6     � ColumnDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��4* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��0��5      $��0��6!      btnback#��[  6.     btnBack#��[ 6O   6r   �� 5   
   $��1��6   $��0��6    $
��Cari��6-   $��4 0 4 0q�6<   $��Center=�6M   �� 5   
   -   5         ��Name$ tbSearch��5      $��0��6$   $��2��61   $��8q�6A   $��4��6L   �� 5   
   -   5        #��[  5      $��0��62   $��6��6?   .��5      �� $��/Assets/search.ico��6   5      �� 5   
   $��Outlet��6   $��1��6!   $��0��6.   $��Center=�6>   $��4 0 4 0q�6Y   �� 5   
   -   5         ��Name$ cbOutlet��5       �� SelectedIndex$ 0��6%   $��1��67   $��1��6D   $��0 8 0 8q�6T   $��2��6e   6y   �� 5    
   $��Grant��6   $��1��6    $��4��6-   $��Center=�6=   $��4 0 4 0q�6X   �� 5!   
   -   5        $ cbFilter��5!      $ 0��6%   $��1��67   $��5��6D   $��0 8 0 8q�6T   $��2��6e   .@�5"      �� $��Semua��6   5#      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ tblUser��5$   D   $��2��6   $��0��6    $��7��60      Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%     5'      $
 Nama��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 63     5(      $ Nomor Telepon��6%     5)      $ Grant��6%     5*      $ Status��6%     5+      $ Tanggal Terdaftar��6%   	 � ContextMenu	 5.      �� 5/      .@�50      m� -   5        $��Tambah��50      6/   m� 51      -   5        $
��Ubah��51      6-   52      54      55      56      