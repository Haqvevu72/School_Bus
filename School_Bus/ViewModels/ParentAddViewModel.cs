
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class ParentAddViewModel:BaseViewModel
    {
        // Properties

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
             // ................................

        // Commands

                public ICommand AddCommand { get; set; }


        // Constructor

                public ParentAddViewModel()
                {
                    // Initialize Commands

                    AddCommand = new ViewModelCommand(ExecuteAddCommand);
                }

        // Action

                public void ExecuteAddCommand(object parameter)
                {
                    MessageBox.Show(FirstName+'\n'+LastName+'\n'+Phone+'\n'+Address);
                }
    }
}
