using School_Bus.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace School_Bus.ViewModels
{
    public class RidesViewModel:BaseViewModel
    {
        
        public static Window outputWindow;

        public ICommand ShowRemoveRidesViewCommand { get; set; }
        public RidesViewModel()
        {
            ShowRemoveRidesViewCommand = new ViewModelCommand(ExecuteShowRemoveRidesViewCommand);
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
