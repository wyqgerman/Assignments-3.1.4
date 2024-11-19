namespace Assignments_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            string quadrant;

            if (x > 0 && y > 0)
            {
                quadrant = "First quadrant";
            }
            else if (x < 0 && y > 0)
            {
                quadrant = "Second quadrant";
            }
            else if (x < 0 && y < 0)
            {
                quadrant = "Third quadrant";
            }
            else if (x > 0 && y < 0)
            {
                quadrant = "Fourth quadrant";
            }
            else if (x == 0 && y != 0)
            {
                quadrant = "on the Y-axis";
            }
            else if (y == 0 && x != 0)
            {
                quadrant = "on the X-axis";
            }
            else
            {
                quadrant = "at the origin";
            }

            Console.WriteLine($"The coordinate point ({x},{y}) lies {quadrant}.");
        }
    }
}
