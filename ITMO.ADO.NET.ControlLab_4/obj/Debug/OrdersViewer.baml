   M S B A M L   `   `   `  ����T  PITMO.ADO.NET.ControlLab_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ITMO.ADO.NET.ControlLab_4ITMO.ADO.NET.ControlLab_4  5   	   ,    &ITMO.ADO.NET.ControlLab_4.OrdersViewer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ITMO.ADO.NET.ControlLab_4     5   	   -   5          � Title$  Orders viewer��5   	   $��521.4��6   $��1003.2��6.    � 
ResizeMode$ NoResize=�6=   .��5	      � $��0q�6    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5$         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
IsReadOnly .    AutoGenerateColumns .  $��8��6{   $��0,0,0,0q�6�   $��11��6�   $��0��6�   ��65   ��    Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Header$	 OrderID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *	OrderID+  5'      $	 
CustomerID��6%   
 69   �� *
CustomerID+  5(      $	 
EmployeeID��6%   
 69   �� *
EmployeeID+  5)      $	 	OrderDate��6%   
 68   �� *	OrderDate+  5*      $	 RequiredDate��6%   
 6;   �� *RequiredDate+  5+      $	 ShipVia��6%   
 66   �� *	ShipVia+  5,      $	 Freight��6%   
 66   �� *	Freight+  5-      $	 ShipName��6%   
 67   �� *
ShipName+  5.      $	 
ShipAdress��6%   
 69   �� *
ShipAdress+  5/      $	 ShipCity��6%   
 67   �� *
ShipCity+  50      $	 
ShipRegion��6%   
 69   �� *
ShipRegion+52      �� 53   
   -   5         ��Name$ newOrder_btn��53      $��	New order��6'   $��1q�6;   $��8��6F   $��2��6W   $��1��6k   $��1��6y   6�   �� 54   
   -   5        $ 	about_btn��54      $��About��6$   $��8��64   $��1q�6D   $��2��6O   $��10��6c   �� 55   
   -   5        $ 
getOrd_btn��55      $��
Get orders��6%   $��2��6:   $��8��6O   $��1q�6_   6j   �� 56   
   -   5        $ 
delete_btn��56      $��Delete order��6%   $��1q�6<   $��8��6G   $��2��6X   $��2��6l   $��1��6z   6�   �� 57   
   -   5        $ 
update_btn��57      $��Update order��6%   $��1                 q�6<   $��8��58      $��2��6$   $��4��68   $��1��6F   5;      5<      