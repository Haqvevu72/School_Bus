using School_Bus.Views.Car;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class CarViewModel:BaseViewModel
    {
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowCarAddViewCommand { get; }
        public ICommand ShowCarRemoveViewCommand { get; set; }

        public CarViewModel()
        {
            ShowCarAddViewCommand = new ViewModelCommand(ExecuteShowCarAddViewCommand);
            ShowCarRemoveViewCommand = new ViewModelCommand(ExecuteShowCarRemoveViewCommand);
        }

        public void ExecuteShowCarRemoveViewCommand(object? parameter)
        {
            CarRemoveView inputControl = new CarRemoveView();
            outputwindow = new Window()
            {
                Content = inputControl,
                Height = 400,
                Width = 400,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            inputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    outputwindow.DragMove();
                }
            };
            outputwindow.ShowDialog();
        }

        public void ExecuteShowCarAddViewCommand(object? parameter)
        {
            CarAddView inputControl = new CarAddView();
            inputwindow = new Window()
            {
                Content = inputControl,
                Height = 430,
                Width = 700,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            inputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    inputwindow.DragMove();
                }
            };
            inputwindow.ShowDialog();
        }
    }
}
