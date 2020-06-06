using OderMVVM.Command;
using OderMVVM.Models;
using OderMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OderMVVM.ViewModels
{
    //餐馆 作为数据属性，另外还需要dish+选中
    //每道菜还有一个viewmodel  这个是根据每个人是否选中来对应
    class MainWindowsViewModel:NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set; }
        private int count;
        public int Count {
            get { return count; }
            set { count = value;this.RaisePropertyChange("Count"); }
        }

        private Restaurant restaurant;
        public Restaurant Restaurant {
            get { return restaurant; }
            set { restaurant = value;this.RaisePropertyChange("Restaurant"); }
        }
        private List<DishMenuIyemViewModel> dishMenu;
        public List<DishMenuIyemViewModel> DishMenu {
            get { return dishMenu; }
            set { dishMenu = value;this.RaisePropertyChange("DishMenu"); }
        }
        public MainWindowsViewModel()
        {
            this.LoadRestaurant();
            this.LoadDishMenu();
            this.PlaceOrderCommand = new DelegateCommand();
            this.PlaceOrderCommand.ExcuteAction = this.PlaceOrderCommandExecute;
            this.SelectMenuItemCommand = new DelegateCommand();
            this.SelectMenuItemCommand.ExcuteAction = this.SelectMenuItemExecute;
        }

        private void LoadRestaurant()
        {
            this.Restaurant = new Restaurant();
            this.Restaurant.Name = "Crazy 大象";
            this.Restaurant.Address = "北京市";
            this.Restaurant.Phone = "152167888999";

        }
        private void LoadDishMenu()
        {
            this.DishMenu = new List<DishMenuIyemViewModel>();
            XmlDataService ds = new XmlDataService();
            var dishes = ds.GetAllDishes();
            foreach (var dish in dishes)
            {
                DishMenuIyemViewModel item = new DishMenuIyemViewModel();
                item.Dish = dish;
                this.dishMenu.Add(item);
            }
        }
        private void PlaceOrderCommandExecute(object parameter)
        {
            var selectdDishes = this.DishMenu.Where(i => i.IsSelected == true).Select(i => i.Dish.Name).ToList();
            PlaceOrder orderService = new MockOrderService();
            orderService.PlaceOrder(selectdDishes);
            MessageBox.Show("订餐成功");
        }
        private void SelectMenuItemExecute(object parameter)
        {
            this.Count = this.DishMenu.Count(i => i.IsSelected == true);
        }
    }
}
