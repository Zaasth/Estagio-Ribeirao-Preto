using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis do projeto
            int numero;

            // Input do usuário
            Console.WriteLine("Digite um número");
            numero = int.Parse(Console.ReadLine());

            // Limpar o console
            Console.Clear();

            // Condição
            if (Fibonacchi(numero))
            {
                Console.WriteLine($"O número {numero} percente a sequência Fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {numero} não percente a sequência Fibonacci");
            }

            // Para impedir que o console se fecha assim que a linha acima for executadas
            Console.WriteLine("==================");
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.ReadLine();
        }

        // Função do calculo
        static bool Fibonacchi(int n)
        {
            int x = 0;
            int y = 1;
            while (y < n)
            {
                int temp = x;
                x = y;
                y = temp + x;
            }
            return y == n;
        }
    }
}
