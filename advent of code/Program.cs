using System;
using System.Collections.Generic;

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Data = new List<int>();
            List<string> results = new List<string>(); 
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\bashe\Desktop\advent of code\day1.txt");
            foreach(string line in lines)
            {
                Data.Add(int.Parse(line));
            }
           
            foreach(int number in Data)
            {
                for (int i = 0; i < Data.Count; i++)
                {
                    if(Data.Contains(2020 - (number + Data[i])))
                        {
                        results.Add($"{number} {Data[i]} {2020 - (number + Data[i])} {(number)*(Data[i])*(2020 - (number + Data[i])) }");
                    }
                }
            }

            foreach(string line in results)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
