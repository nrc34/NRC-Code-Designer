   M S B A M L   `   `   `  ����  NRC Code Designer5    /NRC_Code_Designer.src.UI.Class.UserControlClass   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $
��Auto��5   4   $
��Auto��6A   .��5      � -   5          �Name$  	gridClass��5      $
��Auto��5	      $
��Auto��6   $	��Top=�5
      $
��Left=�5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   ��5   
   �� 5       �� 
TargetType" �6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value .  . �5      ��  �� Property � ��   ClassBackgroundBrush �� Value# [  5   !   5      5      P� 5       �@J�IsMouseOver . . �5      ��  � ��   ClassBackgroundMoseOverBrush# [ 5    !   5"      5#      5%      .+�5(   
   �� $
��Auto��6   $
��Auto��6     ClassBorderBrush#��[ 5)      $��2,2,2,0q�5*      $��0��6'   5+      �� 5,   
   $
��Auto��6   $
��Auto��6   #��[ 5-      $��2q�5.      $��1��6!   5/      �� 50   
   $
��Auto��6   $
��Auto��6   #��[ 51      $��2,0,2,2q�52      $��2��6'   53      �� 55   
   -   5        	 ��Name$	 labelClassName��55      $��0��56      $��Center=�58      $��Center=�59      $��	15,5,15,2q�5:      $��Consolas)�5;      ��57      �� 5;      9� 5=   
   $��1��6   .��5>      �� -   5        
 ��Name$
 itemsControlProperties��5>      $��1��6;   ��5?      �� 5@      .R�5A      ��  �� Orientation$ Vertical=�6%   5B      ��5D      �� 5E      .R�5F      �� $��Consolas)�5G       ��5F       �� *Name+5G       5H      5J      5K      9� 5M   
   $��2��6   .��5N      �� -   5        $
 itemsControlMethods��5N      $��2��68   ��5O      �� 5P      .R�5Q      �� $ Vertical=�6%   5R      ��5T      �� 5U      .R�5V      �� $��Consolas)�5W       ��5V       �� *Name+5W       5X      5Z      5[      5]      5_      