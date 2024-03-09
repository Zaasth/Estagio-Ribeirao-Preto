using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_5
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Digite uma texto para inverter: ");
            // Input do usuário
            string texto = Console.ReadLine();

            string txtInvert = inverterString(texto);

            Console.WriteLine("Texto invertido: " + txtInvert);

            Console.WriteLine("=================");
            Console.WriteLine("Aperte qualquer tecla para sair.");
            Console.ReadLine();
        }

        // Função para inverter o texto
        static string inverterString(string str)
        {
            char[] caracteres = str.ToCharArray();
            int inicio = 0;
            int fim = str.Length - 1;

            while (inicio < fim)
            {
                char temp = caracteres[inicio];
                caracteres[inicio] = caracteres[fim];
                caracteres[fim] = temp;
                inicio++;
                fim--;
            }

            return new string(caracteres);
        }
    }
}
