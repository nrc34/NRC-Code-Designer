   M S B A M L   `   `   `  ����L  HNRC Code Designer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:NRC_Code_Designer.src.UI.ClassNRC_Code_Designer.src.UI.Class  5   	   S.clr-namespace:NRC_Code_Designer.src.UI.ToolBar NRC_Code_Designer.src.UI.ToolBar  5   	   S.clr-namespace:NRC_Code_Designer.src.UI.ToolBox NRC_Code_Designer.src.UI.ToolBox  5   	   O,clr-namespace:NRC_Code_Designer.src.UI.PanelNRC_Code_Designer.src.UI.Panel  5   	   "    NRC_Code_Designer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Fclass_control,clr-namespace:NRC_Code_Designer.src.UI.Class     5   	   MuserControlToolBar.clr-namespace:NRC_Code_Designer.src.UI.ToolBar     5   	   MuserControlToolBox.clr-namespace:NRC_Code_Designer.src.UI.ToolBox     5   	   IuserControlPanel,clr-namespace:NRC_Code_Designer.src.UI.Panel     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ NRC Code Designer��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	   $��Disabled=�5   	   $	��800��5   	   $	��600��6    J� SnapsToDevicePixels .  � WindowStyle$
 None=�5   	   .��5      � -   5         �Name$ GridMain��5       � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      �� 5      $	��115 �6   �� 5      $��32 �6   �� 5      $��32 �6   �� 5      $��32 �6    � RowDefinitions 5   
   �� 5      $��32 �6   �� 5      $��25 �6   �� 5      $��5 �6   �� 5      $	��225 �6   �� 5      $��5 �6   �� 5      $
��259* �6   .+�5"   
   � $��6��6   $��0��5#      
���   �.+�5&      ��    	FontTitle#��[  6   &   System.Windows.Media.TextOptions	   TextRenderingMode$	 Aliased=�5'      $��24(�5(      $��NRC Code Designer��5)      ���	#FF8F8F8F5*      5+      �� 5-   
   -   5        
 ��Name$
 
labelClose��5-      $��5��5.      $��0��5/        StyleLabelMouseOver#��[ 50      $��X��51       � ToolTip$ Close��52      $��32��53      $��32��54      ���	#FF8F8F8F$��14(�56      #��[  57      $��0q�58      $��Center=�59      $��Center=�5:      $��Center=�5;      $��Center=�5<      5=      �� 5?   
   -   5        $
 labelMinimize��5?      $��3��5@      $��0��5A      #��[ 5B      $��_��5C      $ Minimize��5D      $��32��5E      $��32��5F      ���	#FF8F8F8F$��14(�5H      #��[  5I      $��0q�5J      $��Center=�5K      $��Center=�5L      $��Center=�5M      $��Center=�5N      5O      �� 5Q   
   -   5        $
 labelNormal��5Q      $��4��5R      $��0��5S      #��[ 5T      $��[]��5U      $ Reduce��5V      $��32��5W      $��32��5X      ���	#FF8F8F8F$��14(�5Z      #��[  5[      $��0q�5\      $��Center=�5]      $��Center=�5^      $��Center=�5_      $��Center=�5`      5a      � 5c   
   $��2��6   
���   �$��6��5e      � 5g   
   -   5        $ gridToolBar��5g      $��1��5h      $��6��5i      ���	#FF2D2D30.+�5k      .   (NRC_Code_Designer.src.UI.ToolBar.ToolBar  $
��Left=�5l      5m      � 5o   
   -   5        $ gridToolBox��5o      $��3��5p      $��0��5q      $��3��5r      
���   �.+�5t      5   /NRC_Code_Designer.src.UI.Panel.UserControlPanel  -   5          Name$ toolBoxPanel��5u         Label$ Toolbox��5v      $	��140��5w      5x      � 5z   
   -	   5        $ gridProjectNamespacesTree��5z      $��3��5{      $��2��5|      
���   �$��4��5~      .+�5        $ Project Namespaces��5�      $	��201��5�        GridProjectNamespaces   PanelContent# [ 5�      5�      � 5�   
   $��2��6   $��4��5�      $��4��5�      
���   �5�      � 5�   
   -
   5        $ gridDetails��5�      $��5��5�      $��2��5�      
���   �$��4��5�      $��2��5�      .+�5�        -   5        $ detailsPanel��5�      $	��201��5�      5�      � 5�   
   $��1��5�      $��3��5�      $��3��5�      
���   �$
��Auto��5�      $
��Auto��5�      .+�5�      �� $��1q�5�        
BrushPanel#��[ 5�       �� CornerRadius$ 10��6;   �� 5�      -   5         ��Name$ scrollViewerDesigner��5�      $��Visible=�5�      $��15q�5�      .��5�      � -   5        $ gridDesigner��5�      
�������}�. $
��1500��5�      $
��1500��5�      5�      5�      5�      5�      5�      