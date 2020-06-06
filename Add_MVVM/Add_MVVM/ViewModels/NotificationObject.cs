using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_MVVM.ViewModels
{
     // basic class to notify
    class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;//这是一个事件对象
        //触发该事件
        public void RaisePropertyChange(string propertyname)
        {
            if (this.PropertyChanged != null)
            {
                // notify the model to change the value of propertyname
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
