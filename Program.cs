using System;

namespace ExercicioBanco {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Entre com o nome do Titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o numero da Conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o numero da Agencia: ");
            int agencia = int.Parse(Console.ReadLine());
            double saldo = 0;
            Console.WriteLine("Haverá deposito inicial (s - sim ou n - não)");
            string d = Console.ReadLine();

            while (d.Contains('s') != true) {
                if (d.Contains('n') == true) {
                    break;
                }
                Console.WriteLine("Digite s - sim ou n - não");
                d = Console.ReadLine();
            }
                       
            if (d.Contains('s') == true || d.Contains('S') == true) {
                Console.WriteLine("Entre com o deposito inicial: ");
                saldo = double.Parse(Console.ReadLine());

            }

            ContaBanco c = new ContaBanco(nome, conta, agencia, saldo);
            Console.WriteLine("Dados da Conta: " + c);

            Console.WriteLine("Entre com um valor para Deposito: ");
            c.Deposito = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados Atualizados:\n " + c);

            Console.WriteLine("Entre com o valor do saque: ");
            c.Saque = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados Atualizados:\n " + c);

            Console.WriteLine("uma alteração qualquer blz");
            Console.WriteLine("Pronto");

        }
    }
}
