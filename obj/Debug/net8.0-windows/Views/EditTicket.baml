   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.ViewsWpfApp.Views  5   	       WpfApp.Views.EditTicket   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp.Views     5   	     � Title$  
EditTicket��5   	   $	��450��6   $	��800��6)   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��
Ticket ID:��6   $
��Bold"�6&   �� 5   
   $��1��6/   ��6   �� *	Ticket.Id+6/   �� 5   
   $��Title:��6   $
��Bold"�6"   $��2��64   �� 5   
   $��3��62   ��6   �� *Ticket.Title+62   �� 5   
   $��Status:��6   $
��Bold"�6#   $��4��65   �� 5   
   $��5��6    �� Orientation$ Vertical=�6"   $��	0 30 0 50q�69   $	��100��6L   $
��Left=�6X   .+�5      �� $
��open��6    d� 	IsChecked 6&   �� *IsOpen+ �� Mode$ TwoWay=�{�6O   �� *IsOpenEnabled+�� 5      $��In Progress��6    6-   �� *IsInProgress+$ TwoWay=��� 5      $��Closed��6    6(   �� *
IsClosed+$ TwoWay=�5      �� 5    
   $
��Save��6   $��6��6    $��50��6M   $��30��6X   $
��Left=�6d   $��Bottom=�6   ��6-   �� *SaveCommand+��5!      ��  �� RelativeSource ��  �� AncestorType
 Window5"      5#      