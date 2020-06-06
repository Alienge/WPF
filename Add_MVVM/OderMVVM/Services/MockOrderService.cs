using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderMVVM.Services
{
    class MockOrderService : PlaceOrder
    {
        public void PlaceOrder(List<string> dishes)
        {
            //throw new NotImplementedException();
            //真实实现中，可能是通过网络，短信或者回传数据库里
            string SaveFile = System.IO.Path.Combine(Environment.CurrentDirectory, @"oder.txt");

            System.IO.File.WriteAllLines(SaveFile, dishes.ToArray());
        }
    }
}
