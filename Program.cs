using System;

namespace WebBank
{
    class Program
    {
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
                        TranferirContas();
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
                        throw new ArgumentOutOfRangeException()
                }
                optionUser = OptionUser();
            }
            Console.WriteLine("Obrigado por utilizar nosso serviços");
            Console.ReadLine();
        }

        private static string OptionUser()
        {
            Console.WriteLine();
            Console.WriteLine("Seja bem vindo ao my bank");
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Nova Conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar a Tela");
            Console.WriteLine("X- Sair");

            string OptionUser = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OptionUser;
        }

    }
}
