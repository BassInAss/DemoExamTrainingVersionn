   M S B A M L   `   `   `  ����J  FPreparingExmPrj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PreparingExmPrj.ViewPreparingExmPrj.View  5   	   G(clr-namespace:PreparingExmPrj.ConvertersPreparingExmPrj.Converters  5   	   %    PreparingExmPrj.View.CartWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:PreparingExmPrj.View     5   	   ?
converters(clr-namespace:PreparingExmPrj.Converters     5   	     � Title$  
CartWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
      1  +PreparingExmPrj.Converters.ImgPathConverter   ImgPathConv �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%C  &	        '��      '�� �       5   
   6<   �� 5   
   " ��6   .�5      ��  �@�Cursor$
 Hand��6'   �� 5       � ��$ 18(�6)   5      �� 5   
   " ��6    5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  �@��
IsSelected$
 True��63   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.1* �6   	 � RowDefinitions	 5   
   �� 5      $
��0.1* �6   �� 5       �� 5!      $��0.05* �6   .+�5#   
   � $��1��6   $��1��6   	 5$      �� 5%      �� 5&      $
��0.2* �6    .+�5(      � $��0��6   	 5)      �� 5*      �� 5+      $
��0.4* �6$   .+�5-      �� -   5        
 ��Name$
 cart_listbox��5-   '   $��0��6   $��Stretch=�6=    %� 
ScrollUnit$ Pixel=�6b   ��5.      �� 5/      .R�50      � $��0��6#    51   "   �� 52   &   �� 53   &   $
��0.5* �67   �� 54   &   $
��0.5* �67   .+�56   "   �� $��0��6)   
���   �$��1q�6M    �� Padding$ 15q�6a   ._�57   &   � 
���   � 58   *   �� 59   .   $
��0.5* �6?   �� 5:   .   .+�5<   *   �� $��0��60    �� BitmapScalingMode$ HighQuality=�6@   $��50��6�   $��50��6�   $��15q�6�   ��6n   �� *Image+ �� 	Converter# [  6�   �� 5=   *   $��1��60   
�������$��18(�6l   $��Center=�6z   $��Center=�6�   ��6S   �� *Name+6�   5>   '   5?   #   �� 5@   "   $��1��6-    �� Orientation$ 
Horizontal=�6=   $��Center=�6V   .+�5A   &   �� $��42(�6G   $��Center=�6U   $��0 0 10 0q�6p   ��6,   �� *Amount+6p   �� 5B   &    ��Name$ incAmount_button��6o   -   5        $��+��5B   ,   $��42(�68   $��Center=�6F    � Cursor$
 Hand��6a   6�   �� 5C   &   $ decAmount_button��6o   -   5        $��-��5C   ,   $��42(�68   $��Center=�6F   $
 Hand��6a   6�   5D   #   �� 5E   "    ��Name$ deleteProduct_button��69   -   5        $��2��5E   )   $��Удалить��6z   $��40��6�   $��0 0 5 0q�6�   5F      5G      5I      � 5J      $��1��6    5K      �� 5L      �� 5M      $
��0.8* �6+   .+�5O      �� $��0��6!   $ 
Horizontal=�61   .+�5P      �� $��Пункт выдачи:��6    $��18(�68   $��Center=�6F   $��0 0 20 0q�6a   �� 5Q      -   5         ��Name$ points_combobox��5Q   3   $��0��6#   $	��200��6L   $	��300��6[   $��40��6k   $��Center=�6w   $��Center=�6�    �� SelectedIndex$ 0��6�   ��5R      �� 5S   "   .R�5T   &   �� $��16(�6H   $��Center=�6V   $
��Left=�6q   ��6,   �� *	Address+6q   5U   #   5W      5X      �� 5Y      -   5        $ 	sum_label��5Y   ,   $��1��6   $��Right=�6?   $��Bottom=�6[   $��18(�6v    �� ContentStringFormat$" Всего: {0} рублей��6�   5Z      5\      � 5]      $��1��6    5^      �� 5_      �� 5`      $��30 �6'   �� 5a      .+�5c      �� -   5        $ back_button��5c   )   $��0��6   $��
Назад��6X   $��18(�6h   $��10q�6v   $��Center=�6�   $��Right=�6�   $	��200��6�   �� 5d      -   5        $ makeOrder_button��5d   )   $��2��6   $!��Оформить заказ��6b   $��18(�6{   $��10q�6�   $��Center=�6�   $
��Left=�6�   $	��200��6�   5e      5f      5g      5h      