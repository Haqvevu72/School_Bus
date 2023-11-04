
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class CarAddViewModel:BaseViewModel
    {
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

        // Commands

                    public ICommand AddCommand { get; set; }


        // Constructor

                    public CarAddViewModel()
                    {
                        // Initialize Commands

                        AddCommand = new ViewModelCommand(ExecuteAddCommand);
                    }

        // Action

                    public void ExecuteAddCommand(object parameter) 
                    {
                        MessageBox.Show(DriverId.ToString() + Capacity.ToString() + Number);
                    }

    }
}
