namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountRates();
        }
        static private void DiscountRates()
        {
            Console.Write("How many children have you for the holiday: ");
            int numOfKids = int.Parse(Console.ReadLine());
            if (numOfKids == 0) 
            {
                Console.WriteLine("Your discount is 0%");
            }
            else if (numOfKids >= 1 && numOfKids <=2 )
            {
                Console.WriteLine("Your discount is 5%");
            }
            else if ( numOfKids >= 3 && numOfKids <=5 ) 
            {
                Console.WriteLine("Your discount is 10%");
            }
            else if (numOfKids > 5 )
            {
                Console.WriteLine("Your discount is 15%");
            }
            else
            {
                Console.WriteLine("");
            }


        }
    }
}