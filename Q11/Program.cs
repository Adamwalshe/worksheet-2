namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many years of rainfall:");
            int years = int.Parse(Console.ReadLine());
            for (int i = 1; i <= years; i++) 
            {
                Loop();
                
            }
        }
        static private void Loop()
        {
            for (int j = 1; j <= 12; j++)
            {
                int[] rain = new int[12];
                Console.Write($"Enter rainfall in cm for month {j}:");
                string xstring = Console.ReadLine();
                rain[j] = int.Parse(xstring);
            }

        }
    }
}