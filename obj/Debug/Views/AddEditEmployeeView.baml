   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KadryKadry 5   	   3clr-namespace:Kadry.ViewModelsKadry.ViewModels 6+   %   Kadry.Views.AddEditEmployeeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   %localclr-namespace:Kadry     5   	   5
viewmodelsclr-namespace:Kadry.ViewModels     6+   -   5        $��AddEditEmployeeWindow��5
        � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Dane pracownika��5   	   $	��450��6!   $	��400��6.   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��5       $��0��5!      $��Id��5"      $��5q�5#      y�5      �� *
IsUpdate+    BooleanToVisibilityConverter �� 	Converter# [  5#      �� 5$   
    �� 
IsReadOnly . $��0��5(      $��1��5)      $��5q�5*      y�5%      �� *
IsUpdate+# [  ��5&      �� *Employee.Id+5*      �� 5,   
   $��1��6   $��0��6   $��Numer pracownika��6-   $��5q�6H   �� 5-   
    . $��1��6J   $��1��6W   $��5q�6g   ��6   �� *Employee.EmployeeId+6g   �� 5/   
   $��2��6   $��0��6   $��Imię��6-   $��5q�6<   �� 50   
   $��2��6x   $��1��6�   $��5q�6�   ��6   �� *Employee.FirstName+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   �� 52   
   $��3��6   $��0��6   $��Nazwisko��6-   $��5q�6@   �� 53   
   $��3��6v   $��1��6�   $��5q�6�   ��6   �� *Employee.LastName+$ PropertyChanged=� . 6�   �� 55   
   $��4��6   $��0��6   $��Data zatrudnienia��6-   $��5q�6I   (  "System.Windows.Controls.DatePicker  56   
   $��4��6   $��1��6"   $��5q�6_      SelectedDate 62   �� *Employee.StartDate+6_   �� 58   
   $��5��6   $��0��6   $��Data zwolnienia��6-   $��5q�6G     59   
   $��5��6   $��1��6#   $��5q�5;       59   3   �� *Employee.EndDate+y�5:      �� *	IsHired+# [  5;      �� 5=   
   $��6��6   $��0��6   $��Zarobki��6-   $��5q�6?   *   $MahApps.Metro.Controls.NumericUpDown  5>   
   $��6��6>   $��1��6K   $��5q�6[   	   Value	 6   �� *Employee.Salary+6[   �� 5@   
   $��7��6   $��0��6   $��Status��6-   $��5q�6>   �� 5A   
   $��7��5B      $��1��5C      $��5q�5D      
 �� DisplayMemberPath$

 Name��5G       �� SelectedValuePath$ Id��5H      ��5E      �� *
Statuses+ �� SelectedValue 5F      �� *Employee.Status.Id+5H      �� 5K   
   $��8��6   $��0��6   $��Uwagi��6-   $��5q�6=   �� 5L   
    �� TextWrapping$
 Wrap=�5N       �� AcceptsReturn . $��8��5P      $��1��5Q      $��5q�5R      ��5M      �� *Employee.Comments+5R      �� 5S   
    �� Orientation$ 
Horizontal=�6   $��9��6.   $��1��6;   $
��Auto��6L   $��Right=�6Z   .+�5T      �� $��Akceptuj��6y   $��30��6�   $	��100��6�   $��10q�6�   ��6   �� *ConfirmCommand+��69   ��  �� ElementName$ AddEditEmployeeWindow��6�   �� 5U      $��Anuluj��6v   $��30��6�   $	��100��6�   $��10q�6�   ��6   �� *CloseCommand+��66   �� $ AddEditEmployeeWindow��6�   5V      5W      5X      