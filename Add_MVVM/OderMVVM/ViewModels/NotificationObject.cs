using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderMVVM.ViewModels
{
    class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
