using OrdersStore.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace OrdersStore.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new OrderDetailViewModel();
        }
    }
}