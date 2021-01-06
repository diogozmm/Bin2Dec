using System;

namespace Bin2Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            bool control = true;
            bool controlNum = true;
            char[] natNumbers = { '2', '3', '4', '5', '6', '7', '8', '9' };
            while (control)
            {

                Console.WriteLine("Digite um número binário (máximo 8 dígitos)");
                string binNumber = Console.ReadLine();

                //USER STORY
                /* if (binNumber.Length > 8)
                 {
                     Console.WriteLine("Você digitou mais de 8 dígitos");
                 } */

                for (int i = 0; i < natNumbers.Length; i++)
                {
                    if (binNumber.Contains(natNumbers[i]))
                    {
                        Console.WriteLine("Digite apenas 0 e 1");
                        controlNum = false;
                    }
                }

                if (!controlNum) { }

                else
                {
                    int priorNumber = 0;
                    int result = 0;

                    for (int j = 0; j < binNumber.Length; j++)
                    {
                        result = priorNumber * 2 + int.Parse(binNumber[j].ToString());
                        priorNumber = result;
                    }

                    Console.WriteLine($"O número binário {binNumber} equivale a {result} na base 10\n");

                    Console.WriteLine("Deseja fazer uma nova conversão?");
                    string decisao = Console.ReadLine().ToLower();

                    if (decisao == "sim") { }
                    else if (decisao == "nao")
                    {
                        control = false;
                    }
                }
            }
        }
    }
}