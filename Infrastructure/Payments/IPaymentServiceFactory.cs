using DesignPattern.Enums;

namespace DesignPattern.Infrastructure.Payments
{
    public interface IPaymentServiceFactory
    {
        IPaymentService GetService(PaymentMethod paymentMethod);
    }
}
