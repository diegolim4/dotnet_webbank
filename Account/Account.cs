namespace WebBank
{
    public class Account
    {
        //Atributos da conta
        private AccountType AccountType { get; set; }

        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }

        //Método construtor        
        public Account(AccountType accountType, double balance, double credit, string name)
        {
            this.AccountType = accountType;
            this.Balance = balance;
            this.Credit = credit;
            this.Name = name;
        }

    }
}