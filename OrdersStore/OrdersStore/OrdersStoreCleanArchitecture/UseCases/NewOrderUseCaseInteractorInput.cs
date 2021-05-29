using System.Threading.Tasks;

namespace OrdersStore.UseCases
{
    public interface NewOrderUseCaseInteractorInput
    {
        Task NewOrder(NewOrderRequestModel reqModel);
    }

    public interface NewOrderUseCaseInteractorOutput
    {
    }

    public struct NewOrderRequestModel
    {
        public string Description { get; set; }
    }
}
