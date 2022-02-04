using Kadry.Commands;
using System;
using System.Windows;
using System.Windows.Input;

namespace Kadry.ViewModels
{
    
    public class FiredWindowViewModel : ViewModelBase
    {
        private Repository _repository = new Repository();
        public  FiredWindowViewModel(int id)
        {
            CloseCommand = new RelayCommand(Close);
            ConfirmCommand = new RelayCommand(Confirm);
            SelectedEmployeeId = id;
        }

        public ICommand CloseCommand { get; set; }
        public ICommand ConfirmCommand { get; set; }

        private DateTime _firedDate = DateTime.Now;

        public DateTime FiredDate 
        {
            get { return _firedDate; }
            set 
            { 
                _firedDate = value;
                OnPropertyChanged();
            }
        }

        private int _selectedEmployeeId;

        public int SelectedEmployeeId
        {
            get { return _selectedEmployeeId; }
            set
            {
                _selectedEmployeeId = value;
                OnPropertyChanged();
            }
        }

        private void Close(object obj)
        {
            CloseWindow(obj as Window);
        }

        private void CloseWindow(Window window)
        {

            window.Close();
        }

        private void Confirm(object obj)
        {

           UpdateFiredEmployee(SelectedEmployeeId);
            CloseWindow(obj as Window);
        }
        public void UpdateFiredEmployee(int id)
        {

            using (var context = new ApplicationDbContext())
            {
                var employeeToFired = context.Employees.Find(id);
                employeeToFired.EndDate = FiredDate;
                context.SaveChanges();
            }
           
        }
        
    }
    
}
