   M S B A M L   `   `   `  ����I  ELNUProjectWPFF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LNUProjectWPFFLNUProjectWPFF  5   	       LNUProjectWPFF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LNUProjectWPFF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         GoodsCollection �� Source �� Path��%B   &	        �� 5
   
    5      �� $ GoodList�5      5      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��83* �6   �� 5      $
��236* �6   �� 5      $	��61* �6   �� 5      $	��64* �6   �� 5      $	��16* �6   �� 5      $
��221* �6   �� 5      $	��27* �6   �� 5      $	��84* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	goodsGrid��5         AutoGenerateColumns .  $
��Left=�6B   $	��185��6]   $��	53,44,0,0q�6j   $	��Top=�6}   $	��595��6�   $��6��6�   ��5      ��  �� Source# [     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6<   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToCells 6H      
IsReadOnly .    MinWidth$ 60Q�6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6n     5      $
	 Name��6>   $
 SizeToCells 6L    . $	 170Q�6r    6%   �� *Name+6r     5      $	 CategoryName��6F   $
 SizeToCells 6\    . $	 150Q�6�    6%   �� *CategoryName+6�     5      $	 Price��6@   $
 SizeToCells 6O    . $	 120Q�6u    6%   �� *Price+6u     5       $	 Quantity��6B   $
 SizeToCells 6T    . $ 90Q�6z    6%   �� *
Quantity+6z   5"      �� 5#   
   -   5         ��Name$ 	txtFilter��5#   �   $
��Left=�6   $��23��6-   $��	62,13,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6`   $	��120��6x   $��1��6�   �� 5$   
   -   5         ��Name$ Button��5$      $	��Add��6!   $
��Left=�6/   $��
53,250,0,0q�6J   $	��Top=�6^   $��75��6v   $��2��6�   6�   �� 5%   
   $��Search��6   $
��Left=�6!   $��	73,10,0,0q�6<   $	��Top=�6O   $��2��6g   $��55��6{    J� RenderTransformOrigin$ 0.545,-0.192&�6�   5&      5'      