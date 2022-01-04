using PrivateSchool.Entities;
using System;
using System.Collections.Generic;

namespace PrivateSchool.Views.Trainers
{
    public class ViewTrainer
    {
        public static void PrintTrainers(List<Trainer> trainers, string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(message);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"",-4}{"First Name",-20}{"Last Name",-25}{"Subject",-50}");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                trainer.Print();
            }
        }
    }
}
