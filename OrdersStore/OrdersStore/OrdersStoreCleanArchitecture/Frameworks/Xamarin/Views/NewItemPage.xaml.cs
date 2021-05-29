using OrdersStore.Frameworks.DataStoreSrc;
using OrdersStore.InterfaceAdapters.Controllers;
using OrdersStore.InterfaceAdapters.Presenters;
using OrdersStore.UseCases.Src;
using OrdersStore.ViewModels;
using Xamarin.Forms;

namespace OrdersStore.Views
{
    public partial class NewOrderPage : ContentPage
    {
        NewItemViewModel viewModel = new NewItemViewModel();

        public NewOrderPage()
        {
            InitializeComponent();
            BindingContext = viewModel;

            Init();

            // Instead of the click action being binded to the view model, register a
            // callback and call the controller when the event is triggered.
            // In an async application we it is safer not to pass the viewmodel to the
            // controller because the controller could be using the viewmodel while it
            // is being updated by another thread. Instead pass a copy of the view
            // state in the exact time it is required

            btnSave.Clicked += async (s, e)
                => await Controller.NewOrder(new NewOrderController.NewOrderInputs
                {
                    description = viewModel.Description
                });
        }

        private void Init()
        {
            // Since the content page can't have the controller injected
            // create the controller strucutre here temporarily.
            // Move this to a DI container and get the controller already built.

            var store = new OrdersDataStoreInMemory();
            var presenter = new NewOrderPresenter(viewModel);
            var interactor = new NewOrderUseCaseInteractorSrc(presenter, store);
            Controller = new NewOrderController(interactor);
        }

        public NewOrderController Controller {get; set;}
    }
}