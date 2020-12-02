using System;
using System.Collections.Generic;

namespace dag2
{
    class Program
    {
        // (\d+-\d+ \w): (.*?)+
        static void Main(string[] args)
        {
            List<string> Data = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bashe\Desktop\advent of code\day1.txt");


            foreach (string line in lines)
            {
                Data.Add(line);
            }
        }
    }
}
