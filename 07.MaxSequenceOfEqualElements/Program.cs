using System;
using System.Collections.Generic;
namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] numbers1 = Console.ReadLine().Split().ToArray();
            int[] numbers = Array.ConvertAll(numbers1, int.Parse);
             int equals = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                
                for (var j = 0; j < numbers.Length - 1; j++)
                {
                    
                    if (equals == numbers[i])
                    {

                        for (var l = 0; l < numbers.Length - 1; l++)
                        {
                            if (numbers[l] == numbers[j])
                            {
                                for (int k = numbers.Length - 1; k >= 0; k--)
                                {

                                    if (numbers[k] == numbers[j])
                                    {
                                        System.Console.WriteLine($"{numbers[i]} {numbers[j]} {numbers[l]} {numbers[k]}");
                                        return;

                                    }
                                    else
                                    {
                                        System.Console.WriteLine($"{numbers[i]} {numbers[j]} {numbers[l]}");
                                        return;

                                    }

                                }
                            }
                            else
                            {
                                System.Console.WriteLine($"{numbers[i]} {numbers[j]}");
                                return;

                            }
                        }

                    }
                    else
                    {
                        System.Console.WriteLine($"{numbers[i]}");
                        return;
                    }
                }
                
            }

        }
    }
}
