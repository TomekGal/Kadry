using Kadry.Commands;
using Kadry.Models.Domains;
using Kadry.Models.Wrappers;
using Kadry.Views;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Kadry.ViewModels
{
    public class MainViewModel: ViewModelBase
    {

        private Repository _repository = new Repository();
        public MainViewModel()
        {
           
            RefreshEmployeeCommand = new RelayCommand(RefreshEmployee);
            AddEmployeeCommand = new RelayCommand(AddEditEmployee);
            EditEmployeeCommand = new RelayCommand(AddEditEmployee, CanEditDeleteEmployee);
            DeleteEmployeeCommand = new AsyncRelayCommand(DeleteEmployee, CanEditDeleteEmployee);

            var loginWindow = new LoginWindow();
            loginWindow.ShowDialog();

            _repository.InitStatuses();
            RefreshKadry();
            InitStatuses();

        }

        public ICommand RefreshEmployeeCommand { get; set; }
        public ICommand AddEmployeeCommand { get; set; }
        public ICommand EditEmployeeCommand { get; set; }
        public ICommand DeleteEmployeeCommand { get; set; }


        private ObservableCollection<EmployeeWrapper> _employees;

        public ObservableCollection<EmployeeWrapper> Employees
        {
            get { return _employees; }
            set 
            { 
                _employees = value;
                OnPropertyChanged();
            }
        }

        private EmployeeWrapper _selectedEmployee;

        public EmployeeWrapper SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }

        private int _selectedStatusId;

        public int SelectedStatusId
        {
            get { return _selectedStatusId; }
            set
            { 
                _selectedStatusId = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Status> _status;

        public ObservableCollection<Status> Statuses
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }
        private bool CanRefreshEmployee(object obj)
        {
            return true;
        }

        private void RefreshEmployee(object obj)
        {
            RefreshKadry();
        }

        public void InitStatuses()

        {
          
            var statuses = _repository.GetStatuses();
            
            Statuses = new ObservableCollection<Status>((IEnumerable<Status>)statuses);

            SelectedStatusId = 0;
          
        }

        private async Task DeleteEmployee(object obj)
        {
            var metroWindow = Application.Current.MainWindow as MetroWindow;
           var dialog=  await metroWindow.ShowMessageAsync("Zwalnianie pracownika",
               $"Czy na pewno chcesz zwolnić pracownika {SelectedEmployee.FirstName } { SelectedEmployee.LastName}?",
               MessageDialogStyle.AffirmativeAndNegative);

            if (dialog != MessageDialogResult.Affirmative)
            
                return;

            var firedEmployee = new FiredWindowView(SelectedEmployee.Id);
            firedEmployee.ShowDialog();

            _repository.DismissEmployee(SelectedEmployee.Id);
           
            RefreshKadry();
        }

        private bool CanEditDeleteEmployee(object obj)
        {
            
            return SelectedEmployee !=null;
        }

        private void AddEditEmployee(object obj)
        {
            var addEditEmployeeWindow = new AddEditEmployeeView(obj as EmployeeWrapper);
            addEditEmployeeWindow.Closed += AddEditEmployeeWindow_Closed;
            addEditEmployeeWindow.ShowDialog();
        }

        private void AddEditEmployeeWindow_Closed(object sender, EventArgs e)
        {
            RefreshKadry();
        }

        private void RefreshKadry()
        {
            Employees = new ObservableCollection<EmployeeWrapper>(_repository.GetEmployees(SelectedStatusId))
            {

               
            };
            
        }
        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {
            window.Close();

        }
    }
}
