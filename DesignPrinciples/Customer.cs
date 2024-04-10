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
        public float Incomes { get; set; }
        public float Outcomes { get; set; }
        public float AllowedDebit { get; set; }

        public bool IsDebit()
        {
            return Incomes - Outcomes < 0;
        }
    }
}