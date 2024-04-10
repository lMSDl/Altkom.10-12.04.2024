namespace Altkom._10_12._04._2024.DesignPrinciples
{
    public class PaymentService
    {

        public bool Charge(PaymentAccount account, float amount)
        {
            return account.Charge(amount);    
        }

        public void Fund(PaymentAccount account, float amount)
        {
            account.Fund(amount);
        }
    }
}
