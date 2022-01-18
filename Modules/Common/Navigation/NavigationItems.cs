using Serenity.Navigation;
using Administration = practice1.Administration.Pages;
using MyPages = practice1.Local.Pages;


[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]
[assembly: NavigationMenu(2000, "Local", icon: "fa-film")]
[assembly: NavigationLink(2100, "Local/Products", typeof(MyPages.ProductsController), icon: null)]
[assembly: NavigationLink(2200, "Local/Orders", typeof(MyPages.OrdersController), icon: null)]
