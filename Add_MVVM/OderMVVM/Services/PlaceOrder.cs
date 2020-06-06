using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//把订单写文件中去
namespace OderMVVM.Services
{
    interface PlaceOrder
    {
        void PlaceOrder(List<string> dishes);
    }
}
