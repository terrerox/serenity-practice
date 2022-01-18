using Serenity.Navigation;
using MyPages = practice1.Customer.Pages;

[assembly: NavigationLink(int.MaxValue, "Customer/Orders", typeof(MyPages.OrdersController), icon: null)]
