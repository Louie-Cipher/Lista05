using System;

namespace Prj29000_Lista05_Ex01
{
    internal class C29000_Lista05_Ex01
    {
        static void Main()
        {
            int[] valores = new int[10];
            int maior = 0;
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                bool valid = int.TryParse(Console.ReadLine(), out valores[i]);

                if (!valid || valores[i] < 0)
                {
                    Console.WriteLine("Valor inválido!");
                    continue;
                }

                soma += valores[i];
                if (valores[i] > maior) maior = valores[i];
            }

            float media = soma / valores.Length;

            Console.WriteLine($"O maior valor é: {maior}");
            Console.WriteLine($"A soma dos valores é: {soma}");
            Console.WriteLine($"A média aritmética dos valores é: {media}");

            Console.ReadKey();

        }
    }
}
