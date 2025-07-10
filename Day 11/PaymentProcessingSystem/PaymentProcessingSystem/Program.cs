namespace PaymentProcessingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Upi upi = new Upi("youbrajsingh@okicici");
            upi.ShowBalance();
            //upi.DoPayment();
            //upi.ShowBalance();

            CreditCard cc = new CreditCard("1234567891234456","10/02/2025");
            cc.ShowBalance();
            //cc.DoPayment();
            //cc.ShowBalance();

            Paypal pp = new Paypal("1234567891236");
            pp.ShowBalance();
            pp.DoPayment();
            pp.ShowBalance();
        }
    }
}
