using AbstractFactory.Core.Enums;
using AbstractFactory.Infrastructure;
using DesignPattern.Application.Models;
using DesignPattern.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        private readonly IOrderAbstractFactoryFactory _orderAbstractFactoryFactory;

        public OrdersController(
            IPaymentServiceFactory paymentServiceFactory,
            IOrderAbstractFactoryFactory orderAbstractFactoryFactory
            )
        {
            _paymentServiceFactory = paymentServiceFactory;
            _orderAbstractFactoryFactory = orderAbstractFactoryFactory;
        }

        [HttpPost]
        public IActionResult Post(
            OrderInputModel model,
            [FromServices] OrderAbstractFactory orderAbstractFactory
            )
        {
            IOrderAbstractFactory factory = _orderAbstractFactoryFactory.GetOrderAbstractFactory(orderAbstractFactory);

            var resultPayment = factory
                .GetPaymentService(model.PaymentInfo.PaymentMethod)
                .Process(model);

            factory
                .GetDeliveryService()
                .Deliver(model);

            return NoContent();
        }
    }
}