using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Driver;
using System;
using System.Collections.Generic;
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
        public ICommand FindCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

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

        private string firstname;

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (firstname != value)
                {
                    firstname = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        // ................................
        private string lastname;

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (lastname != value)
                {
                    lastname = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        // ................................
        private string phone;

        public string Phone
        {
            get { return phone; }
            set
            {
                if (phone != value)
                {
                    phone = value;
                    OnPropertyChanged(nameof(Phone));
                }
            }
        }
        // ................................
        private string address;

        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged(nameof(Address));
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

        private List<int> idlist;
        public List<int> IdList
        {
            get { return idlist; }
            set
            {
                idlist = value;
                OnPropertyChanged(nameof(IdList)); // Notify property change
            }
        }

        private DriverDTO driverDTO;

        public DriverDTO DriverDTO
        {
            get { return driverDTO; }
            set 
            { 
                driverDTO = value; 
                OnPropertyChanged($"{nameof(DriverDTO)}");
            }
        }


        public DriverViewModel()
        {
            ShowRemoveDriverViewCommand = new ViewModelCommand(ExecuteShowRemoveDriverViewCommand);
            ShowAddDriverViewCommand= new ViewModelCommand(ExecuteShowAddDriverViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
            FindCommand = new ViewModelCommand(ExecuteFindCommand);
            RemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand);
            RefreshCommand = new ViewModelCommand(ExecuteRefreshCommand);

            IdList = new List<int>(repository.GetDriverId());
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

        public void ExecuteSearchCommand(object parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                if(result!=null)
                    DriverList.Clear();
                    DriverList.Add(new DriverDTO() { Id = result.Id, Firstname = result.FirstName , Lastname = result.LastName , Address = result.Address , Phone = result.Phone });
                else
                    MessageBox.Show("Driver not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Please mention Id !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ExecuteAddCommand(object parameter)
        {
            if (FirstName != null && LastName != null && Phone != null && Address != null)
            {
                Driver new_class = new Driver() { FirstName = FirstName, LastName = LastName, Phone = Phone, Address = Address };

                repository.Add(new_class);
                repository.SaveChanges();

                inputwindow.Close();
            }
            else
                MessageBox.Show("Please mention all things !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private Driver current;
        public void ExecuteFindCommand(object parameter)
        {
            if (Id != null)
            {
                current = repository.GetById(Convert.ToInt32(Id));
                if (current != null)
                {
                    FirstName = current.FirstName;
                    LastName = current.LastName;
                }
                else
                    MessageBox.Show("Driver not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Please pick an Id !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ExecuteRemoveCommand(object parameter)
        {
            repository.Delete(current);
            repository.SaveChanges();
            IdList = new List<int>(repository.GetRideId());

            FirstName = null;
            LastName = null;
        }

        public void ExecuteUpdateCommand(object parameter)
        {
            Driver update = repository.GetById(DriverDTO.Id);
            repository.Update(update);
            repository.SaveChanges();
        }

        public void ExecuteRefreshCommand(object parameter)
        {
            ObservableCollection<DriverDTO> Temp = new ObservableCollection<DriverDTO>(repository.Drivers());
            if (Temp != null)
            {
                DriverList.Clear();
                for (int i = 0; i < Temp.Count; i++)
                {
                    DriverList.Add(Temp[i]);
                }
            }
            else
                MessageBox.Show("Can not refresh !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
