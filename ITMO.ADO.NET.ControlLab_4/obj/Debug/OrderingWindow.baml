   M S B A M L   `   `   `  ����T  PITMO.ADO.NET.ControlLab_4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ITMO.ADO.NET.ControlLab_4ITMO.ADO.NET.ControlLab_4  5   	   .    (ITMO.ADO.NET.ControlLab_4.OrderingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ITMO.ADO.NET.ControlLab_4     5   	     � Title$  Ordering��5   	   $	��450��6   $	��450��6'   .��5	      � $��0q�6    � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       .+�5"   
   �� $��OrderID��6   $��Center=�6"   $��1q�6?   $��1��6J   $��Center=�6[   $��0��6v   �� 5#   
   $��
CustomerID��6   $��Center=�6%   $��1q�6B   $��1��6M   $��Center=�6^   $��1��6y   �� 5$   
   $��
EmployeeID��6   $��Center=�6%   $��1q�6B   $��1��6M   $��Center=�6^   $��2��6y   �� 5%   
   $��	OrderDate��6   $��Center=�6$   $��1q�6A   $��1��6L   $��Center=�6]   $��3��6x   �� 5&   
   $��RequiredDate��6   $��Center=�6'   $��1q�6D   $��1��6O   $��Center=�6`   $��4��6{   �� 5'   
   $��ShippedDate��6   $��Center=�6&   $��1q�6C   $��1��6N   $��Center=�6_   $��5��6z   �� 5(   
   $��ShipVia��6   $��Center=�6"   $��1q�6?   $��1��6J   $��Center=�6[   $��6��6v   �� 5)   
   $��Freight��6   $��Center=�6"   $��1q�6?   $��1��6J   $��Center=�6[   $��7��6v   �� 5*   
   $��ShipName��6   $��Center=�6#   $��1q�6@   $��1��6K   $��Center=�6\   $��8��6w   �� 5+   
   $��ShipAddress��6   $��Center=�6&   $��1q�6C   $��1��6N   $��Center=�6_   $��9��6z   �� 5,   
   $��ShipCity��6   $��Center=�6#   $��1q�6@   $��1��6K   $��Center=�6\   $��10��6w   �� 5-   
   $��
ShipRegion��6   $��Center=�6%   $��1q�6B   $��1��6M   $��Bottom=�6^   $��11��6y   �� 5.   
   $��ShipPostalCode��6   $��Center=�6)   $��1q�6F   $��1��6Q   $��Center=�6b   $��12��6}   �� 5/   
   $��ShipCountry��6   $��Center=�6&   $��	28,1,29,1q�6C   $��1��6V   $��Center=�6g   $��13��6�   �� 51   
   -   5         ��Name$ OrderID_tbx��51      $��1��6'   $��1��6;   $��23��6K   $��1 q�6W   $��1��6c   $��0��6t    �� TextWrapping$
 Wrap=�6�   �� 52   
   -   5        $ CustomerID_tbx��52      $��1��6*   $��1��6>   $��23��6N   $��1q�6Z   $��1��6e   $��1��6v   $
 Wrap=�6�   �� 53   
   -   5        $ EmployeeID_tbx��53      $��1��6*   $��1��6>   $��23��6N   $��1q�6Z   $��1��6e   $��2��6v   $
 Wrap=�6�   �� 54   
   -   5        $ ShipVia_tbx��54      $��1��6'   $��1��6;   $��23��6K   $��1q�6W   $��1��6b   $��6��6s   $
 Wrap=�6�   �� 55   
   -   5        $ Freight_tbx��55      $��1��6'   $��1��6;   $��23��6K   $��1q�6W   $��1��6b   $��7��6s   $
 Wrap=�6�   �� 56   
   -   5        $ ShipName_tbx��56      $��1��6(   $��1��6<   $��23��6L   $��1q�6X   $��1��6c   $��8��6t   $
 Wrap=�6�   �� 57   
   -   5        $ ShipAddress_tbx��57      $��1��6+   $��1��6?   $��23��6O   $��1q�6[   $��1��6f   $��9��6w   $
 Wrap=�6�   �� 58   
   -   5        $ ShipCity_tbx��58      $��1��6(   $��1��6<   $��23��6L   $��1q�6X   $��1��6c   $��10��6t   $
 Wrap=�6�   �� 59   
   -	   5        $ ShipRegion_tbx��59      $��1��6*   $��1��6>   $��23��6N   $��1q�6Z   $��1��6e   $��11��6v   $
 Wrap=�6�   �� 5:   
   -
   5        $ ShipPostalCode_tbx��5:      $��1��6.   $��1��6B   $��23��6R   $��1q�6^   $��1��6i   $��12��6z   $
 Wrap=�6�   �� 5;   
   -   5        $ ShipCountry_tbx��5;      $��1��6+   $��1��6?   $��23��6O   $��1q�6[   $��1��6f   $��13��6w   $
 Wrap=�6�   �� 5=   
   -   5         ��Name$ add_btn1��5=      $��	Add order��6#   $��1��67   $��1q�6G   $��28��6R   6`   �� 5>   
   -   5        $ cancel_btn1��5>      $��Cancel��6&   $��2��67   $��1q�6G   $��28��6R   6`   �� 5?   
   -   5        $��	Select...��5?      $��2��6%   $��1q�65   $��1��6@   $��1��6M   6^   �� 5@   
   $��Ship via...��6   $��2��6'   $��1q�67   $��6��6B   $��1��6O   �� 5A   
   $��	Select...��6   $��2��6%   $��1q�65   $��2��6@   $��1��6M   $��1��6^   (  "System.Windows.Controls.DatePicker  5B   
   -   5          Name$ order_dp��5B         IsDropDownOpen .     SelectedDateFormat$ Short=�6@   $��1��6[   $��1q�6k   $��3��6v   $��1��6�   	   Text$	 Select date��6�   $��1��6�   
 � 	Resources
 5C      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%[   '        �� 5D      "  6   .�5E      ��  � ��$ Select date��6-   5F      5G      5H        5I   
   -   5        $ req_dp��5I       .  $ Short=�6>   $��1��6Y   $��1q�6i   $��4��6t   $��1��6�   $	 Select date��6�   $��1��6�   
 5J      ��%[   '        �� 5K      "  6   .�5L      ��  � ��$ Select date��6-   5M      5N      5O        5P   
   -   5        $ 
shipped_dp��5P       .  $ Short=�6B   $��1��6]   $��1q�6m   $��5��6x   $��1��6�   $	 Select date��6�   $��1��6�   
 5Q      ��%[   '        �� 5R      "  6   .�5S      ��  � ��$ Select date��6-   5T      5U      5V      5W      5X      