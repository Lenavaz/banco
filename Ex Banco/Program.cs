using System.Globalization;

namespace Ex_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cb;

            Console.Write("Introduza o número de conta: ");
            int numero = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Introduza o nome do titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Deseja fazer depósito inicial? s/n ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Introduza o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                cb = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();    
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);
            Console.WriteLine();

            Console.WriteLine("Valor a depositar: ");
            double quantia = double.Parse(Console.ReadLine());
            cb.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);
            Console.WriteLine();
            
            Console.WriteLine("Valor que pretende levantar: ");
            quantia = double.Parse(Console.ReadLine());
            cb.Levantamento(quantia);
            Console.WriteLine("Dados da conta atualizados: ");

        
            Console.WriteLine(cb);
        }

        
            






        
    }
}