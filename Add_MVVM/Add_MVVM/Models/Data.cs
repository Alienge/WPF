using Add_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_MVVM.Models
{
    class Data:NotificationObject
    {
        /*
        public int Input1 { get; set; }
        public int Input2 { get; set; }
        public int Result { get; set; }
        */
        
        private int input1;
        public int Input1{
            get { return input1; }
            set { input1 = value;this.RaisePropertyChange("Input1"); }
        }
        private int input2;
        public int Input2 {
            get { return input2; }
            set { input2 = value; this.RaisePropertyChange("Input2"); }
        }

        private int result;
        public int Result
        {
            get { return result; }
            set { result = value; this.RaisePropertyChange("Result"); }
        }


    }
}
