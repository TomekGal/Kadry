   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KadryKadry    Kadry.Views.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     %localclr-namespace:Kadry       � WindowStartupLocation$  CenterScreen=� � Title$ Tabela pracowników��$	��450��$	��800��.���  � RowDefinitions �� $
��Auto ��� .+���  �� Orientation$ 
Horizontal=�$��0��.+��� $��	Zatrudnij��$��30��$	��100��$��5q����� *AddEmployeeCommand+�� $��Zwolnij��$��30��$	��100��$��5q����� *DeleteEmployeeCommand+�� $��Edytuj��$��30��$	��100��$��5q����� *EditEmployeeCommand+���� *SelectedEmployee+�� $	�� 30��$
�� 200��$�� 5q� �� DisplayMemberPath$
 Name�� �� SelectedValuePath$ Id������ *
Statuses+ �� SelectedValue �� *SelectedStatusId+�� $��	Odświerz��$��30��$	��100��$��5q����� *RefreshEmployeeCommand+&   System.Windows.Controls.DataGrid  $��1��$�� 5q�   CanUserAddRows .     
IsReadOnly . 	   AutoGenerateColumns	 .  ���� *	Employees+
 �� SelectedItem
 �� *SelectedEmployee+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+     Header$ Numer pracownika�� �� *
EmployeeId+  $ Imię�� �� *	FirstName+  $ Nazwisko�� �� *
LastName+  $ Zarobki�� �� *Salary+  $ Data zatrudnienia�� �� *	StartDate+ �� StringFormat$ 
dd-MM-yyyy��  $ Data zwolnienia�� �� *	EndDate+$ 
dd-MM-yyyy��  $ Status�� �� *Status.Name+  $ Uwagi�� �� *
Comments+