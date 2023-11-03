using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Car;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class CarViewModel:BaseViewModel
    {
        Repository<Car> repository = new Repository<Car>();
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowCarAddViewCommand { get; }
        public ICommand ShowCarRemoveViewCommand { get; }
        public ICommand SearchCommand { get; }

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

        private ObservableCollection<CarDTO> carlist;
        public ObservableCollection<CarDTO> CarList
        {
            get { return carlist; }
            set
            {
                carlist = value;
                OnPropertyChanged(nameof(CarList)); // Notify property change
            }
        }

        public CarViewModel()
        {
            ShowCarAddViewCommand = new ViewModelCommand(ExecuteShowCarAddViewCommand);
            ShowCarRemoveViewCommand = new ViewModelCommand(ExecuteShowCarRemoveViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            CarList = new ObservableCollection<CarDTO>(repository.Cars());
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

        public void ExecuteSearchCommand(object? parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                CarList.Clear();
                CarList.Add(new CarDTO() { Id = result.Id, DriverId = result.DriverId , Capacity = result.Capacity , Number = result.Number });
            }
        }
    }
}
