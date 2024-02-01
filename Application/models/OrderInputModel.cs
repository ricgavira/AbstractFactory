using DesignPattern.Controllers;

namespace DesignPattern.Application.Models
{
    public class OrderInputModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Boolean IsInternational { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
    }
}