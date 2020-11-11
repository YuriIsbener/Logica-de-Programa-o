using System;

namespace Logica_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorUm;
            int valorDois;

            // Aqui vai o código

            Console.WriteLine("Soma de dois números");
            Console.WriteLine("-----------------------");
            Console.Write("Digite o primeiro valor: ");
            valorUm = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            valorDois = int.Parse(Console.ReadLine());

            //Processamento
            int soma = valorUm + valorDois;

            //Exibir

            Console.WriteLine("A Soma de "+valorUm+" + "+valorDois+" = "+soma);

        }
    }
}
