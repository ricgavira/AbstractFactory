using DesignPattern.Application.Models;

namespace DesignPattern.Infrastructure.Payments
{
    public class CreditCardService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Transação aprovada";
        }
    }
}
