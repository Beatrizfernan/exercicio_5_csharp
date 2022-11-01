using System;
using System.Globalization;

namespace exercicio5_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1:");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet[0]);
            int peças1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite código de uma peça 2, o número de peças 2, o valor unitário de cada peça 2:");
            string[] vet1 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet1[0]);
            int peças2 = int.Parse(vet1[1]);
            double valor2 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            double resultado = peças1 * valor1 + peças2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$" +resultado, CultureInfo.InvariantCulture);
        }
    }
}
