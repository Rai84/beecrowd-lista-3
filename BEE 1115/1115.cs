﻿using System;

namespace BEE_1115
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x, y, z = 0.0f;

            do
            {
                string[] array = Console.ReadLine().Split(' ');

                x = float.Parse(array[0]);
                y = float.Parse(array[1]);

                if (x > z && y > z)
                {

                    Console.WriteLine("primeiro");

                }
                else if (x < z && y > z)
                {

                    Console.WriteLine("segundo");

                }
                else if (x < z && y < z)
                {

                    Console.WriteLine("terceiro");

                }
                else if (x > z && y < z)
                {

                    Console.WriteLine("quarto");
                }

            } while (x != 0 && y != 0);
        }
    }
}
