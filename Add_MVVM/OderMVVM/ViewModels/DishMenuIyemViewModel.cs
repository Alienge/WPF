using OderMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderMVVM.ViewModels
{
    //这个需要和界面进行交互 因此需要继承NotificationObject
    // viewmodel  有一个model 
    class DishMenuIyemViewModel:NotificationObject
    {
        public Dish Dish { get; set; }
        private bool isSelected;
        public bool IsSelected {
            get { return isSelected; }
            set { isSelected = value;this.RaisePropertyChange("IsSelected"); }
        }
    }
}
