namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetBmi();
        }
        static private void GetBmi()
        {
            double weight;
            double height;
            double BMI;
            double heightSquared;
            Console.Write("Enter your weight in KG: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter your height in metres: ");
            height = double.Parse(Console.ReadLine());
            heightSquared = height * height;
            BMI = weight / heightSquared;
            Console.WriteLine($"Your BMI is {BMI}");



        }
    }
}