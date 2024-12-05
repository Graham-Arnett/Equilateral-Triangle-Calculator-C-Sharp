namespace TriangleCalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my equilateral triangle calculator!");
            string choice;
            do
            {
                
                    Console.Write("Enter a number for the sides: ");
                  double side = double.Parse(Console.ReadLine());
                
                double perimeter = side * 3;

                double area = (side * side) / 2;

                Console.WriteLine($"Perimeter of the equilateral triangle is: {perimeter}" +
                    $"\nArea of the equilateral triangle is: {area}");

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }while(choice == "y");
        }
    }
}
