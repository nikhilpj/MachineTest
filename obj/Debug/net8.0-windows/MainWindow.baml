   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	       WpfApp.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��
Add Ticket��5      $��Right=�6>   $��1��6Z   $��	0 10 20 0q�6j   �� 5   
   $��1��63   $��2��6@   $	��500��6T   $��0 30 0 0q�6`   ��6   �� *	Tickets+ �� View 5      �� 5      .P�5      �� $��Id��6%    �� DisplayMemberBinding 61   �� *Id+�� 5      $��Title��6%    �� Width$	 100��6[    64   �� *Title+6[   �� 5      $��Details��6%   $	 150��6c    66   �� *Description+6c   �� 5      $��status��6$    64   �� *Status+�� 5      $
��Edit��6%    �� CellTemplate 5      �� 5      .R�5    "   �� -   5        $
��Edit��5    )   
 � Tag 6Q   �� {�6a   �� *
isEditable+5!      5#      5&      5(      5)      5*      