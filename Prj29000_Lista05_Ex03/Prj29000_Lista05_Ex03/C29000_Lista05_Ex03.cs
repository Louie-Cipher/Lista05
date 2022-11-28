using System;

namespace Prj29000_Lista05_Ex03
{
    internal class C29000_Lista05_Ex03
    {
        static void Main()
        {
            string answer = "s";

            while (answer == "s")
            {
                int maior = 0;
                int menor = 0;

                int soma = 0;
                int positivo = 0;
                int negativo = 0;

                Console.Write("Digite a quantidade de números: ");
                int n = int.Parse(Console.ReadLine());

                while (n < 0 || n > 20)
                {
                    Console.WriteLine("A quantidade de números deve ser positiva, e menor que 20");
                    Console.Write("Digite a quantidade novamente: ");
                    n = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Digite o {i + 1} número: ");
                    int newNum = int.Parse(Console.ReadLine());

                    soma += newNum;

                    if (i == 0)
                    {
                        maior = newNum;
                        menor = newNum;
                    }
                    else if (newNum > maior) maior = newNum;
                    else if (newNum < menor) menor = newNum;

                    if (i > 0) positivo++;
                    else negativo++;
                }

                float positivePercent = (float)positivo / n * 100;
                float negativePercent = (float)negativo / n * 100;

                Console.WriteLine($"O maior valor é: {maior}");
                Console.WriteLine($"O menor valor é: {menor}");
                Console.WriteLine($"A soma dos valores é: {soma}");
                Console.WriteLine($"A média é: {soma / n}");
                Console.WriteLine($"A porcentagem de valores positivos é: {positivePercent}%");
                Console.WriteLine($"A porcentagem de valores negativos é: {negativePercent}%");

                Console.Write("Deseja executar o programa novamente? (s/n) ");
                answer = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Fim do programa");
            Console.ReadKey();
        }
        
    }
}
