using Kadry.Commands;
using Kadry.Models.Domains;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Kadry.ViewModels
{
 public  class LoginWindowViewModel : ViewModelBase
    {
       
        public LoginWindowViewModel()
        {
            ConfirmCommand = new AsyncRelayCommand(Confirm);
            CancelCommand = new RelayCommand(Cancel);
            CorrectCommand = new RelayCommand(Correct);
           
         }

        public ICommand ConfirmCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public ICommand CorrectCommand { get; set; }

        private string _nameSet;

        public string NameSet
        {
            get { return _nameSet; }
            set 
            { 
                _nameSet = value;
                OnPropertyChanged();
            }
        }

        private string _passwordSet;

        public string PasswordSet
        {
            get { return _passwordSet; }
            set
            { 
                _passwordSet = value;
                OnPropertyChanged();
            }
        }

        private string _passwordB;
        public string PasswordB
        {
            get { return _passwordB; }
            set
            {
                _passwordB = value;
                OnPropertyChanged();
            }
        }

        public string Password { get; set; }
        private void Correct(object obj)
        {
           
            NameSet = null;
            PasswordSet = null;

        }

        private void Cancel(object obj)
        {
            CloseWindow(obj as Window);
            var currentWindow = Application.Current.MainWindow as MetroWindow;
            currentWindow.Close();

        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }

        private async Task  Confirm(object parameter)
        {
            var loginSettings = new LoginSettings();
            loginSettings.Name = "user";
            loginSettings.Password = "password";

           
            PasswordBox boxPass = (PasswordBox)parameter;
            Password = boxPass.Password;

            var windows = Application.Current.Windows;
            var loginWindow = windows[1] as MetroWindow;
            loginWindow.ShowCloseButton=false;

            if (NameSet == loginSettings.Name && Password == loginSettings.Password)
            {

                var dialog = await loginWindow.ShowMessageAsync(
                    "Potwierdzenie logowania", "Dane logowania są poprawne", MessageDialogStyle.Affirmative);

                if (dialog == MessageDialogResult.Affirmative)
                    loginWindow.Close();
            }
            else
            {
                var dialog = await loginWindow.ShowMessageAsync(
                    "Potwierdzenie logowania", "Dane logowania są złe", MessageDialogStyle.Affirmative);
                if (dialog == MessageDialogResult.Affirmative)
                    loginWindow.Activate();
            }
        }
    }
}
