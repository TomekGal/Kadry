using Kadry.Commands;
using Kadry.Models;
using Kadry.Models.Domains;
using Kadry.Models.Wrappers;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Kadry.ViewModels
{
   public class AddEditEmployeeViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();
        public AddEditEmployeeViewModel(EmployeeWrapper employee=null) 
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);

            if (employee == null)
            {
                Employee = new EmployeeWrapper();
            }
            else
            {
                Employee = employee;
                IsUpdate = true;
            }
            InitStatuses();
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private EmployeeWrapper _employee;

        public EmployeeWrapper Employee
        {
            get { return _employee; }
            set 
            { 
                _employee = value;
                OnPropertyChanged();
            }
        }

        private bool _isUpdate;

        public bool IsUpdate
        {
            get { return _isUpdate; }
            set 
            { 
                _isUpdate = value;
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

        private bool _isHired=true;

        public bool IsHired
        {
            get { return _isHired; }
            set 
            { 
                _isHired = value;
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
        
        private void Confirm(object obj)
        {
            if (!IsUpdate)
              AddEmployee();
            else
             UpdateEmployee();
         
            
            CloseWindow(obj as Window);
        }

        private void AddEmployee()
        {
            var MaxEmployeeId = _repository.CheckEmployeeId();
            Employee.EmployeeId = MaxEmployeeId + 1;
            _repository.AddEmployee(Employee);
        }

        private void UpdateEmployee()
        {
            
            _repository.UpdateEmployee(Employee);
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {

            window.Close();
        }
       
        private void InitStatuses()
        {
            var statuses = _repository.GetStatuses();
            statuses.RemoveAt(0);
            Statuses = new ObservableCollection<Status>(statuses);

            if (IsUpdate)
                SelectedStatusId = Employee.Status.Id;

            else
            {
                Employee.Status.Id = 1;
                Employee.StartDate = DateTime.Now;
                IsHired = false;

            }

        }

    }

}
