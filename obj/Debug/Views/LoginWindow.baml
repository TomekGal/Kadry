   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KadryKadry 5   	      Kadry.Views.LoginWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   %localclr-namespace:Kadry     5   	   -   5        $��FirstWindow��5
        � WindowStartupLocation$  CenterScreen=�5	      (   "MahApps.Metro.Controls.MetroWindow   IsCloseButtonEnabled .   � Title$" Dane logowania do bazy Kadry��5   	   $	��210��6.   $	��600��6;   .��5   
   �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6   $��Dzień Dobry!��6-   $��Center=�6D   $��2��6a   $��24(�6u   $��5q�6�   �� 5   
   $��1��6   $��0��6   $��Podaj nazwę użytkownika��6-   $��16(�6O   $��5q�6]   �� 5   
   $��2��6   $��0��6   $��Podaj hasło��6-   $��16(�6C   $��5q�6Q   �� 5   
   $��1��6+   $��1��68   $��5q�6H   ��6   �� *	NameSet+6H   G� 5   
   -   5         G�Name$ 	PasswordB��5      $��2��6*   $��1��67   $��5q�6G   �� 5   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $
��Auto��6K   $��Right=�6Y   .+�5      �� $��OK��6m   $	��100��6z   $��30��6�   $��5q�6�   ��6   �� *ConfirmCommand+��69   ��  �� ElementName$ 	PasswordB��6�   �� 5       $��Anuluj��6m   $	��100��6~   $��30��6�   $��5q�6�   ��6   �� *CancelCommand+��68   �� $ FirstWindow��6�   �� 5!      $��Popraw��6n   $	��100��6   $��30��6�   $��5q�6�   ��6   �� *CorrectCommand+��69   �� $ FirstWindow��6�   5"      5#      5$      