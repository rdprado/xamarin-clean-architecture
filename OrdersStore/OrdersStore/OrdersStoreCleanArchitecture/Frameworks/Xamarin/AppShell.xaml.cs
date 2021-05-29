using OrdersStore.ViewModels;
using OrdersStore.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OrdersStore
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewOrderPage), typeof(NewOrderPage));
        }

        protected override void OnNavigated(ShellNavigatedEventArgs args)
        {
            var state = args.Current.Location.AbsoluteUri;

            Console.WriteLine(state);
        }

    }
}
