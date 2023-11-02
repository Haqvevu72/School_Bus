using Context.Repositories.Concrete;
using Entity.Concrete;
using MaterialDesignThemes.Wpf;
using School_Bus.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace School_Bus.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        public Repository<Admin> Admins = new Repository<Admin>();
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        public ICommand ToggleTheme { get; }
        public ICommand ExitApp { get; }
        public ICommand LoginCommand { get; }
        public ICommand SignUpCommand { get; }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private bool isSnackBarVisible;
        public bool IsSnackBarVisible
        {
            get { return isSnackBarVisible; }
            set
            {
                isSnackBarVisible = value;
                OnPropertyChanged(nameof(IsSnackBarVisible));
            }
        }

        private string snackbarmessage;
        public string SnackBarMessage
        {
            get { return snackbarmessage; }
            set
            {
                snackbarmessage = value;
                OnPropertyChanged(nameof(SnackBarMessage));
            }
        }


        public LoginViewModel()
        {
            ToggleTheme = new ViewModelCommand(ExecuteToggleTheme);
            ExitApp = new ViewModelCommand(ExecuteExitApp);
            LoginCommand = new ViewModelCommand(ExecuteLoginCommand);
            SignUpCommand = new ViewModelCommand(ExecuteSignUpCommand);
        }

        public void ExecuteToggleTheme(object? parameter) 
        {
            ITheme theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        public void ExecuteExitApp(object? parameter)
        {
            Application.Current.Shutdown();
        }

        public void ExecuteLoginCommand(object? parameter)
        {

            if (Password != string.Empty && Username != string.Empty)
            {
                var admins = Admins.GetAll();

                for (int i = 0; i < admins.Count; i++)
                {

                    if (Username== admins[i].Username && Password == admins[i].Password)
                    {
                        MainView mainView = new MainView();
                        Application.Current.Shutdown();
                        mainView.ShowDialog();
                    }
                    else
                    {

                        IsSnackBarVisible = true;
                        SnackBarMessage = "Account not found";
                        Thread thread = new Thread(() =>
                        {

                            Thread.Sleep(1500);
                            Application.Current.Dispatcher.Invoke(() =>
                            {
                                IsSnackBarVisible = false;
                            });


                        });
                        thread.Start();
                    }
                }
            }
        }

        public void ExecuteSignUpCommand(object? parameter)
        {
            if (!(string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password)))
            {
                Admins.Add(new Admin() { Username = Username, Password = Password });
                Admins.SaveChanges();
                IsSnackBarVisible= true;
                SnackBarMessage = "Signed Up";
                Thread thread = new Thread(() =>
                {
                    Thread.Sleep(1500);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        IsSnackBarVisible = false;
                    });


                });
                thread.Start();
            }
            else
            {
                IsSnackBarVisible= true;
                SnackBarMessage= "Please Add Username and Password";
                Thread thread = new Thread(() =>
                {

                    Thread.Sleep(1500);
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        IsSnackBarVisible = false;
                    });


                });
                thread.Start();
            }
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
