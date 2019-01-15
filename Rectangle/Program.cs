using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            int userSelection = 0;

            Console.WriteLine("Zadejte delku strany:");

            while (true)
            {
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Nespravny vstup");
                }
            }

            Console.Clear();

            Console.WriteLine("Zvolte orientaci trojuhelniku:");
            Console.WriteLine("1) Podel dolni strany");
            Console.WriteLine("2) Podel horni strany");

            while (true)
                try
                {
                    userSelection = int.Parse(Console.ReadLine());
                    if (userSelection == 1 | userSelection == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vstup neni v rozsahu");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Nespravny vstup");
            }

            Console.Clear();

            string side = "+";
            for (int i = 0; i < userInput; i++)
            {
                side += " -";
            }
            side += " +";

            Console.WriteLine(side);

            for (int a = 0; a < userInput; a++)
            {
                Console.Write("|");
                for (int b = 0; b < userInput; b++)
                {
                    int x;
                    int y;

                    switch (userSelection)
                    {
                        case 1:
                            x = a;
                            y = b;
                            break;
                        case 2:
                            x = b;
                            y = a;
                            break;
                        default:
                            x = a;
                            y = b;
                            break;
                    }

                    if (x >= y)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write(" |\n");
            }

            Console.WriteLine(side);
        }
    }
}
