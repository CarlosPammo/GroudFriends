   M S B A M L   `   `   `  ����  My Phonebook    My_Phonebook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $��4* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��3* �6#   �� 5      .+�5      �� $��0��6   $��10q�6&   $��30��62   �� 5      -   5         ��Name$ BtnNew��5      $��1��6%   $��30��65   $��46,17,35,17q�6A   $��+��6V   6b   5      � 5   
   $��1��6    5      �� 5      $��3* �6#   �� 5      .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGContacts��5      $��1��6+   $��0��68   $��10q�6H      AutoGenerateColumns .   � DataContext 5      �� ��6   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 65   �� 
 �� Path$

 Name�  5      $ Telefono��6%   	 67   �� $
 	Telephone�  5      $ Grupo��6%   	 64   �� $
 group�5       �� 5!      -   5         ��Name$ 
List_group��5!      $��1��6*   $
��Left=�6:   $	��224��6U   $��	10,12,0,0q�6b   $	��Top=�6u   $	��109��6�    J� RenderTransformOrigin$ 0.1,0&�6�   .@�5"      �� $��movil��6   �� 5#      $��trabajo��6   �� 5$      $��personal��6   �� 5%      $��oficina��6   �� 5&      $��otros��6   5'      5(      5*      5+      