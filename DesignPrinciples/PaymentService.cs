namespace Altkom._10_12._04._2024.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<Customer> Customers { get; } = new List<Customer> { new Customer(1), new Customer(2), new Customer(3), new Customer(4), new Customer(5) };

        public bool DeleteCustomer(Customer customer)
        {
            return Customers.Remove(customer);
        }

        public Customer? FindByAllowedDebit(float allowedDebit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public bool Charge(int id, float amount)
        {
            var customer = Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
                return false;

            if (customer.Incomes - customer.Outcomes + customer.AllowedDebit < amount)
                return false;

            customer.Outcomes += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            var customer = Customers.Where(x => x.Id == id).SingleOrDefault();
            if (customer == null)
                return;
            customer.Incomes += amount;
        }

        public float? GetBalance(int id)
        {
            var customer = Customers.Where(x => x.Id == id).SingleOrDefault();
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
