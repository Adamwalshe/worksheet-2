namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgeBracket();
        }
        static bool AgeBracket()
        {
            int age;
            Console.WriteLine("Enter age: ");
            age = int.Parse(Console.ReadLine());
            if (age <18 && age >21)
            {
                return false;
            }
            else if (age >18 && age <21) 
            
                Console.WriteLine("You can access this website");
                return true; 
            
            


        }
    }
}