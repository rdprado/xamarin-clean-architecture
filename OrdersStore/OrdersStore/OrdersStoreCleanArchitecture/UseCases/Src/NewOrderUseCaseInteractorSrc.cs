using
using OrdersStore.InterfaceAdapters.Gateways;

namespace OrdersStore.UseCases.Src
{
    class NewOrderUseCaseInteractorSrc : NewOrderUseCaseInteractorInput
    {
        OrdersDataStore ordersStore;
        NewOrderUseCaseInteractorOutput interactorOutput;

        public NewOrderUseCaseInteractorSrc(
            NewOrderUseCaseInteractorOutput interactorOutput,
            OrdersDataStore ordersStore)
        {
            this.interactorOutput = interactorOutput;
            this.ordersStore = ordersStore;
        }

        public async Task NewOrder(NewOrderRequestModel reqModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
