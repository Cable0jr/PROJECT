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


            Console.WriteLine("NARRATOR: You wake up, you have very little memory of what the world was like before the blasts. You were only a child, maybe 8, before you, your friends, and your family had to run to the metal giants. You are now however 28, meaning you have spemt 20 years of your life in the main metal giant, the one that the Hub has named Prosperity Caverns. In these 20 years, with the fallout and the high winds, much of the shelter has been covered, but once a year a team of 15 men go to the front door and make sure we have access to the barren wasteland we once called home.. the barren wasteland the world used to call Canada.");

            Console.WriteLine("NARRATOR: The year? 2579. The amount of prosperous world left? However many Metal Giants remain. Your life and goal? Protect Prosperity Caverns as much as you can.");

            Console.WriteLine("GAME: With you being the general and the leader for the team that scouts the front entrance way, you have to make sure that you are prepared physically, emotionally and most importantly, mentally. Yesterday, the Leader said she recommends checking all your equipment before you report for duty.");

            Console.WriteLine("CHOICE: CHECK EQUIPMENT OR REPORT FOR DUTY?");

            Console.WriteLine("type 1 for equipment check, type 2 for reporting to duty");

            // Very Crude Choice System, Change Later?

            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 1)
                {
                    Console.WriteLine("You check the equipment");
                }

                if (x == 2)
                {
                    Console.WriteLine("You think the Leader is just being paranoid and you ignore her recommendation adn report straight for duty instead.");
                }
            }

        }
    }
}
