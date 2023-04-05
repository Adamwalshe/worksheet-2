namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountGreater();
        }
        static private void CountGreater()
        {
            int count = 0;
            Console.Write("How many numbers would you like in your array: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Count how many number are above the number :");
            int minimumNumber = int.Parse(Console.ReadLine());  
            int[] x = new int[num];
            for (int j = 0; j < num; j = j + 1)
            {
                string xstring = Console.ReadLine();
                x[j] = int.Parse(xstring);
            }
            for (int i = 0; i < x.Length; i++) 
            {
                if (x[i] >minimumNumber)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine($"There is {count} amount of numbers greater than {minimumNumber}");

        }
    }
}