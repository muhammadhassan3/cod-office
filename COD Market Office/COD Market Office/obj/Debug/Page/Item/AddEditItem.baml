   M S B A M L   `   `   `  ����L  HCOD Market Office, Version=1.0.1.2, Culture=neutral, PublicKeyToken=nullI)clr-namespace:COD_Market_Office.Page.ItemCOD_Market_Office.Page.Item  5   	   -    'COD_Market_Office.Page.Item.AddEditItem   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:COD_Market_Office.Page.Item     5   	     � Title$  AddEditItem��5   	   $
��auto��6   $	��400��6+    � SizeToContent$ Height=�67    � 
ResizeMode$ NoResize=�6N    � ShowInTaskbar .   � Topmost .  � WindowStartupLocation$ CenterScreen=�6�   .��5	      � $��8q�6    � ColumnDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ image��5      $��Uniform=�6   $��0��61   $��2��6A   $��Center=�6U   $	��150��6r   �� 5   
   -   5        	 ��Name$	 	btnSelect��5      $��
Pilih File��6$   $
��Left=�69   $��0��6m   $��1��6}   �� 5   
   -   5        
 ��Name$
 lblSize��5   W   $
��Size��6   $
��Left=�6   $��1��6:   $��1��6G   $��Center=�6h   �� 5   
   $��Kategori��6   $��2��6#   $��0��60   �� 5   
   -   5        $
 lblKat��5   @   $��Kategori��6   $��2��6#   $��1��60   6@   �� 5   
   $��Merek��6   $��3��6    $��0��6-   �� 5   
   -   5        $
 lblMerek��5   =   $��Merek��6   $��3��6    $��1��6-   6=   �� 5    
   $
��Nama��6   $��4��6   $��0��6,   �� 5!   
   -   5         ��Name$ tbName��5!      $��4��6"   $��1��6/   $��0 2 0 0q�6?   �� 5"   
   $��Barcode��6   $��5��6"   $��0��6/   �� 5#   
   -   5        $ 	tbBarcode��5#      $��5��6%   $��1��62   $��0 2 0 0q�6B   �� 5$   
   $��Ppn(%)��6   $��6��6!   $��0��6.   �� 5%   
   -   5        $ tbPPN��5%      $��6��6!   $��1��6.   $��0 2 0 0q�6>   �� 5&   
   -	   5         ��Name$ 	cbVisible��5&   $   $��Tampil��6   $��7��67   $��0��6D   $��2��6T   $��0 4 0 4q�6h   $��Center=�6y   �� 5'   
   -
   5        $	 btnSave��5'      $��Simpan��69   $��8��6J   $��0��6W   $��2��6g   5(      5)      