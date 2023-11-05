using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Parent;
using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class ParentViewModel:BaseViewModel
    {
        Repository<Parent> repository = new Repository<Parent>();
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowRemoveParentViewCommand { get; }
        public ICommand ShowAddParentViewCommand { get; }
        public ICommand SearchCommand { get; set; }

        public ICommand AddCommand { get; set; }


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

        private ObservableCollection<ParentDTO> parentlist;
        public ObservableCollection<ParentDTO> ParentList
        {
            get { return parentlist; }
            set
            {
                parentlist = value;
                OnPropertyChanged(nameof(ParentList)); // Notify property change
            }
        }

        public ParentViewModel()
        {
            ShowRemoveParentViewCommand = new ViewModelCommand(ExecuteShowRemoveParentViewCommand);
            ShowAddParentViewCommand = new ViewModelCommand(ExecuteShowAddParentViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);

            ParentList = new ObservableCollection<ParentDTO>(repository.Parents());
        }

        public void ExecuteShowRemoveParentViewCommand(object? parameter)
        {
            ParentRemoveView outputControl = new ParentRemoveView();
            outputwindow = new Window
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
                    outputwindow.DragMove();
                }
            };
            outputwindow.ShowDialog();
        }

        public void ExecuteShowAddParentViewCommand(object? parameter)
        {
            ParentAddView outputControl = new ParentAddView();
            inputwindow = new Window
            {
                Content = outputControl,
                Height = 430,
                Width = 700,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            outputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    inputwindow.DragMove();
                }
            };
            inputwindow.ShowDialog();
        }

        public void ExecuteSearchCommand(object? parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                ParentList.Clear();
                ParentList.Add(new ParentDTO() { Id = result.Id, Firstname = result.FirstName , Lastname = result.LastName , Phone = result.Phone , Address = result.Address });
            }
        }

        public void ExecuteAddCommand(object parameter)
        {
            Parent new_class = new Parent() { FirstName = FirstName, LastName = LastName, Phone = Phone, Address = Address };

            repository.Add(new_class);
            repository.SaveChanges();

            ParentList.Add(new ParentDTO() { Id = new_class.Id, Firstname = new_class.FirstName, Lastname = new_class.LastName, Address = new_class.Address, Phone = new_class.Phone });

            inputwindow.Close();
        }
        
    }
}
