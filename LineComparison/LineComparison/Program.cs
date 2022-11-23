namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            //Length as 2 Podoubles(x1, y1) and(x2, y2) 
            //Length of a Line = sqrt((x2 - x1) ^ 2 + (y2- y1) ^ 2)
            Console.WriteLine("Enter the value of X1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //double re1 = (Math.Pow((x2 - x1), 2));
            //double re2 = (Math.Pow((y2 - y1), 2));

            double length = Math.Sqrt((Math.Pow((x2 - x1), 2))+ (Math.Pow((y2 - y1), 2)));
            Console.WriteLine($"The Length of the Line is {length}");

            
        }
    }
}