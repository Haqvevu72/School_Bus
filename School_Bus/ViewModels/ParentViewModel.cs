using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Parent;
using System;
using System.Collections.Generic;
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
        public ICommand FindCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RefreshCommand { get; set; }


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

        private List<int> idlist;
        public List<int> IdList
        {
            get { return idlist; }
            set
            {
                idlist = value;
                OnPropertyChanged(nameof(IdList)); // Notify property change
            }
        }

        private ParentDTO parentDTO;

        public ParentDTO ParentDTO
        {
            get { return parentDTO; }
            set 
            { 
                parentDTO = value; 
                OnPropertyChanged(nameof(ParentDTO));
            }
        }


        public ParentViewModel()
        {
            ShowRemoveParentViewCommand = new ViewModelCommand(ExecuteShowRemoveParentViewCommand);
            ShowAddParentViewCommand = new ViewModelCommand(ExecuteShowAddParentViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
            FindCommand = new ViewModelCommand(ExecuteFindCommand);
            RemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand);
            RefreshCommand = new ViewModelCommand(ExecuteRefreshCommand);

            ParentList = new ObservableCollection<ParentDTO>(repository.Parents());
            IdList = IdList = new List<int>(repository.GetParentId());
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
                if (result != null)
                {
                    ParentList.Clear();
                    ParentList.Add(new ParentDTO() { Id = result.Id, Firstname = result.FirstName, Lastname = result.LastName, Phone = result.Phone, Address = result.Address });
                }
                else
                    MessageBox.Show("Parent not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Please mention Id !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ExecuteAddCommand(object parameter)
        {
            try
            {
                if (FirstName != null && LastName != null && Phone != null && Address != null)
                {
                    Parent new_class = new Parent() { FirstName = FirstName, LastName = LastName, Phone = Phone, Address = Address };

                    repository.Add(new_class);
                    repository.SaveChanges();

                    ParentList.Add(new ParentDTO() { Id = new_class.Id, Firstname = new_class.FirstName, Lastname = new_class.LastName, Address = new_class.Address, Phone = new_class.Phone });

                    inputwindow.Close();
                }
                else
                    MessageBox.Show("Please mention all things !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            finally 
            {
                inputwindow.Close();
            }
        }

        private Parent current;
        public void ExecuteFindCommand(object parameter)
        {
            if (Id != null)
            {
                current = repository.GetById(Convert.ToInt32(Id));
                if (current != null)
                {
                    FirstName = current.FirstName;
                    LastName = current.LastName;
                }
                else
                    MessageBox.Show("Parent not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Please pick an Id !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        public void ExecuteRemoveCommand(object parameter)
        {
            if (current != null)
            {
                repository.Delete(current);
                repository.SaveChanges();
                IdList = new List<int>(repository.GetParentId());

                FirstName = null;
                LastName = null;
            }
            else
                MessageBox.Show("Please choose Parent", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public void ExecuteUpdateCommand(object parameter)
        {
            Parent update = repository.GetById(ParentDTO.Id);
            repository.Update(update);
            repository.SaveChanges();
        }

        public void ExecuteRefreshCommand(object parameter)
        {
            ObservableCollection<ParentDTO> Temp = new ObservableCollection<ParentDTO>(repository.Parents());
            if (Temp != null)
            {
                ParentList.Clear();
                for (int i = 0; i < Temp.Count; i++)
                {
                    ParentList.Add(Temp[i]);
                }
            }
            else
                MessageBox.Show("Can not refresh !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
