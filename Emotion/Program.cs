using System;

namespace Emotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is my emotion?");
            Console.WriteLine();
            Console.Write("You are.. ");
            string command = Console.ReadLine().ToLower();
            Expression ex = new Expression();
            while (true)
            {
                Console.Clear();
                switch (command)
                {   
                    case "happy":
                        ex.Happy();
                        break;
                    case "angry":
                        ex.Angry();
                        break;
                    case "sad":
                        ex.Sad();
                        break;
                    case "dorcless":
                        ex.Dorcless();
                        break;
                    case "constipated":
                        ex.Constipation();
                        break;
                    case "horny":
                        ex.Horny();
                        break;
                    case "scared":
                        ex.Fear();
                        break;
                    case "surprised":
                        ex.Surprise();
                        break;
                    case "dead":
                        ex.Dead();
                        return;                  
                    case "sleepy":
                        ex.Sleep();
                        Console.WriteLine();
                        Console.WriteLine("Good night");
                        return;
                    default:
                        Console.WriteLine("Unknown emotion!\n Try again.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("What is my emotion?");
                Console.WriteLine();
                Console.Write("You are.. ");
                command = Console.ReadLine();
            }
        }
    }
}
