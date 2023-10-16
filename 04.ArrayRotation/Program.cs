namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            int[] numbers = Array.ConvertAll(text, int.Parse);
            int rotations = int.Parse(Console.ReadLine());

            for (var i = 0; i < rotations; i++)
            {
                int firstElement = numbers[0];
                for (var j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = firstElement;

            }

            System.Console.WriteLine(string.Join(" ", numbers));
            //направено с chatGPT 
        }
    }
}
