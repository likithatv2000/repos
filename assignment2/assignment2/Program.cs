//copycopy elements of one array to another
/*namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 6, 7, 3, 2, 1, 4, 6, 9, 0};
            int[] target = new int[10];
            source.CopyTo(target, 0);
            foreach(int item in target)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
*/
//merge two arrays in assending order
/* namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i, j, N1, N2, k, n;
            Console.WriteLine("Enter the Maximum Range of an Array:");
            N1 = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10]; ;
            Console.WriteLine("Enter the input Elements for the first Array");
            for (i = 0; i < N1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the input Elements for the Second Array");

            for (j = 0; j < N2; j++)
            {
                b[j] = Convert.ToInt32(Console.ReadLine());

            }
            n = N1 + N2;
            //insert in Third Array;
            for (i = 0; i < N1; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < N2; j++)
            {
                c[i] = a[j];
                i++;

            }
            //Sorting the Third Array to Ascending Order
            for (i = 0; i < n; i++)
            {
                for (k = 0; k < n - 1; k++)
                {
                    if (c[k] >= c[k + 1])
                    {
                        j = c[k + 1];
                        c[k + 1] = c[k];
                        c[k] = j;
                    }
                }
            }
            //print the merged Array
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.ReadLine();
        }
    }
}
*/

//seperate even and odd numbers
/*
namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {77, 34,45,22,21,66 };
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            int i, j = 0, k = 0;
            for (i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even numbers");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Odd numbers");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }

        }

    }
}
*/
//Write a program in C# Sharp to print individual characters of the string in reverse order.

/*namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int len = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            len = str.Length - 1;
            Console.Write("characters of string in reverse are : \n");
            while (len >= 0)
            {
                Console.Write("{0} ", str[len]);
                len--;
            }
            
        }
    }
}
*/

//


/* namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1;
            char[] arr1;
            int length, i;
            length = 0;
            char ch;
            Console.Write("Enter a string : ");
            str1 = Console.ReadLine();
            length = str1.Length;
            arr1 = str1.ToCharArray(0, length);

            Console.Write("\nAfter conversion, the string is: ");
            for (i = 0; i < length; i++)
            {
                ch = arr1[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch));
                else
                    Console.Write(Char.ToLower(ch)); 
            }

        }
    }
}
*/
//Write a C# Sharp program to find the length of the longest substring without repeating characters from a given string.
namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}