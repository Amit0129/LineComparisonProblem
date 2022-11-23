namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");

            //First Line Point
            Console.WriteLine("Enter the value of X1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Second Line Point
            Console.WriteLine("Enter the value of X3");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y3");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X4");
            double x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y4");
            double y4 = Convert.ToDouble(Console.ReadLine());

            

            LineLength linelength = new LineLength();
            double firstLineLength = linelength.GetLineLength(x1, y1, x2, y2);
            double secondLineLength = linelength.GetLineLength(x3, y3, x4, y4);

            if (firstLineLength == secondLineLength)
            {
                Console.WriteLine("The line length are equal");
            }
            
        }
    }
}