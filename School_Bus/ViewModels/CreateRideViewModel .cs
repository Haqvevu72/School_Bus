
using Context.Repositories.Concrete;
using Entity.Concrete;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class CreateRideViewModel:BaseViewModel
    {
        // Properties

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
             // ................................
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
             // ................................
                private int busid;

                public int BusId
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
             // ................................
                private int passengers;

                public int Passengers
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
             // ................................

        // Commands

                public ICommand AddCommand { get; set; }


        // Constructor

                public CreateRideViewModel()
                {
                    // Initialize Commands

                    AddCommand = new ViewModelCommand(ExecuteAddCommand);
                }

        // Action

                public void ExecuteAddCommand(object parameter)
                {
                    Ride new_class = new Ride() { BusId = BusId , StartPoint = StartPoint , EndPoint = EndPoint , Passengers = Passengers };
                    Repository<Ride> repository = new Repository<Ride>();
                    repository.Add(new_class);
                    repository.SaveChanges();
                }
    }
}
