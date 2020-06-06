using OderMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OderMVVM.Services
{
    interface IDataServices
    {
        List<Dish> GetAllDishes();
    }
}
