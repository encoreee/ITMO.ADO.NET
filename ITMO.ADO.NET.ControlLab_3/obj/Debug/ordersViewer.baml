   M S B A M L   `   `   `  ����T  PITMO.ADO.NET.ControlLab_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ITMO.ADO.NET.ControlLab_3ITMO.ADO.NET.ControlLab_3  5   	   +    %ITMO.ADO.NET.ControlLab_3.salesViewer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ITMO.ADO.NET.ControlLab_3     5   	     � Title$  Sales viewer��5   	   $��521.4��6   $��1003.2��6-    � 
ResizeMode$ NoResize=�6<   .��5	      � -   5         �Name$ SalesViewer��5	      $��0q�6<    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5$         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      AutoGenerateColumns .  $��8��6j   $��0,0,0,0q�6~   $��11��6�   $��0��6�   ��65   ��    Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Header$	 SalesOrderID��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *SalesOrderID+  5'      $	 RevisionNumber��6%   
 6=   �� *RevisionNumber+  5(      $	 	OrderDate��6%   
 68   �� *	OrderDate+  5)      $	 Status��6%   
 65   �� *Status+  5*      $	 OnlineOrderFlag��6%   
 6>   �� *OnlineOrderFlag+  5+      $	 PurchaseOrderNumber��6%   
 6B   �� *PurchaseOrderNumber+  5,      $	 AccountNumber��6%   
 6<   �� *AccountNumber+5.      �� 5/   
   -   5         ��Name$ newOrder_btn��5/      $��	New order��6'   $��1q�6;   $��8��6F   $��2��6W   $��1��6k   $��1��6y   6�   �� 50   
   -   5        $ 	About_btn��50      $��About��6$   $��8��64   $��1q�6D   $��2��6O   $��10��6c   �� 51   
   -   5        $ Refresh_btn��51      $��Refresh data��6&   $��2��6=   $��8��6R   $��1q�6b   6m   54      55      