   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.UserCOD_Market_Office.Page.User  -    'COD_Market_Office.Page.User.AddEditUser   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:COD_Market_Office.Page.User       � Title$  AddEditUser��$
��auto��$��500         �� � ShowInTaskbar .   � Topmost .  � WindowStartupLocation$ CenterScreen=� � SizeToContent$ Height=�.��� $��8q� � ColumnDefinitions �� $
��auto ��� $��* ��� $
��auto ��� $��* � � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $
��Nama��$��0��$��0��$��0 4 8 4q��� -    ��Name$ tbNama��$��0��$��1��$��0 4 0 4q�$��4���� $��Nomor Telepon��$��1��$��0��$��0 4 8 4q��� -   $ tbTelp��$��1��$��1��$��0 4 0 4q�$��4���� $��Alamat��$��2��$��0��$��0 4 8 4q��� -   $ tbAlamat��$��2��$��1��$��0 4 0 4q�$��4���� $��RT��$��3��$��0��$��0 4 8 4q��� -   $
 tbRt��$��3��$��1��$��0 4 0 4q��� $��RW��$��3��$��2��$��0 4 8 4q��� -   $
 tbRw��$��3��$��3��$��0 4 0 4q��� $��Kelurahan/Desa��$��4��$��0��$��0 4 8 4q��� -   $ tbKelurahan��$��4��$��1��$��0 4 0 4q��� $��	Kecamatan��$��4��$��2��$��0 4 8 4q��� -   $ tbKec��$��4��$��3��$��0 4 0 4q��� $��Provinsi��$��5��$��0��$��0 4 8 4q��� -    ��Name$ cbProv��$��5��$��1��$��0 4 0 4q�	 �� SelectedIndex$	 0��$��4��.@��� $��Pilih Provinsi���� $��	Kabupaten��$��6��$��0��$��0 4 8 4q��� -	   $ cbKab��$��6��$��1��$��0 4 0 4q�$	 0��$��4��.@��� $��Pilih Kabupaten���� -
   
 ��Name$
 	cbBlocked��$��Blokir��$��7��$��0��$��4��$��Center=�$��4q��� -   $��Simpan��$��8��$��0��$��4��