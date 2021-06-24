using System;

namespace WebBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(AccountType.PessoaFisica, 0, 0, "Diego Lima");
            Console.WriteLine(myAccount.ToString());
        }
    }
}
