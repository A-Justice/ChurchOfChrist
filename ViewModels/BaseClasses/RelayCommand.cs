using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModels.BaseClasses
{
    public class RelayCommand : ICommand
    {
        Func<object, bool> canExecute;
        Action<object> execute;

        public RelayCommand(Action<object> execute)
        {
            this.execute = execute;
            this.canExecute = _ => { return true; } ;
        }
        public RelayCommand(Action<object> execute,Func<object, bool> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
