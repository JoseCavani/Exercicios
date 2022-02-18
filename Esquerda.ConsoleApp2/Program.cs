using System;

namespace Esquerda.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                char orientacao = 'N';
            volta5:
                Console.WriteLine("digite quantos numeros quer digitar");
                if (!(int.TryParse(Console.ReadLine(), out int numeros)))
                {
                    goto volta5;
                }
                if (numeros == 0)
                {
                    break;
                }
            volta2:
                Console.Write("instruções: \n Letra E gira 90 graus para a esquerda\n Letra D gira 90");

                Console.WriteLine("digite os commandos");
                string stringCommandos = Console.ReadLine().ToUpper();
                if (stringCommandos.Length != numeros)
                {

                    Console.WriteLine("erro");
                    goto volta2;
                }



                foreach (char commando in stringCommandos.Trim())
                {
                    if (commando != 'E' && commando != 'D')
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("sequencia contem valore(s) invalido(s)");
                        Console.ReadKey();
                        Console.ResetColor();
                        goto volta2; // coninue faz o commando aconetecer novamnete para todos os valores incorretos
                    }
                }

                foreach (char commando in stringCommandos.Trim())
                {

                    if (commando == 'E')
                    {
                        switch (orientacao)
                        {


                            case 'N':
                                orientacao = 'O';
                                break;
                            case 'O':
                                orientacao = 'S';
                                break;
                            case 'S':
                                orientacao = 'L';
                                break;
                            case 'L':
                                orientacao = 'N';
                                break;
                        }
                    }
                    else
                    {

                        switch (orientacao)
                        {
                            case 'N':
                                orientacao = 'L';
                                break;
                            case 'O':
                                orientacao = 'N';
                                break;
                            case 'S':
                                orientacao = 'O';
                                break;
                            case 'L':
                                orientacao = 'S';
                                break;


                        }
                    }

                }

                Console.WriteLine(orientacao);
            }
        }
       
    }
}
