using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Student;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class StudentViewModel:BaseViewModel
    {
        public static Window outputwindow;
        public static Window inputwindow;
        public ICommand ShowAddStudentViewCommand { get; }
        public ICommand ShowRemoveStudentViewCommand { get; }
        public ICommand SearchCommand { get; }

        public ICommand AddCommand { get; set; }

        public ICommand FindCommand { get; set; }

        public ICommand RemoveCommand { get; set; }

        Repository<Student> repository = new Repository<Student>();

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


        private ObservableCollection<StudentDTO> studentlist;
        public ObservableCollection<StudentDTO> StudentList
        {
            get { return studentlist; }
            set
            {
                studentlist = value;
                OnPropertyChanged(nameof(StudentList)); // Notify property change
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

        public StudentViewModel()
        {
            ShowAddStudentViewCommand = new ViewModelCommand(ExecuteShowAddStudentViewCommand);
            ShowRemoveStudentViewCommand = new ViewModelCommand(ExecuteShowRemoveStudentViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);
            AddCommand = new ViewModelCommand(ExecuteAddCommand);
            FindCommand = new ViewModelCommand(ExecuteFindCommand);
            RemoveCommand = new ViewModelCommand(ExecuteRemoveCommand);

            StudentList = new ObservableCollection<StudentDTO>(repository.Students());
            IdList = new List<int>(repository.GetStudentId());
        }

        public void ExecuteShowRemoveStudentViewCommand(object? parameter)
        {
            StudentRemoveView outputControl = new StudentRemoveView();
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

        public void ExecuteShowAddStudentViewCommand(object? parameter) 
        {
            StudentAddView outputControl = new StudentAddView();
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

        public void ExecuteSearchCommand(object parameter)
        {
            if (string.IsNullOrEmpty(Id) == false)
            {
                var result = repository.GetById(Convert.ToInt32(Id));
                StudentList.Clear();
                StudentList.Add(new StudentDTO() { Id = result.Id, Firstname=result.FirstName , Lastname=result.LastName,ParentId=result.ParentId,ClassId = result.ClassId ,BusId = result.BusId});
            }
        }

        public void ExecuteAddCommand(object parameter)
        {
            Student new_class = new Student() { FirstName = FirstName, LastName = LastName, ClassId = ClassId , ParentId = ParentId , BusId = BusId };

            repository.Add(new_class);
            repository.SaveChanges();

            StudentList.Add(new StudentDTO() { Id = new_class.Id, Firstname = new_class.FirstName, Lastname = new_class.LastName, ParentId = new_class.ParentId, ClassId = new_class.ClassId, BusId = new_class.BusId });

            inputwindow.Close();
        }

        private Student current;
        public void ExecuteFindCommand(object parameter)
        {
            current = repository.GetById(Convert.ToInt32(Id));

            FirstName = current.FirstName;
            LastName = current.LastName;
        }

        public void ExecuteRemoveCommand(object parameter)
        {
            repository.Delete(current);
            repository.SaveChanges();
            IdList = new List<int>(repository.GetStudentId());

            FirstName =null;
            LastName = null;
        }
    }
}
