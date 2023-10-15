namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int sum = 0;

            int[] people = new int[numberOfWagons];
            for (var i = 0; i < numberOfWagons; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                sum += numberOfPeople;
                people[i] = numberOfPeople;
            }


            for (var i = 0; i < people.Length; i++)
            {
                System.Console.Write($"{people[i]} ");
    
            }
            System.Console.WriteLine();
            System.Console.WriteLine(sum);
        }
    }
}
