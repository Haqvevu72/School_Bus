using Context.Repositories.Concrete;
using Entity.Concrete;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    private class LoginViewModel:BaseViewModel
    {
        public Repository<Admin> Admins = new Repository<Admin>();
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        public ICommand ToggleTheme { get; }

        public LoginViewModel()
        {
            ToggleTheme = new ViewModelCommand(ExecuteToggleTheme);
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
    }
}
