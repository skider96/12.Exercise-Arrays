namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program to find all the top integers in an array. A top integer is an
            // integer that is greater than all the
            //elements to its right.

            string[] input = Console.ReadLine().Split();
            int[] number = Array.ConvertAll(input, int.Parse);

            for (int i = number.Length - 1; i >= 0 ; i--)
            {
              int maxNumber = number.Max();
                if (number[i] < number[i -1])
                {

                    System.Console.Write(string.Join("", number[i]));
                    System.Console.Write(" ");
                }  
            }
            
           
            System.Console.Write(string.Join(" ", number[number.Length - 1]));
        }
    }
}
