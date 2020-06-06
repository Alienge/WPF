using Add_MVVM.Commands;
using Add_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Add_MVVM.ViewModels
{
    class AddViewModel:NotificationObject
    {
        
        void add(object parameter)
        {

            DataChange.Data1.Result = DataChange.Data1.Input1 + DataChange.Data1.Input2;
            //this.RaisePropertyChange("DataChange");
            //System.Windows.MessageBox.Show(DataChange.Data1.Result.ToString());
        }
        public DelegateCommand addCommand { get; set; }
        /*
        private DataChageViewModel dataChange;
        public DataChageViewModel DataChange {
            get { return dataChange; }
            set { dataChange = value; this.RaisePropertyChange("DataChange"); }
        }*/
        //Data Data1;
        
        public DataChageViewModel DataChange
        {
            get;set;
        }
        public AddViewModel()
        {
            DataChange = new DataChageViewModel();
            addCommand = new DelegateCommand();
            addCommand.ExecuteAction = add;
        }
        

    }
}
