   M S B A M L   `   `   `  ����T  PITMO.ADO.NET.ControlLab_2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ITMO.ADO.NET.ControlLab_2ITMO.ADO.NET.ControlLab_2  5   	   +    %ITMO.ADO.NET.ControlLab_2.salesViewer   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ITMO.ADO.NET.ControlLab_2     5   	     � Title$  Sales viewer��5   	   $��521.4��6   $��1003.2��6-    � 
ResizeMode$ NoResize=�6<   .��5	      � -   5         �Name$ SalesViewer��5	      $��0q�6<    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5$         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      AutoGenerateColumns .  $��8��6j   $��0,0,0,0q�6~   $��11��6�   $��1��6�   ��65   ��    Columns 5%      0  *System.Windows.Controls.DataGridTextColumn  5&      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
CustomerID��6&   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6:   �� *
CustomerID+ �� NotifyOnTargetUpdated .  �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5'      $	 	FirstName��6%   
 68   �� *	FirstName+ . $ TwoWay=�$ PropertyChanged=�  5(      $	 LastName��6%   
 67   �� *
LastName+ . $ TwoWay=�$ PropertyChanged=�  5)      $	 StoreID��6%   
 66   �� *	StoreID+ . $ TwoWay=�$ PropertyChanged=�  5*      $	 TerritoryID��6%   
 6:   �� *TerritoryID+ . $ TwoWay=�$ PropertyChanged=�  5+      $	 AccountNumber��6%   
 6<   �� *AccountNumber+ . $ TwoWay=�$ PropertyChanged=�5-      �� 5.   
   -   5         ��Name$ SaveData_btn��5.      $��	Save data��6'   $��1,1,1,1q�6;   $��8��6L   $��2��6]   $��1��6q   {�.  6�   �� 5/   
   -   5        $ 	About_btn��5/      $��About��6$   $��8��64   $��1q�6D   $��2��6O   $��10��6c   o� 50   
   $
��Left=�6   $��45��6*   $��1��66   $��0��6G   $	��Top=�6T   $	��996��6l   $��10��6x   .@�51      m� $
��Mode��6   $��2��6&   $��0��6:   $��45��6J   $��80��6V   $��Center=�6a   $��Center=�6~   .@�52      m� -   5         m�Name$ Client_item��52      $��Client��60    m� IsCheckable .  m� 	IsChecked . 6d   m� 53      -   5        $ Employer_item��53      $��Employer��62    . 6W   55      56      59      5:      