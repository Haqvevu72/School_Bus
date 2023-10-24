

using System;
using System.Windows.Input;

namespace School_Bus.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        // --> Fields
        
        private readonly Action<object> _execute;
        private readonly Predicate<object> _canexecute;

        // --> Constructors
        
        public ViewModelCommand(Action<object> _Execute)
        {
            _execute = _Execute;
            _canexecute = null;
        }

        public ViewModelCommand(Action<object> _Execute,Predicate<object> _canExecute)
        {
            _execute = _Execute;
            _canexecute = _canExecute;
        }

        // --> Event

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canexecute == null ? true : _canexecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
