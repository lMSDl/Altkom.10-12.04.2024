
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
        public float Incomes { get; private set; }
        public float Outcomes { get; private set; }
        public float AllowedDebit { get; set; }

        public bool Charge(float amount)
        {
            if (GetBalance() + AllowedDebit < amount)
                return false;

            Outcomes += amount;
            return true;
        }
        public void Fund(float amount)
        {
            Incomes += amount;
        }

        private float GetBalance()
        {
            return Incomes - Outcomes;
        }
    }
}