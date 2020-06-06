using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OderMVVM.Command
{
    class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Func<object, bool> CanExecuteFunc { get; set; }
        public Action<object> ExcuteAction { get; set; }

        public bool CanExecute(object parameter)
        {
            if (CanExecuteFunc == null)
            {
                return true;
            }
            return this.CanExecuteFunc(parameter);
            //throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
            if (this.ExcuteAction == null)
            {
                return;
            }
            this.ExcuteAction(parameter);
        }


    }
}
