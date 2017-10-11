using System;

namespace Projeto_11_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UmMaiorDois = 1 > 2; // tem como padrão um valor FALSO
            if (UmMaiorDois)
            {
                System.Console.WriteLine("Um é maior que dois");
            }
            else
            {
                System.Console.WriteLine("Um não é maior que dois");
            }
            
            int[] idades = new int [5]; // variavel + colchetes + nome da variavel + new + tipo da variavel e [quantos retornos]
            idades[0] = 1;
            idades[1] = 22;
            idades[2] = 23;

            for (int teste =0; teste <idades.Length; teste++) // formula padrão para repetir todos os códigos da Array de um jeito mais prático
            {
                System.Console.WriteLine(idades[teste]);
            }

        }   
    }
}
