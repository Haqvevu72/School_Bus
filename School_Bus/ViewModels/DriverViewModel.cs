using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Driver;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class DriverViewModel:BaseViewModel
    {
        Repository<Driver> repository = new Repository<Driver>();
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowRemoveDriverViewCommand { get; set; }
        public ICommand ShowAddDriverViewCommand { get; set; }
        public ICommand SearchCommand { get; set; }


        private string id;

        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }


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
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);



            //DriverList = new ObservableCollection<DriverDTO>(repository.Drivers());
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

        public void ExecuteSearchCommand(object parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                DriverList.Clear();
                DriverList.Add(new DriverDTO() { Id = result.Id, Firstname = result.FirstName , Lastname = result.LastName , Address = result.Address , Phone = result.Phone });
            }
        }
    }
}
