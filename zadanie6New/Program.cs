using System;
namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                Console.WriteLine("Wpisz proszę swój wzrost");
                Console.WriteLine("Wzrost:");
                int a = 0;

                int.TryParse(Console.ReadLine(), out a);

                {
                    if (a < 140)
                    {
                        Console.WriteLine("Jesteś pokurcz:");
                    }
                    else if (a <= 170)
                    {
                        Console.WriteLine("Jesteś średniaczek:");
                    }
                    else if (a <= 185)
                    {
                        Console.WriteLine("Jesteś w sam raz:");
                    }
                    else if (a >= 186)
                    {
                        Console.WriteLine("Jesteś olbrzymem:");
                    }
                    
                }


            }
        }
    }
}