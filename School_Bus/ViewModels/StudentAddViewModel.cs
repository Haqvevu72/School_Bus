
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class StudentAddViewModel:BaseViewModel
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
                private int classid;

                public int ClassId
                {
                    get { return classid; }
                    set
                    {
                        if (classid != value)
                        {
                            classid = value;
                            OnPropertyChanged(nameof(ClassId));
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
                private int parentid;

                public int ParentId
                {
                    get { return parentid; }
                    set
                    {
                        if (parentid != value)
                        {
                            parentid = value;
                            OnPropertyChanged(nameof(ParentId));
                        }
                    }
                }
             // ................................

        // Commands

                public ICommand AddCommand { get; set; }


        // Constructor

                public StudentAddViewModel()
                {
                    // Initialize Commands

                    AddCommand = new ViewModelCommand(ExecuteAddCommand);
                }

        // Action

                public void ExecuteAddCommand(object parameter)
                {
                    MessageBox.Show(FirstName+'\n'+LastName+'\n'+ClassId+'\n'+BusId+'\n'+ParentId);
                }
    }
}
