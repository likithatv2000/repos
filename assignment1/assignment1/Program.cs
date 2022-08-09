//Write a C# Sharp program that takes three letters as input and display them in reverse order
namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c, c1, c2;

            Console.Write("Input first letter: ");
            c = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second letter: ");
            c1= Convert.ToChar(Console.ReadLine());

            Console.Write("Input three letter: ");
            c2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", c2, c1, c);
        }
    }
}


//Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.


  namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Radius of circle: ");
            double R= Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * R* R;
            Console.WriteLine("Area of circle: " + Area);
            double perimeter = 2 * Math.PI * R;
            Console.WriteLine("Perimeter of circle: " + perimeter);
        }
    }
}

// Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour.
/namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float distance;
            float hour, min, sec;

            float timeSec;
            float mps;
            float kph, mph;

            Console.Write("Input distance(metres): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(minutes): ");
            min = Convert.ToSingle(Console.ReadLine());
            Console.Write("Input timeSec(seconds): ");
            sec = Convert.ToSingle(Console.ReadLine());

            timeSec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timeSec;
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}



//Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.


 namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n1, n2;
            Console.WriteLine("enter first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 2 == 0 && n2 % 2 == 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }
    }
    }




//Write a C# Sharp program to find whether a given year is a leap year or not.

 namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int year;
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else if ((year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n",year);
            else if ((year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", year);
            else
                Console.WriteLine("{0} is not a leap year.\n",year);

        }
    }
}


/*Write a C# Sharp program to accept the height of a person in centimeter and
categorize the person according to their height. (Below 135 - short, above 180, tall. 
In between average) */


namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            float height;
            Console.WriteLine("Enter  the Height (in centimeters) \n");
            height = int.Parse(Console.ReadLine());
            if (height < 150.0)
                Console.WriteLine("short \n");
            else if ((height >= 150.0) && (height <= 179.0))
                Console.WriteLine(" Average Height \n");
            else if(height >= 180.0)
                Console.WriteLine("Taller \n");
           

        }
    }
}




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



            if (sa == sb && sb == sc)
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

