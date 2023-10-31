using FontAwesome.Sharp;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        // Fields

        private BaseViewModel _currentChildView;
        private string _caption;
        private IconChar _icon;


        // Properties

        public BaseViewModel CurrentChildView 
        {
            get => _currentChildView;
            set 
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        
        public string Caption 
        {
            get => _caption;
            set
            { 
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        
        public IconChar Icon 
        {
            get => _icon;
            set 
            {
                _icon= value;
                OnPropertyChanged(nameof(Icon));
            } 
        }

        // --> Commands

        public ICommand ShowParentViewCommand { get;}
        public ICommand ShowCreateRideCommand { get;} 
        public ICommand ShowStudentCommand    { get;} 
        public ICommand ShowClassCommand      { get;}
        public ICommand ShowRidesCommand      { get;}
        public ICommand ShowDriverCommand { get; }
        public ICommand ShowCarCommand { get; }
        public ICommand ShowHolidaysCommand { get; }

        // --> Constructor

        public MainViewModel()
        {
            // --> Initialize Commands
            ShowParentViewCommand = new ViewModelCommand(ExecuteShowParentViewCommand);
            ShowCreateRideCommand = new ViewModelCommand(ExecuteShowCreateRideViewCommand);
            ShowStudentCommand = new ViewModelCommand(ExecuteShowStudentViewCommand);
            ShowClassCommand = new ViewModelCommand(ExecuteShowClassViewCommand);
            ShowRidesCommand = new ViewModelCommand(ExecuteShowRidesViewCommand);
            ShowDriverCommand = new ViewModelCommand(ExecuteShowDriverViewCommand);
            ShowCarCommand = new ViewModelCommand(ExecuteShowCarViewCommand);
            ShowHolidaysCommand = new ViewModelCommand(ExecuteShowHolidaysViewCommand);
            // * Default View
            ExecuteShowCreateRideViewCommand(null);

            
        }

        // --> Methods
        public void ExecuteShowParentViewCommand(object? parameter) 
        {
            CurrentChildView = new ParentViewModel();
            Caption = "Parent";
            Icon = IconChar.PeopleGroup;
        }

        public void ExecuteShowCreateRideViewCommand(object? parameter)
        {
            CurrentChildView = new CreateRideViewModel();
            Caption = "Create Ride";
            Icon = IconChar.Road;
        }
        
        public void ExecuteShowStudentViewCommand(object? parameter)
        {
            CurrentChildView = new StudentViewModel();
            Caption = "Student";
            Icon = IconChar.Child;
        }

        public void ExecuteShowClassViewCommand(object? parameter) 
        {
            CurrentChildView = new ClassViewModel();
            Caption = "Class";
            Icon = IconChar.School;
        }

        public void ExecuteShowRidesViewCommand(object? parameter)
        {
            CurrentChildView = new RidesViewModel();
            Caption = "Rides";
            Icon = IconChar.MapLocation;
        }

        public void ExecuteShowDriverViewCommand(object? parameter) 
        {
            CurrentChildView = new DriverViewModel();
            Caption = "Driver";
            Icon = IconChar.DriversLicense;
        }
        
        public void ExecuteShowCarViewCommand(object? parameter) 
        {
            CurrentChildView = new CarViewModel();
            Caption = "Car";
            Icon = IconChar.Bus;
        }
        
        public void ExecuteShowHolidaysViewCommand(object? parameter) 
        {
            CurrentChildView = new HolidaysViewModel();
            Caption = "Holidays";
            Icon = IconChar.BirthdayCake;
        }

    }
}
