namespace worksheet_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }
        static private void Sum()
        {
            int n1;
            int n2;
            int sum = 0;
            Console.Write("Enter lower number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter higher number: ");
            n2 = int.Parse(Console.ReadLine());
            
            for (int i = n1; i <= n2; i++  )
            {
                if (i % 2 == 1)
                {
                    sum = sum + i;
                }
                
            }
            Console.WriteLine(sum); 
            
        }

    }
}