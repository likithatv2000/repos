//Write a C# program to check whether the triangle is Equilateral, Isosceles or Scalene based on the input sides from the user.

namespace assignment_day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sa, sb, sc;
         Console.Write("Input side 1 of triangle: ");
            sa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            sb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            sc = Convert.ToInt32(Console.ReadLine());



            if (sa== sb && sb == sc)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sa == sb || sa == sc || sb == sc)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }

        }
    }
}


