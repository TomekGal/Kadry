   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   
   @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Kadry.ViewsKadry.Views 5   	   !   Kadry.Views.FiredWindowView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   
   +localclr-namespace:Kadry.Views     5   	   -   5        $��FiredWindow��5
        � WindowStartupLocation$  CenterScreen=�5	       � Title$ Data zwolnienia��5   	   $	��130��6!   $	��200��6.   $��Center=�6:   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Podaj datę zwolnienia��6   $��Center=�60   $�� 5q�6M   (  "System.Windows.Controls.DatePicker  5   
   $��1��68      SelectedDate 6   �� *	FiredDate+68   �� 5       �� Orientation$ 
Horizontal=�6   $��9��6*   $��1��67   $
��Auto��6H   $��Right=�6V   .+�5      �� $��Akceptuj��6o   $��20��6�   $��80��6�   $��5q�6�   ��6   �� *ConfirmCommand+��69   ��  �� ElementName$ FiredWindow��6�   �� 5      $��Anuluj��6l   $��20��6}   $��80��6�   $��5q�6�   ��6   �� *CloseCommand+��66   �� $ FiredWindow��6�   5      5      5      