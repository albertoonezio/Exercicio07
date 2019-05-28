using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sucessor, antecessor = 0;
            //Recebe os dados
            Console.Write("Digite um Número: ");
            numero = int.Parse(Console.ReadLine());
            //Processa
            sucessor = numero + 1;
            antecessor = numero - 1;
            //Imprime
            Console.WriteLine("Sucessor do Número é: {0}", sucessor);
            Console.WriteLine("Antecessor do Número é: {0}", antecessor);
        }
    }
}
