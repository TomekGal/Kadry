   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   @ <Kadry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KadryKadry 5   	      Kadry.Views.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   %localclr-namespace:Kadry     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Tabela pracowników��5
   	   $	��450��6$   $	��800��61   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��781* �6   �� 5      $	��12* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��2��6;   $��
0,0,-0.4,0q�6O   .+�5      �� $��	Zatrudnij��5      $��30��5      $	��100��5      $��5q�5      ��5      �� *AddEmployeeCommand+5      �� 5      $��Zwolnij��5      $��30��5      $	��100��5      $��5q�5       ��5      �� *DeleteEmployeeCommand+5       �� 5!      $��Edytuj��5$      $��30��5%      $	��100��5&      $��5q�5'      ��5"      �� *EditEmployeeCommand+��5#      �� *SelectedEmployee+5'      �� 5(      $	�� 30��5)      $
�� 200��5*      $�� 5q�5+       �� DisplayMemberPath$
 Name��5.       �� SelectedValuePath$ Id��5/      ��5,      �� *
Statuses+ �� SelectedValue 5-      �� *SelectedStatusId+5/      �� 51      $��	Odśwież��53      $��30��54      $	��100��55      $��5q�56      ��52      �� *RefreshEmployeeCommand+56      57      &   System.Windows.Controls.DataGrid  58   
   $��1��59      $��	5,5,4.6,5q�5:         CanUserAddRows .  	   
IsReadOnly	 . 
   AutoGenerateColumns
 .  $��2��5?   )   ��5;      �� *	Employees+ �� SelectedItem 5<      �� *SelectedEmployee+   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+6<     5B         Header$ Numer pracownika��6E    6%   �� *
EmployeeId+6E     5C      $ Imię��6C    6%   �� *	FirstName+6C     5D      $ Nazwisko��6B    6%   �� *
LastName+6B     5E      $ Zarobki��6@    6%   �� *Salary+6@     5F      $ Data zatrudnienia��6]    6%   �� *	StartDate+ �� StringFormat$ 
dd-MM-yyyy��6]     5G      $ Data zwolnienia��6Z    6%   �� *	EndDate+$ 
dd-MM-yyyy��6Z     5H      $ Status��6G    6%   �� *Status.Name+6G     5I      $ Uwagi��6B    6%   �� *
Comments+6B   5L      5N      5O      