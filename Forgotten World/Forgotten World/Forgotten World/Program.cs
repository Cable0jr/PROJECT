using System;
using System.IO;
using System.Collections.Generic;

namespace ForgottenWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Forgotten World";

            string node = "Nodes\\11START.txt";

            bool isRunning = true;

            while (isRunning)
            {

                StreamReader sr = new StreamReader(node);

                List<string> nodes = new List<string>();

                while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine().Trim();

                    if (line == "---")
                    {

                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine().Trim();

                            string[] parts = line.Split('|');

                            nodes.Add(parts[1].Trim());

                            Console.WriteLine(parts[0]);
                        }
                    }

                    else
                    {
                        Console.WriteLine(line);
                    }
                }

                sr.Close();

                Console.WriteLine();

                if (nodes.Count > 0)
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    node = "Nodes\\" + nodes[n - 1];
                }

                else
                {
                    isRunning = false;
                }
            }

           Console.ReadKey();
        }
    }
}