namespace MainTask
{

    public class SavingsAccount : Account
    {
        public SavingsAccount(string name = "unnamed saveing Account", double balance = 0.0, double interestRate= 0.0) : base (name,balance)
        {
            InterestRate = interestRate;
        }
        public double InterestRate { get; set; }

        public override bool Deposit (double amount)
        {
            amount += amount * (InterestRate / 100);
                return base.Deposit(amount);
        }

        public override string ToString()
        {
            return $"[SavingsAccount : {Name} , Balance : {Balance} , Interest : {InterestRate}]";
        }

    }

    
}