namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split().ToArray();
            string[] secondLine = Console.ReadLine().Split().ToArray();

            for (var i = 0; i < firstLine.Length; i++)
            {
                for (var j = 0; j < secondLine.Length; j++)
                {
                    if (firstLine[i] == secondLine[j])
                    {
                        System.Console.Write(secondLine[j] + " ");
                    }
                    
                }
            }
            // Hey hello 2 4
            // 10 hey 4 hello
        }
    }
}
