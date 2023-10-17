namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(input, int.Parse);
            int sumIncrease = 0;
            int sumDecrease = 0;
            bool isText = false;
            foreach (int item in numbers)
            {
                sumIncrease += item;
            }
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                sumIncrease -= numbers[i];
                if (sumIncrease == sumDecrease)
                {

                    System.Console.WriteLine(i);
                    isText = true;
                }


                sumDecrease += numbers[i];
            }
            if (numbers.Length - 1 == 0)
            {
                System.Console.WriteLine(0);
            }
            else if (isText == false)
            {
                System.Console.WriteLine("no");
            }


        }
    }
}