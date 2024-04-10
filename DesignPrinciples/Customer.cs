
namespace Altkom._10_12._04._2024.DesignPrinciples
{
    public class Customer
    {
        public Customer(int id)
        {
            Id = id;
        }

        public int Id { get; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerRegion { get; set; }

        
        public PaymentAccount Account { get; } = new PaymentAccount();
    }
}