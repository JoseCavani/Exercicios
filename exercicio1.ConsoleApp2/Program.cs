using System;

namespace exercicio1.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        back2:
            Console.WriteLine("digite quantos numeros quer digitar");
            if (!(int.TryParse(Console.ReadLine(), out int numeros)) || numeros > 0 || numeros < 2000)
            {
                int[] numeroArray = new int[numeros];
                int[] s = new int[numeros];
                for (int i = 0; i < numeroArray.Length; i++)
                {
                back:
                    Console.WriteLine("digite o numero");
                    if (int.TryParse(Console.ReadLine(), out numeroArray[i]))
                    {

                    }
                    else
                    {
                        Console.WriteLine("invalido");
                        goto back;
                    }
                }

                Array.Sort(numeroArray);

                for (int i = 0; i < numeroArray.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < numeroArray.Length; j++)
                    {

                        if (numeroArray[i] == numeroArray[j])
                            count = count + 1;
                    }
                  
                    Console.WriteLine("\t\n " + numeroArray[i] + " occore " + count + " vezes");
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("invalido");
                goto back2;
            }

        }
    }
}
