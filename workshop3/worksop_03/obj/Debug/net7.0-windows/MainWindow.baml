   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   E Aworksop_03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:worksop_03
worksop_03 5   	      worksop_03.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   *localclr-namespace:worksop_03     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)    � 	Resources 5
       worksop_03.EtelToColor   ColorConverter��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��6* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $
��1.5* �6   �� 5      $��4* �6   .+�5   
   �� -   5        $��1��5      $	��Add��6!   $��Center=�6/   $��0,23,0,0q�6L   $��1��6^   $	��Top=�6k   $��26��6�   $	��106��6�   6�   �� 5   
   -   5        $��1��5      $��Remove��6!   $��Center=�62   $��0,54,0,0q�6O   $��1��6a   $	��Top=�6n   $��26��6�   $	��106��6�   6�   �� 5   
   -   5         ��Name$
 lbox��5      $��1��6    $��0��6-   $��Stretch=�6=    � DataContext 6b   ��  �� ElementName$ cb_kategotiavalasztas�� �� Path$ SelectedItem���5      �� 5      .R�5      �� 
���   �$��1q�61   ._�5      ��  �� Orientation$ 
Horizontal=�6%   ��6>   �� *
FoodType+	 �� 	Converter#	 [  .+�5      �� $��10q�6=   ��6$   �� *Name+6=   �� 5       $��10q�6A   ��6$   �� *
FoodType+6A   �� 5!      $��10q�6>   ��6$   �� *Price+6>   5"      5#      5$      5&      �� 5(   
   -   5        $ lb_rendeles��5(      $��0��6'   $��2��64   $��2��6D   $��Stretch=�6U   ��5)      �� 5*      .R�5+      �� 
���   �$��1q�61   ._�5,      �� $ 
Horizontal=�6%   .+�5-      �� $��10q�6=   ��6$   �� *Name+6=   �� 5.      $��10q�6A   ��6$   �� *
FoodType+6A   �� 5/      $��10q�6>   ��6$   �� *Price+6>   50      51      52      54      �� 58   
   -   5        
 ��Name$
 	cb_filter��58      $��Filter��6&   $
��Left=�67   $��32,0,0,0q�6R   $��Center=�6d   6�   �� 59   
   -   5         ��Name$ cb_kategotiavalasztas��59       �� SelectedIndex$ 0��62   $��Center=�6D   $��123,0,126,0q�6f   $	��NaN��6{   $��2��6�   .@�5:      ��	Appetizer��6'   ��5;      
MainCourse��6(   ��5<      Dessert��6%   ��5=      	Drink��6#   5>      �� 5?   
   $��1��6   $��          Össz:��6    $��Center=�6:   $��0,1,0,0q�6W   $	��Top=�6h   $	��106��6�   $��25��6�   �� 5@   
   -   5         ��Name$ label_osszeg��5@      $��1��6&   $��12(�66   $��Center=�6E   $��0,1,0,0q�6b   $��Center=�6s   $��Bottom=�6�   $	��106��6�   $��30��6�   5B      5C      