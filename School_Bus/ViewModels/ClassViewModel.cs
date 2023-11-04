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

namespace School_Bus.ViewModels
{
    public class ClassViewModel:BaseViewModel
    {
        public Repository<Class> repository = new Repository<Class>();
        public ICommand ShowRemoveClassViewCommand { get; }
        public ICommand ShowAddClassViewCommand { get; }
        public ICommand SearchCommand { get; }

        public static Window inputWindow;
        public static Window outputWindow;

        private ObservableCollection<ClassDTO> classlist;
        public ObservableCollection<ClassDTO> ClassList
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


        public ClassViewModel()
        {
            ShowRemoveClassViewCommand = new ViewModelCommand(ExecuteShowRemoveClassViewCommand);
            ShowAddClassViewCommand = new ViewModelCommand(ExecuteShowAddClassViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);


            //ClassList = new ObservableCollection<ClassDTO>(repository.Classes());
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
    }
}
