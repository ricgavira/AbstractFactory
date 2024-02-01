using AbstractFactory.Core.Enums;

namespace AbstractFactory.Infrastructure
{
    public interface IOrderAbstractFactoryFactory
    {
        IOrderAbstractFactory GetOrderAbstractFactory(OrderAbstractFactory orderAbstractFactory);
    }
}