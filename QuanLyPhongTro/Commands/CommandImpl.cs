using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyPhongTro.Commands
{
    public class CommandImpl<T> : ICommand
    {
        Action<T> _TaskExecute;
        Func<T,bool> _TaskCanExecute;

        public event EventHandler CanExecuteChanged= delegate{ };

        public CommandImpl(Action<T> TaskExecute,Func<T,bool> TaskCanExecute)
        {
            this._TaskExecute = TaskExecute;
            this._TaskCanExecute = TaskCanExecute;
        }

        public CommandImpl(Action<T> TaskExecute)
        {
            this._TaskExecute = TaskExecute;
        }

        public void RaiseExecuteTask(EventArgs e)
        {
            CanExecuteChanged?.Invoke(this, e);
        }

        public void RaiseExecuteTask()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            if (_TaskCanExecute != null)
            {
                return _TaskCanExecute((T)parameter);
            }
            if (_TaskExecute != null)
            {
                return true;
            }
            return false;
        }

        public void Execute(object parameter)
        {
            if (_TaskExecute != null)
            {
                _TaskExecute((T)parameter);
            }
        }
    }
}
