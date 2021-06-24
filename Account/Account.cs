using System;

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

        //Método sacar
        public bool GetMoney(double ValuesGet)
        {
            //validar se o saldo é suficiente
            if (this.Balance - ValuesGet < this.Credit * -1)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Credit -= ValuesGet;
            Console.WriteLine("Saldo Atual da conta de {0} é {1}", this.Name, this.Balance);
            return true;
        }

        //método depósito
        public void Deposit(double ValuesDeposit)
        {
            this.Credit += ValuesDeposit;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Name, this.Balance);
        }

        //método tranferir
        public void Transfer(double ValuesTransfer, Account DestinationAccount)
        {
            if (this.GetMoney(ValuesTransfer))
            {
                DestinationAccount.Deposit(ValuesTransfer);
            }
        }
        
        // Método para sobreescrever a classe mãe exibir os dados

        public override string ToString()
        {
            string show = "";
            show += "Tipo de Conta: " + this.AccountType + " | ";
            show += "Nome: " + this.Name + " | ";
            show += "Saldo: " + this.Balance + " | ";
            show += "Crédito: " + this.Credit + " | ";
            return show;
        }

    }
}