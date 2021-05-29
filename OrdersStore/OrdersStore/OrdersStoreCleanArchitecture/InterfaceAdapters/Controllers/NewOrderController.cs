using OrdersStore.UseCases;
using System.Threading.Tasks;

namespace OrdersStore.InterfaceAdapters.Controllers
{
    public class NewOrderController
    {
        private NewOrderUseCaseInteractorInput interactor;
        public struct NewOrderInputs
        {
            public string description;
        }

        public NewOrderController(NewOrderUseCaseInteractorInput interactor)
        {
            this.interactor = interactor;
        }

        public async Task NewOrder(NewOrderInputs inputs)
        {
            var reqModel = new NewOrderRequestModel
            {
                Description = inputs.description;
            };
            

            await interactor.NewOrder(reqModel);
        }
    }
}
 