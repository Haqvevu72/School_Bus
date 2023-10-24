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

        // --> Constructor

        public MainViewModel()
        {
            // --> Initialize Commands
            ShowParentViewCommand = new ViewModelCommand(ExecuteShowParentViewCommand);
            ShowCreateRideCommand = new ViewModelCommand(ExecuteShowCreateRideViewCommand);

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
    }
}
