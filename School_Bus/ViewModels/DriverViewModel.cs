using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Driver;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class DriverViewModel:BaseViewModel
    {
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowRemoveDriverViewCommand { get; set; }
        public ICommand ShowAddDriverViewCommand { get; set; }

        private ObservableCollection<DriverDTO> driverlist;
        public ObservableCollection<DriverDTO> DriverList
        {
            get { return driverlist; }
            set
            {
                driverlist = value;
                OnPropertyChanged(nameof(DriverList)); // Notify property change
            }
        }

        public DriverViewModel()
        {
            ShowRemoveDriverViewCommand = new ViewModelCommand(ExecuteShowRemoveDriverViewCommand);
            ShowAddDriverViewCommand= new ViewModelCommand(ExecuteShowAddDriverViewCommand);
            Repository<Driver> repository = new Repository<Driver>();
            DriverList = new ObservableCollection<DriverDTO>(repository.Drivers());
        }

        public void ExecuteShowRemoveDriverViewCommand(object? parameter)
        {
            DriverRemoveView outputControl = new DriverRemoveView();
            outputwindow = new Window
            {
                Content = outputControl,
                Height = 400,
                Width = 400,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            outputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    outputwindow.DragMove();
                }
            };
            outputwindow.ShowDialog();
        }
        public void ExecuteShowAddDriverViewCommand(object? parameter) 
        {
            DriverAddView outputControl = new DriverAddView();
            inputwindow = new Window
            {
                Content = outputControl,
                Height = 430,
                Width = 700,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            outputControl.MouseDown += (sender, e) =>
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
