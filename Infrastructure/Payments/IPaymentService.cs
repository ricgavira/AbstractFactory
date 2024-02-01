using DesignPattern.Application.Models;

namespace DesignPattern.Infrastructure.Payments
{
    public interface IPaymentService
    {
        object Process(OrderInputModel model);
    }
}
