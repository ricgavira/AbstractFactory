using AbstractFactory.Infrastructure.Deliveries;
using DesignPattern.Enums;
using DesignPattern.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure
{
    public class NationalOrderAbstractFactory : IOrderAbstractFactory
    {
        private readonly NationalDeliveryService _nationalDeliveryService;
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public NationalOrderAbstractFactory(
            NationalDeliveryService nationalDeliveryService,
            IPaymentServiceFactory paymentServiceFactory
        )
        {
            _nationalDeliveryService = nationalDeliveryService;
            _paymentServiceFactory = paymentServiceFactory;
        }

        public IDeliveryService GetDeliveryService()
        {
            return _nationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
        {
            return _paymentServiceFactory.GetService(paymentMethod);
        }
    }
}
