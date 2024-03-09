using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis do projeto
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            // Loop de repetição
            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            
            // Exibição para o usuário
            Console.WriteLine($"O valor é: {SOMA}");

            // Para o console não fechar automaticamente após a exibição da linha acima.
            Console.WriteLine("========================");
            Console.WriteLine("Aperta qualquer tecla para sair.");
            Console.ReadLine();
        }
    }
}
