   M S B A M L   `   `   `  ���� L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  ,    &COD_Market_Office.Page.Item.ItemFinder   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:COD_Market_Office.Page.Item       � Title$  
ItemFinder��$	��450��$	��800�� � ShowInTaskbar .   � Topmost .  � 
ResizeMode$ NoResize=�.��� $��8q� � ColumnDefinitions �� $
��auto ��� $��* ��� $
��auto � � RowDefinitions �� $
��auto ��� $��* ��� $
��auto �.+��� $
��Cari��$��0��$��0��$��Center=��� -    ��Name$ tbQuery��$��0��$��1��$��4 8 4 8q�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" �� �� 	Resources    CueBannerBrush	 j� 
AlignmentX
 j� 
AlignmentY j� Stretch !� Visual��%T   &	        !� $
	 Left=�$
 Center=�$
 None=� �� $��Barcode��
������� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  �� Property � �� �� Value# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -     btnback#��[ $��2��$��0��.���� $��/Assets/search.ico��&   System.Windows.Controls.DataGrid  -     Name$ tblItem��$��1��$��3��$��0��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	item_id+  $ Nama Barang��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *  �� *	item_nama+  $ Barcode�� �� *item_barcode+�� -   $��2��$��0��$��3��$��Center=�$��8 4 8 4q�.��Pilih