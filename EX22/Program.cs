using System;

namespace EX22
{
    class Program
    {
        static void Main(string[] args)
        {         

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(@$"
                0 x {i} = {i * 0}
                1 x {i} = {i * 1}
                2 x {i} = {i * 2}
                3 x {i} = {i * 3}
                4 x {i} = {i * 4}
                5 x {i} = {i * 5}
                6 x {i} = {i * 6}
                7 x {i} = {i * 7}
                8 x {i} = {i * 8}
                9 x {i} = {i * 9}
                10 x {i} = {i * 10}
                ");
            }
        }
    }
}
