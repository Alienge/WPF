using Add_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_MVVM.ViewModels
{
    class DataChageViewModel
    {
        public Data Data1
        {
            get;
            set ; 
        }
        /*
        private Data data1; 
        
        public Data Data1{
            get { return data1;}
            set { data1 = value;this.RaisePropertyChange("Data1"); }
        }
        */
        public DataChageViewModel()
        {
            Data1 = new Data();
        }

    }
}
