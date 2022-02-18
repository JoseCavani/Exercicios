using System;

namespace ALenda.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            back:
            int z = 0;
            Console.WriteLine("digite pessoas no círculo");
            if (!(int.TryParse(Console.ReadLine(), out int pessoas)))
            {
            }
            bool[] pessoasVivas = new bool[pessoas + 1];
                Console.WriteLine("digite o salto");
            if (!(int.TryParse(Console.ReadLine(), out int salto)))
            {
            }

            //5 2   2 4  4 1  1 3
            pessoasVivas[0] = true;
            int n = 0;
            int count = 0;
            int i = pessoas;
            while (true)
            {
                for (int i2 = 0; i2 < pessoasVivas.Length; i2++)

                {
                    count = 0;
                    if (pessoasVivas[i2] == false)
                    {
                        count++;
                        n = i2;
                    }
                }
                if (count == 1)
                {
                    z++;
                    Console.WriteLine($"Caso {z}: {n}");
                    Console.WriteLine("digite s para sair");
                   string s = Console.ReadLine().ToLower();
                    if (s == "s")
                        break;
                    else goto back;
                    Console.ReadKey();
                }

                i = i + salto;

                if ((i) > pessoas)
                {
                    i = (i) - pessoas;
                }
                pessoasVivas[i] = true;

            }
               

            }


                
            
        }
    }

