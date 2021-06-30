using System;
using System.Collections.Generic;

namespace WebBank
{
    class Program
    {
        static List<Account> listContas = new List<Account>();
        static void Main(string[] args)
        {
            string optionUser = OptionUser();

            while (optionUser.ToUpper() != "X")
            {
                switch (optionUser)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirContas();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                optionUser = OptionUser();
            }
            Console.WriteLine("Obrigado por utilizar nosso serviços");
            Console.ReadLine();
        }

        private static void InserirContas()
        {
            Console.WriteLine("Inserir nova conta");

            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica: ");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o crédito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountType: (AccountType)entradaTipoConta,
                                        balance: entradaSaldo,
                                        credit: entradaCredito,
                                        name: entradaNome);
            listContas.Add(newAccount);
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Deposit(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].GetMoney(valorSaque);
        }

        private static string OptionUser()
        {
            Console.WriteLine();
            Console.WriteLine("Seja bem vindo ao My Bank");
            Console.WriteLine("Informe a Opção Desejada: ");

            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine("X- Sair");

            string OptionUser = Console.ReadLine().ToUpper();
            Console.WriteLine("________________________");
            return OptionUser;
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transfer(valorTransferencia, listContas[indiceContaDestino]);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Account account = listContas[i];
                Console.Write("#{0} - ", i);
                Console.WriteLine(account);
            }
        }
    }
}
