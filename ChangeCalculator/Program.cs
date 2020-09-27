using System;

namespace ChangeCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ange pris:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Betalt:");
            int paid = Convert.ToInt32(Console.ReadLine());
            int change = paid - price;
            while (change < 0)
            {
                Console.WriteLine("Betalningen understiger priset. Ange nytt betalt belopp:");
                paid = Convert.ToInt32(Console.ReadLine());
                change = paid - price;
            }   
            if (change == 0)
            {
                Console.WriteLine("Jämt belopp betalat, ingen växel behövs");
            }
            else
            {
                Console.WriteLine("Växel tillbaka:");
                Console.WriteLine(change);
                int fiveHundredChange = change / 500;
                if (fiveHundredChange > 0)
                {
                    if (fiveHundredChange > 1)
                    {
                        Console.WriteLine($"{fiveHundredChange} femhundralappar");
                    }
                    else
                    {
                        Console.WriteLine($"{fiveHundredChange} femhundralapp");
                    }
                    change %= 500;
                    Console.WriteLine(change);
                }

                int hundredChange = change / 100;
                if (hundredChange > 0)
                {
                    if (hundredChange > 1)
                    {
                        Console.WriteLine($"{hundredChange} hundralappar");
                    }
                    else
                    {
                        Console.WriteLine($"{hundredChange} hundralapp");
                    }
                    change %= 100;
                }

                int fiftyChange = change / 50;
                if (fiftyChange > 0)
                {
                    if (fiftyChange > 1)
                    {
                        Console.WriteLine($"{fiftyChange} femtiolappar");
                    }
                    else
                    {
                        Console.WriteLine($"{fiftyChange} femtiolapp");
                    }
                    change %= 50;
                }

                int twentyChange = change / 20;
                if (twentyChange > 0)
                {
                    if (twentyChange > 1)
                    {
                        Console.WriteLine($"{twentyChange} tjugolappar");
                    }
                    else
                    {
                        Console.WriteLine($"{twentyChange} tjugolapp");
                    }
                    change %= 20;
                }

                int tenChange = change / 10;
                if (tenChange > 0)
                {
                    if (tenChange > 1)
                    {
                        Console.WriteLine($"{tenChange} tiokronor");
                    }
                    else
                    {
                        Console.WriteLine($"{tenChange} tiokrona");
                    }
                    change %= 10;
                }

                int fiveChange = change / 5;
                if (fiveChange > 0)
                {
                    if (fiveChange > 1)
                    {
                        Console.WriteLine($"{fiveChange} femkronor");
                    }
                    else
                    {
                        Console.WriteLine($"{fiveChange} femkrona");
                    }
                    change %= 5;
                }

                int oneChange = change;
                if (oneChange > 0)
                {
                    if (oneChange > 1)
                    {
                        Console.WriteLine($"{oneChange} enkronor");
                    }
                    else
                    {
                        Console.WriteLine($"{oneChange} enkrona");
                    }
                }

                int tempCheckSum = fiveHundredChange*500 + hundredChange*100 + fiftyChange*50 + twentyChange*20 + tenChange*10 + fiveChange*5 + oneChange;
                Console.WriteLine($"Change left: {change-oneChange}   CheckSum:{tempCheckSum}");
            }
        }
    }
}
