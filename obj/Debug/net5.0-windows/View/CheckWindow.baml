   M S B A M L   `   `   `  ����J  FPreparingExmPrj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PreparingExmPrj.ViewPreparingExmPrj.View  5   	   &     PreparingExmPrj.View.CheckWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PreparingExmPrj.View     5   	     � Title$  CheckWindow��5   	   $	��600��6   $	��500��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.3* �6   �� 5      �� 5      $
��0.3* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��0.5* �6   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      �� 5      $
��0.2* �6   �� 5      $��0.15* �6   .+�5   
   �� $��1��6   $��1��6    �� ContentStringFormat$ Заказ №{0}��6W   $��26(�6x   $
��Bold"�6�   ��6-   �� *current_order.IdOrder+6�   .� 5   
   .��5      /� -   5         /�Name$ FD��5      .T�5      J� .*�6   .*�5      �� $��2��6   $��1��6+   $��Stretch=�6i   ��6;   �� *current_orderproducts+��5      �� 5      .R�5   "   �� 5       ��5"      �� 5#      .R�5$   "   �  5%   &   �� 5&   *   �� 5'   *   $
��0.5* �6;   �� 5(   *   $
��0.5* �6;   .+�5+   &   �� $��0��6,   $��16(�6i   ��6<   �� *IdProductNavigation.Name+6i   �� 5,   &   $��1��6,   $��16(�6k   $ - {0} шт.��6y   ��6<   �� *IdProductNavigation.Amount+6y   �� 5-   &   $��2��6,   $��16(�6j   $ --- {0} рублей��6x   $��Right=�6�   ��6<   �� *IdProductNavigation.Price+6�   5.   #   5/      51      52      53      54      �� 55   
   $��3��6   $��1��6   $	��Top=�6-   $$ Код получения: {0}��6E   $��26(�6n   $
��Bold"�6|   �� 56   
   $��4��6   $��1��6"   .+�57      �� $" Пункт выдачи: {0}��6P   $��18(�6x   ��6   �� *)'current_order.IdPointNavigation.Address+6x   �� 58      $$ Срок доставки: {0}��6U   $��18(�6~   ��6   �� *.,current_order.IdPointNavigation.DeliviryTime+6~   �� 59      $" Итого: {0} рублей��6A   $��18(�6i   ��6   �� *current_order.TotalPrice+6i   5:      �� 5;   
   -   5        $��1��5;      $��5��6!   $��16(�6.   $!��Печатать купон��6<   $	��200��6j   5<      5=      