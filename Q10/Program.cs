namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DistanceTravelled();
        }
        static private void DistanceTravelled()
        {
            Console.Write("Speed of vehicle in kilometres per hour:");
            int speed = int.Parse(Console.ReadLine());
            Console.Write("Time spent traveling in hours:");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine($"{"Hour",-10} Distance Travelled");
            for (int i = 1; i<=time; i++) 
            {                
                int hourlyspeed = speed * i;
                int distance = hourlyspeed * i;

                Console.Write($"{i,-3} {hourlyspeed,-5} {distance}");
                Console.WriteLine("");
            }



        }
    }
}