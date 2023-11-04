﻿using Context.Repositories.Concrete;
using Entity.Concrete;
using Entity.DTO;
using School_Bus.Views.Student;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

        public StudentViewModel()
        {
            ShowAddStudentViewCommand = new ViewModelCommand(ExecuteShowAddStudentViewCommand);
            ShowRemoveStudentViewCommand = new ViewModelCommand(ExecuteShowRemoveStudentViewCommand);
            SearchCommand = new ViewModelCommand(ExecuteSearchCommand);

            //StudentList = new ObservableCollection<StudentDTO>(repository.Students());
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
    }
}
