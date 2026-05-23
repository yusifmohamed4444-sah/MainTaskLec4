namespace MainTask
{

    public class TrustAccount: SavingsAccount
    {
        private const double Bonus = 50.0;
        public TrustAccount(string name = "unnamed saveing Account", double balance = 0.0, double interestRate = 0.0) : base(name, balance,interestRate)
        {
        }

        public override bool Deposit(double amount)
        {
            if(amount >= 5000)
            {
                amount += Bonus;
            }

            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if(amount < Balance * 0.2)
            {
                return false;
            }

            return base.Withdraw(amount);
        }

        public override string ToString()
        {
            return $"[Trust Account: {Name}, Balance: {Balance}, Interest: {InterestRate}%]";
        }

    }

    
}