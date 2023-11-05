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

namespace School_Bus.ViewModels
{
    public class ClassViewModel : BaseViewModel
    {
        public Repository<Class> repository = new Repository<Class>();
        public ICommand ShowRemoveClassViewCommand { get; }
        public ICommand ShowAddClassViewCommand { get; }
        public ICommand SearchCommand { get; }

        public ICommand AddCommand { get; }

        public static Window inputWindow;
        public static Window outputWindow;

        private List<ClassDTO> classlist;
        public List<ClassDTO> ClassList
        {
            get { return classlist; }
            set
            {
                classlist = value;
                OnPropertyChanged(nameof(ClassList)); // Notify property change
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

        public ClassViewModel()
        {
            ShowRemoveClassViewCommand = new ViewModelCommand(ExecuteShowRemoveClassViewCommand);
            ShowAddClassViewCommand = new ViewModelCommand(ExecuteShowAddClassViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);

            ClassList = new List<ClassDTO>(repository.Classes());
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
                ClassList.Clear();
                ClassList.Add(new ClassDTO() { Id = result.Id, Name = result.Name });
            }
        }

        public void ExecuteAddCommand(object parameter)
        {

            Class new_class = new Class() { Name = ClassName };

            repository.Add(new_class);
            repository.SaveChanges();


            ClassList = new List<ClassDTO>(repository.Classes());

            inputWindow.Close();

        }
    }
}
