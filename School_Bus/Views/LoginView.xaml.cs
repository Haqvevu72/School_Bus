using Context.Contexts;
using Entity.Concrete;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace School_Bus.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }
        SchoolBusDB SchoolBusDb = new SchoolBusDB();
        public bool IsDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();


        private void toggleTheme(object sender, RoutedEventArgs e)
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

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

            var Admins = SchoolBusDb.Admins.ToList();

            for (int i = 0; i < Admins.Count; i++)
            {

                if (txt_username.Text == Admins[i].Username && txt_password.Password == Admins[i].Password)
                {
                    MainView mainView = new MainView();
                    Close();
                    mainView.ShowDialog();
                }
            }
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            SchoolBusDb.Admins.Add(new Admin() { Username = txt_username.Text, Password = txt_password.Password });
            SchoolBusDb.SaveChanges();
            SnackBar.IsActive = true;
            Thread thread = new Thread(() =>
            {
                Thread.Sleep(1000);
                Dispatcher.Invoke(() => { SnackBar.IsActive = false; });


            });
            thread.Start();
            txt_password.Password = string.Empty;
            txt_username.Text = string.Empty;
        }
    }
}
