   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KadryKadry %   Kadry.Views.AddEditEmployeeView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     %localclr-namespace:Kadry     -   $��AddEditEmployeeWindow��  � WindowStartupLocation$  CenterScreen=� � Title$ Dane pracownika��$	��450��$	��400��.���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� $
��Auto ��� .+��� $��0��$��0��$��Id��$��5q�y��� *
IsUpdate+    BooleanToVisibilityConverter �� 	Converter# [  ��  �� 
IsReadOnly . $��0��$��1��$��5q�y��� *
IsUpdate+# [  ���� *Employee.Id+�� $��1��$��0��$��Numer pracownika��$��5q��� $��1��$��1��$��5q����� *Employee.EmployeeId+�� $��2��$��0��$��Imię��$��5q��� $��2��$��1��$��5q����� *Employee.FirstName+�� $��3��$��0��$��Nazwisko��$��5q��� $��3��$��1��$��5q����� *Employee.LastName+�� $��4��$��0��$��Data zatrudnienia��$��5q�(  "System.Windows.Controls.DatePicker  $��4��$��1��$��5q�   SelectedDate �� *Employee.StartDate+�� $��5��$��0��$��Data zwolnienia��$��5q�  $��5��$��1��$��5q� �� *Employee.EndDate+y��� *	IsHired+# [  �� $��6��$��0��$��Zarobki��$��5q��� $��6��$��1��$��5q����� *Employee.Salary+�� $��7��$��0��$��Status��$��5q��� $��7��$��1��$��5q� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$ Id������ *
Statuses+	 �� SelectedValue	 �� *SelectedStatusId+�� $��8��$��0��$��Uwagi��$��5q��� 
 �� TextWrapping$

 Wrap=� �� AcceptsReturn . $��8��$��1��$��5q����� *Employee.Comments+��  �� Orientation$ 
Horizontal=�$��9��$��1��$
��Auto��$��Right=�.+��� $��Akceptuj��$��30��$	��100��$��10q����� *ConfirmCommand+����  �� ElementName$ AddEditEmployeeWindow���� $��Anuluj��$��30��$	��100��$��10q����� *CloseCommand+���� $ AddEditEmployeeWindow��