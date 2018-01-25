using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TomCafe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<MenuItem> SideMenu = new List<MenuItem>();
        List<MenuItem> ValueMealMenu = new List<MenuItem>();
        List<MenuItem> BeverageMenu = new List<MenuItem>();
        List<MenuItem> BundleMenu = new List<MenuItem>();

        Meal meal;
        enum Meal
        {
            ValueMeal, Beverage, Bundle, Side
        };

        public MainPage()
        {
            this.InitializeComponent();
            InitData();
           
            //*My first project*//
        }

        void InitData()
        {
            Side s1 = new Side("Hash brown", 2.10);
            Side s2 = new Side("Truffle fries", 3.70);
            Side s3 = new Side("Calamari", 3.40);
            Side s4 = new Side("Caesar salad", 4.30);
            MenuItem sm1 = new MenuItem(s1.Name, s1.Price);
            sm1.ProductList.Add(s1);
            MenuItem sm2 = new MenuItem(s2.Name, s2.Price);
            sm2.ProductList.Add(s2);
            MenuItem sm3 = new MenuItem(s3.Name, s3.Price);
            sm2.ProductList.Add(s3);
            MenuItem sm4 = new MenuItem(s4.Name, s4.Price);
            sm2.ProductList.Add(s4);

            SideMenu.Add(sm1);
            SideMenu.Add(sm2);
            SideMenu.Add(sm3);
            SideMenu.Add(sm4);

            DateTime Today = DateTime.Now;

            DateTime startTime = new DateTime(Today.Year, Today.Month, Today.Day, 0, 0, 0);
            DateTime endTime = new DateTime(Today.Year, Today.Month, Today.Day, 0, 0, 0);

            ValueMeal v1 = new ValueMeal("HotCake & sausage", 6.90, startTime, endTime);
            MenuItem vm1 = new MenuItem(v1.Name, v1.Price);

            vm1.ProductList.Add(v1);
            ValueMealMenu.Add(vm1);

            startTime = new DateTime(Today.Year, Today.Month, Today.Day, 10, 0, 0);
            endTime = new DateTime(Today.Year, Today.Month, Today.Day, 19, 0, 0);

            ValueMeal v2 = new ValueMeal("HamBurger", 7.50, startTime, endTime);
            MenuItem vm2 = new MenuItem(v2.Name, v2.Price);

            vm1.ProductList.Add(v2);
            ValueMealMenu.Add(vm2);

            startTime = new DateTime(Today.Year, Today.Month, Today.Day);
            endTime = new DateTime(Today.Year, Today.Month, Today.Day);

            ValueMeal v3 = new ValueMeal("Nasi Lemak", 5.40, startTime, endTime);
            MenuItem vm3 = new MenuItem(v3.Name, v3.Price);

            vm1.ProductList.Add(v3);
            ValueMealMenu.Add(vm3);

            startTime = new DateTime(Today.Year, Today.Month, Today.Day, 16, 0, 0);
            endTime = new DateTime(Today.Year, Today.Month, Today.Day, 22, 0, 0);

            ValueMeal v4 = new ValueMeal("Ribeye steak", 10.20, startTime, endTime);
            MenuItem vm4 = new MenuItem(v4.Name, v4.Price);

            vm1.ProductList.Add(v4);
            ValueMealMenu.Add(vm4);

            if (v1.IsAvailable())
            {
                ValueMealMenu.Add(vm1);
            }
            if (v2.IsAvailable())
            {
                ValueMealMenu.Add(vm2);
            }
            if (v3.IsAvailable())
            {
                ValueMealMenu.Add(vm3);
            }
            if (v4.IsAvailable())
            {
                ValueMealMenu.Add(vm4);
            }

            Beverage b1 = new Beverage("Cola", 2.85, 0);
            Beverage b2 = new Beverage("Green Tea", 3.70, 0);
            Beverage b3 = new Beverage("Coffee", 2.70, 0);
            Beverage b4 = new Beverage("Tea", 2.70, 0);
            Beverage b5 = new Beverage("Tom's Root Beer", 9.70, 0); 
            Beverage b6 = new Beverage("Mocktail", 15.90, 0);
          
            MenuItem bm1 = new MenuItem(b1.Name, b1.Price);
            MenuItem bm2 = new MenuItem(b2.Name, b2.Price);
            MenuItem bm3 = new MenuItem(b3.Name, b3.Price);
            MenuItem bm4 = new MenuItem(b4.Name, b4.Price);
            MenuItem bm5 = new MenuItem(b5.Name, b5.Price);
            MenuItem bm6 = new MenuItem(b6.Name, b6.Price);

            BeverageMenu.Add(bm1);
            BeverageMenu.Add(bm2);
            BeverageMenu.Add(bm3);
            BeverageMenu.Add(bm4);
            BeverageMenu.Add(bm5);
            BeverageMenu.Add(bm6);


            MenuItem bfm1 = new MenuItem("Breakfast set", 7.90);
            bfm1.ProductList.Add(v1);
            bfm1.ProductList.Add(s2);
            if(v1.IsAvailable())
            {
                BundleMenu.Add(bfm1);
            }
            BundleMenu.Add(bfm1);
        }

        private void mainsButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null; //refresh
            itemsListView.ItemsSource = ValueMealMenu;
        }

        private void sidesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null; //refresh
            itemsListView.ItemsSource = SideMenu;
        }

        private void beveragesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null; //refresh
            itemsListView.ItemsSource = BeverageMenu;
        }

        private void bundlesButton_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.ItemsSource = null; //refresh
            itemsListView.ItemsSource = BundleMenu;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            OrderItem orderitem = new OrderItem();

            int index = itemsListView.SelectedIndex;

            switch (meal)
            { 
                case Meal.ValueMeal:
                    orderitem.Item = ValueMealMenu[index];
                    break;
                case Meal.Beverage:
                    orderitem.Item = BeverageMenu[index];
                    break;
                case Meal.Bundle:
                    orderitem.Item = BundleMenu[index];
                    break;
                case Meal.Side:
                    orderitem.Item = SideMenu[index];
                    break;
            }

            order.itemList.Add(orderitem);
            cartsListView.ItemsSource = null;
            cartsListView.ItemsSource = order.itemList;
        }

        private void orderButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
 
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
