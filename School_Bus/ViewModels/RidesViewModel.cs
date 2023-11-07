using School_Bus.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Entity.DTO;
using System.Collections.ObjectModel;
using Context.Repositories.Concrete;
using Entity.Concrete;
using System.Diagnostics;

namespace School_Bus.ViewModels
{
    public class RidesViewModel:BaseViewModel
    {
        
        public static Window outputWindow;

        Repository<Ride> repository = new Repository<Ride>();
        public ICommand ShowRemoveRidesViewCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand FindCommand { get; set; }
        public ICommand AddCommand { get; set; }    
        public ICommand RemoveCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private ObservableCollection<RideDTO> ridelist;
        public ObservableCollection<RideDTO> RideList
        {
            get { return ridelist; }
            set
            {
                ridelist = value;
                OnPropertyChanged(nameof(RideList)); // Notify property change
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

        private string busid;

        public string BusId
        {
            get { return busid; }
            set
            {
                if (busid != value)
                {
                    busid = value;
                    OnPropertyChanged(nameof(BusId));
                }
            }
        }

        private string passengers;

        public string Passengers
        {
            get { return passengers; }
            set
            {
                if (passengers != value)
                {
                    passengers = value;
                    OnPropertyChanged(nameof(Passengers));
                }
            }
        }

        private string startpoint;

        public string StartPoint
        {
            get { return startpoint; }
            set
            {
                if (startpoint != value)
                {
                    startpoint = value;
                    OnPropertyChanged(nameof(StartPoint));
                }
            }
        }

        private string endpoint;

        public string EndPoint
        {
            get { return endpoint; }
            set
            {
                if (endpoint != value)
                {
                    endpoint = value;
                    OnPropertyChanged(nameof(EndPoint));
                }
            }
        }

        private RideDTO rideDTO;

        public RideDTO RideDTO
        {
            get { return rideDTO; }
            set 
            { 
                rideDTO = value; 
                OnPropertyChanged(nameof(RideDTO));
            }
        }



        public RidesViewModel()
        {
            ShowRemoveRidesViewCommand = new ViewModelCommand(ExecuteShowRemoveRidesViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            FindCommand = new ViewModelCommand(ExecuteFindCommand);
            RemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand);

            //RideList = new ObservableCollection<RideDTO>(repository.Rides());
            //IdList = new List<int>(repository.GetRideId());
        }

        public void ExecuteShowRemoveRidesViewCommand(object? parameter)
        {
            RemoveRideView outputControl = new RemoveRideView();
            outputWindow = new Window
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
                    outputWindow.DragMove();
                }
            };
            outputWindow.ShowDialog();
        }

        public void ExecuteSearchCommand(object parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                RideList.Clear();
                RideList.Add(new RideDTO() { Id = result.Id, BusId = result.BusId , StartPoint = result.StartPoint , EndPoint = result.EndPoint , Passengers = result.Passengers});
            }
        }

        private Ride current;
        public void ExecuteFindCommand(object parameter)
        {
            current = repository.GetById(Convert.ToInt32(Id));

            StartPoint = current.StartPoint;
            EndPoint = current.EndPoint;
        }

        public void ExecuteRemoveCommand(object parameter)
        {
            repository.Delete(current);
            repository.SaveChanges();
            IdList = new List<int>(repository.GetRideId());

            StartPoint = null;
            EndPoint = null;
        }
        public void ExecuteAddCommand(object parameter) 
        {
            try
            {
                Ride new_ride = new Ride() { BusId = Convert.ToInt32(BusId), StartPoint = StartPoint, EndPoint = EndPoint, Passengers = Convert.ToInt32(Passengers) };

                repository.Add(new_ride);
                repository.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not add duplicate value", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally 
            {
                BusId = null;
                StartPoint = null;
                EndPoint = null;
                Passengers = null;
            }
        }
        public void ExecuteUpdateCommand(object parameter)
        {
            Ride update = repository.GetById(RideDTO.Id);
            repository.Update(update);
            repository.SaveChanges();
        }
    }
}
