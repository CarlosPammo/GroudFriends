   M S B A M L   `   `   `  ����  My Phonebook    My_Phonebook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      .+�5      �� -   5         ��Name$ buscar��5      $��0��6&   $��10q�66   $��30��6B   6N   �� 5      -   5         ��Name$ BtnNew��5      $��1��6%   $��30��65   $��46,17,35,17q�6A   $��+��6V   6b   5      � 5   
   $��1��6    5      �� 5      �� 5      $
��Auto �6#   $	��156��60   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGContacts��5      $��0��6+   $��10q�6;      AutoGenerateColumns .  
����� �   VerticalGridLinesBrush
 �   � � DataContext 5      �� ��6   �� 	   RowBackground	 5      �� 5      
 �� EndPoint$
 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5      $ 	#FFA269C3��6'   $ 1Q�69   5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%      
Foreground �	#FF5372B41  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$
 Name�6S     5$      $ Telefono��6)    6;   �� $ 
Num_movile�  5%      $ Grupo��6)    68   �� $ Group�4  .System.Windows.Controls.DataGridTemplateColumn  5'         CellTemplate 5(      �� 5)      .R�5*   "   �� -   5        $��Editar��5*   )   6:   5+      5-        5.       5/      �� 50      .R�51   "   �� -   5        $��Eliminar��51   )   6<   52      54      56      �� 57      -   5         ��Name$ 
List_group��57      $��1��6*   $
��Left=�6:   $	��224��6U   $��	10,12,0,0q�6b   $	��Top=�6u   $	��109��6�    J� RenderTransformOrigin$ 0.1,0&�6�   .@�58      �� $��movil��6   �� 59      $��trabajo��6   �� 5:      $
��Casa��6   �� 5;      $��oficina��6   �� 5<      $��otros��6   5=      5>      5@      5A      