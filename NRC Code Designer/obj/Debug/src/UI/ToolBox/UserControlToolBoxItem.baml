   M S B A M L   `   `   `  ����  NRC Code Designer=    7NRC_Code_Designer.src.UI.ToolBox.UserControlToolBoxItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5        $��gridToolboxItem��5      $��30��5	      $	��148��5
      
���   �  � ColumnDefinitions  5   
   �� 5      $��30 �6   �� 5      $	��118 �6   .+�5   
   �� $��0��6   $��16��5      $��16��5      ��5      �� *	ItemImage+5      �� 5   
   $��1��6   ���	#FFC5C5C5$��0q�5      $��16(�5      $��Center=�5         	PanelFont#��[  5      &   System.Windows.Media.TextOptions   TextRenderingMode$ Aliased=�5      ��5      ��  �� Path$ Label�5      ��5   
   �� 5        �� 
TargetType" �6   .�5!      ��  �� Property � �� �� Value
 �   �6/    �� Triggers 5"      :� 5#       :� RoutedEvent$ 
MouseEnter��6#   [�5$      �� 5%      .��5&   "   �� .��5'   &   �� 	 �� To$ 	#FF3E3E42X�5(   )   	 �� TargetProperty$/	 )(Grid.Background).(SolidColorBrush.Color)�5)   )   
 g� Duration$
 0:0:0.1D�5*   )   5+   #   5,      5.      :� 5/      $ 
MouseLeave��6#   [�50      �� 51      .��52   "   �� .��53   &   �� $ BlackX�54   )   $/	 )(Grid.Background).(SolidColorBrush.Color)�55   )   $
 0:0:0.1D�56   )   57   #   58      5:      5<      5>      5?      