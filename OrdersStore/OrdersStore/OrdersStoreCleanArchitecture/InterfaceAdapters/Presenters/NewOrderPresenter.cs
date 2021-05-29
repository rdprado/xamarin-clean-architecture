using OrdersStore.UseCases;
using OrdersStore.ViewModels;

namespace OrdersStore.InterfaceAdapters.Presenters
{
    public class NewOrderPresenter : NewOrderUseCaseInteractorOutput
    {
        object updateViewModelLock;

        NewItemViewModel viewModel;
        public NewOrderPresenter(NewItemViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public void Save()
        {
            // The lock is needed because the view uses a single instance of the
            // view model and we don't want to be updating it concurrently.
            // We want to synchronize complete view model updates, one at a time.
            // For instance if the viewmodel has three fields, thread 1 may have
            // updated two fields and thread 2 may have updated tha last field.

            // There are several other approaches like:
            // - Creting a new viewmodel every time and changing the view data context.
            // - Creating a viewmodel everytime that is not binded to the view and
            // a view method to refresh itself when an update/refresh method is called.

            lock (updateViewModelLock)
            {
                
            }
        }
    }
}
