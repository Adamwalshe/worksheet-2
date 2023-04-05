using System.Security.Cryptography.X509Certificates;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AllTheNines();
        }
        static private void AllTheNines()
        {
            Console.WriteLine("How many nines would you like in your array: ");
            int num = int.Parse(Console.ReadLine());
            int[] x = new int[num];
            for (int i = 0; i < num; i = i + 1)
            {
                x[i] = 9;

            }
            


        }
    }
}