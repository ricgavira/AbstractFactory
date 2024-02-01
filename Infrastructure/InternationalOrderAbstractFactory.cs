using AbstractFactory.Infrastructure.Deliveries;
using DesignPattern.Enums;
using DesignPattern.Infrastructure.Payments;

namespace AbstractFactory.Infrastructure
{
    public class InternationalOrderAbstractFactory : IOrderAbstractFactory
    {
        private readonly CreditCardService _creditCardService;
        private readonly InternationalDeliveryService _internationalDeliveryService;

        public InternationalOrderAbstractFactory(
                CreditCardService creditCardService,            
                InternationalDeliveryService internationalDeliveryService
            )
        {
            _creditCardService = creditCardService;
            _internationalDeliveryService = internationalDeliveryService;
        }

        public IDeliveryService GetDeliveryService()
        {
            return _internationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
        {
            return _creditCardService;
        }
    }
}
