using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a text based game, and a proof of concept for the school year of 2018/19 (CODENAME:PROJWORK) Worked on by Jake Gamble, Clarence Edwards, ");



            // Choice system, refer to README in the google drive for information on the process used.


            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("This is Option 1");
                    break;
                }
                else if (x == 2)
                {
                    Console.WriteLine("This Is Option 2");
                    break;
                }
                else if (x == 3)
                {
                    Console.WriteLine("This is a very unlikely pickle we have i suppose");
                    break;
                }
                else if (x >= 4)
                {
                    Console.WriteLine("That Is Not An Option, Please Try Again");
                }
            }
        }
    }
}
