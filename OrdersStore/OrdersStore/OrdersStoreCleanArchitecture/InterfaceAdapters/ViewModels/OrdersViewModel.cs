//using OrdersStore.Entities; CA change
using OrdersStore.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrdersStore.ViewModels
{
    public class OrdersViewModel : BaseViewModel
    {
        // -------------------------------------------------------
        // CA change
        // In CA View Model and Model/Entity should be decoupled
        //--------------------------------------------------------
        // private Order _selectedItem; 
        private OrderViewModel _selectedItemId;

        public ObservableCollection<OrderViewModel> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        //public Command<Order> ItemTapped { get; }
        public Command<OrderViewModel> ItemTapped { get; }

        public OrdersViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<OrderViewModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //ItemTapped = new Command<Order>(OnItemSelected); CA change
            ItemTapped = new Command<OrderViewModel>(OnItemSelected);

            AddItemCommand = new Command(OnAddItem);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                //var items = await DataStore.GetItemsAsync(true); CA change
                //foreach (var item in items)
                //{
                //    Items.Add(item);
                //}
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public OrderViewModel SelectedItem
        {
            get => _selectedItemId;
            set
            {
                SetProperty(ref _selectedItemId, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(OrderViewModel orderId)
        {
            if (orderId == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(OrderDetailViewModel.ItemId)}={orderId}");
        }

        //async void OnItemSelected(Order item) CA change
        //{
        //    if (item == null)
        //        return;

        //    // This will push the ItemDetailPage onto the navigation stack
        //    await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(OrderDetailViewModel.ItemId)}={item.Id}");
        //}
    }
}