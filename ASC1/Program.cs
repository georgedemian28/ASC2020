﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World of C#!!");
            Console.WriteLine("introdoceti numarul de la pantof");

            string line;
            line = Console.ReadLine();

            int numarPantof;

            try
            {
                numarPantof = int.Parse(line);
                Console.WriteLine($"Aveti numarul {numarPantof} la pantof");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
