using AbstractFactory.Infrastructure.Deliveries;
using DesignPattern.Enums;
using DesignPattern.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure
{
    public interface IOrderAbstractFactory
    {
        IPaymentService GetPaymentService(PaymentMethod paymentMethod);
        IDeliveryService GetDeliveryService();
    }
}
