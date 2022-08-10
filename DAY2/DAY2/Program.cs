/*namespace DAY2
{
    internal class Program
    {
        public struct person
        {
          public  String name;
         public   int age;
         public    int weight;
        }
        static void Main(string[] args)
        {
            person p1;
            p1.name ="likitha";
                p1.age = 22;
            p1.weight = 44;
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.age);
            Console.WriteLine(p1.weight);

        }
    }
}

*/

//Exceptions
/* namespace DAY2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {


                int a = 10;
                int b = 0;
                Console.WriteLine(a + b);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("code resumed");
        }
    }
}
*/


//String program
/* namespace DAY2
{
   internal class Program
   {

       static void Main(string[] args)
       {
           try
           {

               var num = 1 + int.MaxValue / 2;
               num += num;

               Console.WriteLine(int.MinValue);
               Console.WriteLine(int.MaxValue/2);
               Console.WriteLine(num);
           }
           catch(Exception e)
           {
               Console.WriteLine(e.ToString());
           }

       }
   }
}

*/
//

/*namespace DAY2
{
    internal class Program
    {
        public static void show()
        {
            int[] arr = { 6, 5,2,4,1,0};
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        static void Main(string[] args)
        {

           show();
           
        }
    }
}
*/
//
public class Admissioncheck
{
    public static void Main(string[] args)
    {
        float physics, maths, chemistry;
        Console.WriteLine("ELIGIBILTY CHECK");
        Console.WriteLine("Enter Maths mark: ");
        maths = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Chemsitry mark: ");
        chemistry = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Physics mark: ");
        physics = Convert.ToInt32(Console.ReadLine());
        float total = maths + physics + chemistry;
        float mathphy = maths + physics;
        float matchem = maths + chemistry;
        if (maths >= 65 && physics >= 55 && chemistry >= 50 && (total >= 180 || mathphy >= 140 || matchem >= 140))
        {
            Console.WriteLine("YOU ARE ELIGIBLE");

        }
        else
        {
            Console.WriteLine("YOU ARE NOT ELIGIBLE");
        }

    }
}

