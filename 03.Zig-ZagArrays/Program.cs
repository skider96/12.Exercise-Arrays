namespace _03.Zig_ZagArrays
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int n = int.Parse(Console.ReadLine());
      int[] firstDigits = new int[n];
      int[] secondDigits = new int[n];
      string[] input = new string[1];

      for (var i = 0; i < n; i++)
      {
        input = Console.ReadLine().Split();
        if (i % 2 == 0)
        {
          firstDigits[i] = int.Parse(input[0]);
          secondDigits[i] = int.Parse(input[1]);
        }
        else
        {
          secondDigits[i] = int.Parse(input[0]);
          firstDigits[i] = int.Parse(input[1]);
        }

      }
      System.Console.WriteLine(string.Join(" ", firstDigits));
      System.Console.WriteLine(string.Join(" ", secondDigits));
    }
  }
}
/*
4
1 5
9 10
31 81
41 20

*/