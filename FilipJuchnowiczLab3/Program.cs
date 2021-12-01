using System;
using System.Collections.Generic;
using System.Linq;

namespace FilipJuchnowiczLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> wordLetters = new List<char>();
            List<char> userLetters = new List<char>();
            string wordTemp = "politechnika";
            int lives = 3;
            bool check = false;

            foreach (char letter in wordTemp)
            {
                wordLetters.Add(letter);
            }

            Console.WriteLine("Gra w wisielca, tylko male litery");

            while (true)
            {
                char userLetterInput;

                if (lives <= 0)
                {
                    break;
                }

                foreach (char letter in wordLetters)
                {
                    if (userLetters.Contains(letter))
                    {
                        Console.Write(letter + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();

                Console.WriteLine($"Ilosc zyc: {lives}\nPodaj litere: ");
                userLetterInput = Console.ReadLine()[0];

                if (wordLetters.Contains(userLetterInput) == false)
                {
                    lives--;
                    if (lives == 0)
                    {
                        Console.WriteLine("Game Over");
                        break;
                    }
                }
                else
                {
                    userLetters.Add(userLetterInput);
                }

                check = !wordLetters.Except(userLetters).Any();

                if (check == true)
                {
                    Console.WriteLine("Win\nHaslo: ");
                    foreach (char letter in wordLetters)
                    {
                        Console.Write(letter + " ");
                    }
                    Console.WriteLine();
                    break;
                }
            }


            // List<string> list = new List<string>() { "pies", "kot" };
            // list.ForEach(Console.WriteLine);

            // list.Add("tygrys");
            // list.Insert(1, "kon");
            // list.RemoveAt(0);

            // foreach (string item in list)
            //     Console.WriteLine(item);

            // Queue<string> queue = new Queue<string>();
            // queue.Enqueue("kot");
            // queue.Enqueue("rekin");
            // queue.Enqueue("slon");

            // foreach (string elem in queue)
            // {
            //     Console.WriteLine(elem);
            // }
        }
    }
}
