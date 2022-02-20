using System;
using System.Globalization;


namespace ProjetoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da Conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular ca conta:");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial?(s/n)");
            char depositoInicial = char.Parse(Console.ReadLine());
            conta = new Conta(numero, titular);

            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial:");
                double vIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, vIni);
                
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para deposito:");
            double vDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados!");
            conta.Deposito(vDep);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para Saque:");
            double vSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados da conta atualizados!");
            conta.Saque(vSaque);
            Console.WriteLine(conta);


        }
    }
}
