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

        public ICommand ShowRemoveRidesViewCommand { get; set; }

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




        public RidesViewModel()
        {
            ShowRemoveRidesViewCommand = new ViewModelCommand(ExecuteShowRemoveRidesViewCommand);
            Repository<Ride> repository = new Repository<Ride>();
            RideList = new ObservableCollection<RideDTO>(repository.Rides());
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
    }
}
