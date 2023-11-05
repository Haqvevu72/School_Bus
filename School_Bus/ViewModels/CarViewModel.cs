﻿using Context.Repositories.Concrete;
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
        public ICommand AddCommand { get; set; }
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

        // Properties

        private int driverid;

        public int DriverId
        {
            get { return driverid; }
            set
            {
                if (driverid != value)
                {
                    driverid = value;
                    OnPropertyChanged(nameof(DriverId));
                }
            }
        }
        // ................................
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (capacity != value)
                {
                    capacity = value;
                    OnPropertyChanged(nameof(Capacity));
                }
            }
        }
        // ................................
        private string number;

        public string Number
        {
            get { return number; }
            set
            {
                if (number != value)
                {
                    number = value;
                    OnPropertyChanged(nameof(Number));
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
            AddCommand = new ViewModelCommand(ExecuteAddCommand);

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


        public void ExecuteAddCommand(object parameter)
        {
            try
            {
                Car new_class = new Car() { DriverId = DriverId, Capacity = Capacity, Number = Number };

                repository.Add(new_class);
                repository.SaveChanges();
                CarList.Add(new CarDTO() { Id = new_class.Id, DriverId = new_class.DriverId, Capacity = new_class.Capacity, Number = new_class.Number });


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { inputwindow.Close(); }
        }
    }
}
