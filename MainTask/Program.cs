namespace MainTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);


            // Savings
            var savAccounts = new List<Account>();

            savAccounts.Add(new SavingsAccount());
            savAccounts.Add(new SavingsAccount("Superman"));
            savAccounts.Add(new SavingsAccount("Batman", 2000));
            savAccounts.Add(new SavingsAccount("Wonderwoman", 5000, 5.0));

            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            //Checking
           var checAccount = new List<Account>();

            checAccount.Add(new CheckingAccount());
            checAccount.Add(new CheckingAccount("Larry2"));
            checAccount.Add(new CheckingAccount("Moe2", 2000));
            checAccount.Add(new CheckingAccount("Curly2", 5000));

            AccountUtil.Deposit(checAccount, 1000);
            AccountUtil.Withdraw(checAccount, 2000);
            AccountUtil.Withdraw(checAccount, 2000);

            ////// Trust
            List<Account>? trustAccount = new List<Account>();
            trustAccount.Add(new TrustAccount());
            trustAccount.Add(new TrustAccount("Superman2"));
            trustAccount.Add(new TrustAccount("Batman2", 2000));
            trustAccount.Add(new TrustAccount("Wonderwoman2", 5000, 5.0));

            AccountUtil.Deposit(trustAccount, 1000);
            AccountUtil.Deposit(trustAccount, 6000);
            AccountUtil.Withdraw(trustAccount, 2000);
            AccountUtil.Withdraw(trustAccount, 3000);
            AccountUtil.Withdraw(trustAccount, 500);

            Console.WriteLine();
        }
    }
}

