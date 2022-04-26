// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>();

            //words.Add("phone");
            //words.Add("keyboard");
            //words.Add("mouse");

            //Console.WriteLine(words.Count);

            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //enter numbers into a list, then compute once 0 is entered
            List<int> numbers = new List<int>();
            int input = -1;
            float sum = 0;
            float average = 0;
            float max = -999999999;
            float min = 9999999999;
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            while (input != 0)
            {
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());

                if (input != 0)
                {
                    numbers.Add(input);   
                }

            }

            //Finding sum
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
                //Finding the Maximum
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                if (numbers[i] < min && numbers[i] > 0)
                {
                    min = numbers[i];
                }
            }

            //Finding Average
            average = sum / numbers.Count;


            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is : {average}");
            Console.WriteLine($"The maximum is : {max}");
            Console.WriteLine($"The smallest positive number is: {min}");
            //Work on sorting below
            //Console.WriteLine(numbers.Sort());
        }
    }
}