using Microsoft.VisualBasic;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsSorted();
        }
        static bool IsSorted()
        {
            int num;
            Console.WriteLine("Enter length of array:");
            num = int.Parse(Console.ReadLine());
            int[]x = new int[num];
            for (int i = 0; i < num; i = i + 1)
            {
                string xstring = Console.ReadLine();
                x[i] = int.Parse(xstring);
            }
            for (int j = 0; j < x.Length - 1; j++)
            {
                if (x[j] > x[j + 1])
                {
                    Console.WriteLine("My array is not sorted");
                    return false;
                }
            }
            Console.WriteLine("My array is sorted");
            return true;






        }

    }
}