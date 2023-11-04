

using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class ClassAddViewModel:BaseViewModel
    {
        // Properties

        private string classname;

        public string ClassName
        {
            get { return classname; }
            set
            {
                if (classname != value)
                {
                    classname = value;
                    OnPropertyChanged(nameof(ClassName));
                }
            }
        }

        // Commands
        public ICommand AddCommand { get; }

        public ClassAddViewModel()
        {
            // Initialize Commands
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
        }

        // Action
        public void ExecuteAddCommand(object parameter) 
        {
            MessageBox.Show(ClassName);
        }
    }
}
