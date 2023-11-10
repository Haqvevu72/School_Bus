using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using School_Bus.Views;
using System.Collections.ObjectModel;
using Entity.Concrete;
using Context.Contexts;
using Entity.DTO;
using Context.Repositories.Concrete;
using System.Threading;
using System.Collections.Specialized;
using System.Windows.Controls;
using FontAwesome.Sharp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace School_Bus.ViewModels
{
    public class ClassViewModel : BaseViewModel
    {
        public Repository<Class> repository = new Repository<Class>();
        public ICommand ShowRemoveClassViewCommand { get; }
        public ICommand ShowAddClassViewCommand { get; }
        public ICommand SearchCommand { get; }
        public ICommand FindCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; set; }
        public ICommand RefreshCommand { get; set; }
        

        public static Window inputWindow;
        public static Window outputWindow;


        public ObservableCollection<ClassDTO> ClassList { get; set; }


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

        private ClassDTO classDTO;

        public ClassDTO ClassDTO
        {
            get { return classDTO; }
            set
            {
                if (classDTO != value)
                {
                    classDTO = value;
                    OnPropertyChanged(nameof(ClassDTO));
                }
            }
        }

        public ClassViewModel()
        {
            ShowRemoveClassViewCommand = new ViewModelCommand(ExecuteShowRemoveClassViewCommand);
            ShowAddClassViewCommand = new ViewModelCommand(ExecuteShowAddClassViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
            FindCommand = new ViewModelCommand(ExecuteFindCommand);
            RemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand);
            RefreshCommand = new ViewModelCommand(ExecuteRefreshCommand);

            IdList = new List<int>(repository.GetClassId());
            ClassList = repository.Classes();
        }

        public void ExecuteShowRemoveClassViewCommand(object parameter)
        {
            ClassRemoveView outputControl = new ClassRemoveView();
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

        public void ExecuteShowAddClassViewCommand(object? parameter)
        {
            ClassAddView inputControl = new ClassAddView();
            inputWindow = new Window()
            {
                Content = inputControl,
                Height = 300,
                Width = 400,


                WindowStyle = WindowStyle.None,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                ResizeMode = ResizeMode.NoResize

            };

            inputControl.MouseDown += (sender, e) =>
            {
                if (e.ChangedButton == MouseButton.Left)
                {
                    inputWindow.DragMove();
                }
            };
            inputWindow.ShowDialog();
        }

        public void ExecuteSearchCommand(object? parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                if(result!=null)
                    ClassList.Clear();
                    ClassList.Add(new ClassDTO() { Id = result.Id, Name = result.Name });
                else
                    MessageBox.Show("Class not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            { 
                MessageBox.Show("Please mention Id !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning); 
            }
        }

        public void ExecuteAddCommand(object parameter)
        {

            if (ClassName != null)
            {
                Class new_class = new Class() { Name = ClassName };

                repository.Add(new_class);
                repository.SaveChanges();

                inputWindow.Close();
            }
            else
            {
                MessageBox.Show("Please write class name!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        private Class current;
        public void ExecuteFindCommand(object parameter)
        {
            if (Id != null)
            {
                current = repository.GetById(Convert.ToInt32(Id));

                if (current != null)
                    ClassName = current.Name;
                else
                    MessageBox.Show("Class not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
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
                IdList = new List<int>(repository.GetClassId());

                ClassName = null;
            }
            else
                MessageBox.Show("Class not found !", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public void ExecuteUpdateCommand(object parameter)
        { 
            Class update = repository.GetById(ClassDTO.Id);
            repository.Update(update);
            repository.SaveChanges();
        }

        public void ExecuteRefreshCommand(object parameter) 
        {
            ObservableCollection<ClassDTO> Temp = new ObservableCollection<ClassDTO>(repository.Classes());
            if (Temp != null)
            {
                ClassList.Clear();
                for (int i = 0; i < Temp.Count; i++)
                {
                    ClassList.Add(Temp[i]);
                }
            }
            else
                MessageBox.Show("Can not refresh!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        }
    }
}
