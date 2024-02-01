using DesignPattern.Application.Models;

namespace DesignPattern.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public object Process(OrderInputModel model)
        {
            return "Dados do boleto";
        }
    }
}
