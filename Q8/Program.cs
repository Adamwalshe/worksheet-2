namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rental();
        }
        static private void Rental()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int charge1 = 10;
            int charge2 = 8;
            int initialCharge3 = 15;
            int totalCharges;
            int x;
            int y;
            int z;

            Console.Write("Enter number of days for rental:");
            int numOfDays = int.Parse(Console.ReadLine());

            if (numOfDays == 0)
            {
                Console.WriteLine("Charge is 0");
            }
            else if (numOfDays >=1 && numOfDays <=5)
            {
                z = numOfDays * charge1;
                totalCharges = z + initialCharge3;
                Console.WriteLine($"Your total charge is: {totalCharges:c}");
            }
            else if ( numOfDays >= 6 )
            {
                x = charge1 * 5;
                y = charge2 * (numOfDays-5);
                totalCharges = x + y + initialCharge3; 
                Console.WriteLine($"Your total charge is: {totalCharges:c}");
            }
            else
            {
                Console.WriteLine("Invalid amount of days inputed");
            }


        }
    }
}