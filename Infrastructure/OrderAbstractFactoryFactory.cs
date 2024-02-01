using AbstractFactory.Core.Enums;

namespace AbstractFactory.Infrastructure
{
    public class OrderAbstractFactoryFactory : IOrderAbstractFactoryFactory
    {
        private readonly NationalOrderAbstractFactory _nationalOrderAbstractFactory;
        private readonly InternationalOrderAbstractFactory _internationalOrderAbstractFactory;

        public OrderAbstractFactoryFactory(
            NationalOrderAbstractFactory nationalOrderAbstractFactory,
            InternationalOrderAbstractFactory internationalOrderAbstractFactory
            )
        {
            _nationalOrderAbstractFactory = nationalOrderAbstractFactory;
            _internationalOrderAbstractFactory = internationalOrderAbstractFactory;
        }

        public IOrderAbstractFactory GetOrderAbstractFactory(OrderAbstractFactory orderAbstractFactory)
        {
            IOrderAbstractFactory abstractFactory;

            switch (orderAbstractFactory)
            {
                case OrderAbstractFactory.National:
                    abstractFactory = _nationalOrderAbstractFactory;
                    break;
                case OrderAbstractFactory.International:
                    abstractFactory = _internationalOrderAbstractFactory;
                    break;
                default:
                    throw new ArgumentException("Inválid Order Factory!");
            }

            return abstractFactory;
        }
    }
}
