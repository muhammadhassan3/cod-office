   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  -    'COD_Market_Office.Page.Item.AddEditItem   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:COD_Market_Office.Page.Item       � Title$  AddEditItem��$
��auto��$	��400�� � SizeToContent$ Height=� � 
ResizeMode$ NoResize=� � ShowInTaskbar .   � Topmost .  � WindowStartupLocation$ CenterScreen=�.��� $��8q� � ColumnDefinitions �� $
��auto ��� $��* � � RowDefinitions �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� -    ��Name$ image��$��Uniform=�$��0��$��2��$��Center=�$	��150���� -   	 ��Name$	 	btnSelect��$��
Pilih File��$
��Left=�$��0��$��1���� -   
 ��Name$
 lblSize��$
��Size��$
��Left=�$��1��$��1��$��Center=��� $��Kategori��$��2��$��0���� -   $
 lblKat��$��Kategori��$��2��$��1���� $��Merek��$��3��$��0���� -   $
 lblMerek��$��Merek��$��3��$��1���� $
��Nama��$��4��$��0���� -    ��Name$ tbName��$��4��$��1��$��0 2 0 0q��� $��Barcode��$��5��$��0���� -   $ 	tbBarcode��$��5��$��1��$��0 2 0 0q��� $��Ppn(%)��$��6��$��0���� -   $ tbPPN��$��6��$��1��$��0 2 0 0q��� -	    ��Name$ 	cbVisible��$��Tampil��$��7��$��0��$��2��$��0 4 0 4q�$��Center=��� -
   $	 btnSave��$��Simpan��$��8��$��0��$��2��