namespace Altkom._10_12._04._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool Charge(int id, float amount)
        {
            Customer? customer = FindById(id);
            if (customer == null)
                return false;

            if (GetBalance(id) + customer.AllowedDebit < amount)
                return false;

            customer.Outcomes += amount;
            return true;
        }

        private Customer? FindById(int id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public void Fund(int id, float amount)
        {
            var customer = FindById(id);
            if (customer == null)
                return;
            customer.Incomes += amount;
        }

        public float? GetBalance(int id)
        {
            var customer = FindById(id);
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
