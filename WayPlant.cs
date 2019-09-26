using System;
using System.Collections.Generic;

namespace WayPlant
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Plant Game");
            Plant Rose = new Plant();
            Console.WriteLine("Please enter in y f or s to do things to your plant");
            string userAnswer = Console.ReadLine();
            StartGame(userAnswer);
        }
        public static void StartGame(string userAnswer)
        {
            Rose.QuestionAnswered(userAnswer);
            Main();
        }

    }
}