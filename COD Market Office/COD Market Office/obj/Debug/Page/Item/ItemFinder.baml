   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  5   	   ,    &COD_Market_Office.Page.Item.ItemFinder   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:COD_Market_Office.Page.Item     5   	     � Title$  
ItemFinder��5   	   $	��450��6   $	��800��6)    � ShowInTaskbar .   � Topmost .  � 
ResizeMode$ NoResize=�6Z   .��5	      � $��8q�6    � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $
��Cari��6   $��0��6   $��0��6,   $��Center=�6<   �� 5   
   -   5         ��Name$ tbQuery��5      $��0��6#   $��1��60   $��4 8 4 8q�6@   .��6Q   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   -   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6-    �� 
TargetType" ��6    �� 	Resources 5         CueBannerBrush	 j� 
AlignmentX
 j� 
AlignmentY j� Stretch !� Visual��%�   &	        !� 5      $
	 Left=�6=   $
 Center=�6O   $
 None=�6c    5      �� 5   "   $��Barcode��6(   
�������6:   5      5       �� Triggers 5      P� 5        P� Property � �� �� Empty P� Value# Z 62   . �5!      ��  �� Property � �� �� Value# [  6;   5"      P� 5#       � �� 62   Z� . �5$      ��  � ��# [  6;   5%      P� 5&       �@J�IsKeyboardFocused . . �5'      ��  � ��
 �����6;   5(      5*      .��5+      5,      �� 5-   
   -   5          btnback#��[ 5-      $��2��62   $��0��6B   .��5.      �� $��/Assets/search.ico��6   5/      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ tblItem��50   D   $��1��6   $��3��6    $��0��64      Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *	item_id+  53      $ Nama Barang��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:    6D   �� *	item_nama+  54      $ Barcode��6%    66   �� *item_barcode+56      �� 57   
   -   5        $��2��57   (   $��0��65   $��3��6E   $��Center=�6Y   $��8 4 8 4q�6v   .��6�   Pilih6�   58      59      