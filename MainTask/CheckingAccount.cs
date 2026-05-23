namespace MainTask
{

    public class CheckingAccount : Account
    {
        private const double Fee = 1.50;


        public CheckingAccount(string name = "unnamed checking Account", double balance = 0.0) : base(name , balance)
        {

        }

        public override bool Withdraw(double amount)
        {

            amount += Fee;

            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"[Checking Account: {Name}, Balance: {Balance}]";
        }


    }

    
}