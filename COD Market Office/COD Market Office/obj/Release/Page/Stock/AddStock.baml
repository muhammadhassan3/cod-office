   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullK*clr-namespace:COD_Market_Office.Page.StockCOD_Market_Office.Page.Stock  +    %COD_Market_Office.Page.Stock.AddStock   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     <local*clr-namespace:COD_Market_Office.Page.Stock       � Title$  AddStock��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�.��� $��8q� � ColumnDefinitions �� $��* ��� $��* � � RowDefinitions �� $
��auto ��� $��* ��� $��* �.+��� -      btnback#��[  $��0��$��1��$��Right=�.���� $��/Assets/search.ico���� -    ��Name$ imgItem��$��0��$��0��$��Uniform=�$��8q�$��2��� $��4 0 0 0q�$��1��$��1�� �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��.��
Kategori :�� $��0��$��1��.��
Kategori�� $��1��$��0��.��	Merek :�� $��1��$��1��.��Merek�� $��2��$��0��.��Item :�� $��2��$��1��.��Item� $��2��$��1�� �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $��* �.+��� -    ��Name$ cbGrosir��$��0��$��0��$��4 8 4 8q�$��Grosir���� $��1��$��0��$��0 8 0 8q�.��Minimal Grosir�� -    ��Name$ tbMinGrosir��$��1��$��1��$��4 8 4 8q��� $��2��$��0��$��0 8 0 8q�.��Keuntungan Grosir (Rp)�� -   $ tbKeuntunganGrosir��$��2��$��1��$��4 8 4 8q��� -   $��
Verifikasi��$��3��$��0��$��2��$��Center=�� $��2��$��0�� �� $
��auto ��� $��* � �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $��0��$��0��$��0 8 0 8q�.��Jumlah Stok (Rp)�� -   $ tbStok��$��0��$��1��$��4 8 4 8q��� $��1��$��0��$��0 8 0 8q�.��Harga Beli (Rp)�� -   $ tbHarga��$��1��$��1��$��4 8 4 8q��� $��2��$��0��$��0 8 0 8q�.��Keuntungan (Rp)�� -	   $ tbKeuntungan��$��2��$��1��$��4 8 4 8q��� $��3��$��0��$��0 8 0 8q�.��Diskon (Rp)�� -
   $ tbDiskon��$��3��$��1��$��4 8 4 8q�