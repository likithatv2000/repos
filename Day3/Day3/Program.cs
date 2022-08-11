namespace Day3
{
    internal class Program
    {
        
      public  static void Main(string[] args)
        {
            /*  var newlist = new List<string>();
              newlist.Add("Apple");
              newlist.Add("Banana");
              newlist.Add("Orange");
              newlist.Add("Vegetables");
              newlist.Add("Tomato");
              newlist.Add("Potato");
              newlist.Add("Apple");
              foreach (var item in newlist)
              {
                  Console.WriteLine(item);
              }
            */
            /* var newHash = new HashSet<int>();
              newHash.Add(33);
              newHash.Add(34);
              newHash.Add(33);
              newHash.Add(33);
              newHash.Add(33);
              foreach(var item in newHash)
              {
                  Console.WriteLine(item);
              }
            */
            /* var newSorted = new SortedSet<String>();
             newSorted.Add("Vegetables");
             newSorted.Add("Tomato");
             newSorted.Add("Potatos");
             newSorted.Add("Carrot");
             newSorted.Add("Carrot");
            foreach(var item in newSorted)
             {
                 Console.WriteLine(item);    
             }
            */
            /* var Linkednew = new LinkedList<string>();
              Linkednew.AddLast("Likitha");
              Linkednew.AddLast("G");
              Linkednew.AddLast("H");
              Linkednew.AddLast("I");
              foreach(var item in Linkednew)
              {
                  Console.WriteLine(item);
              }
            */
            /* Dictionary <string, string> dictionary = new Dictionary<string, string>();
               dictionary.Add("1", "Likitha");
               dictionary.Add("4","Likitha");
               dictionary.Add("2", "pppp");
               dictionary.Add("6", "wwwww");
               dictionary.Add("3", "ttttt");

               dictionary.Remove("1");
               foreach (KeyValuePair<string, string> keyvalue in dictionary)
               {
                   Console.WriteLine(keyvalue);
               }
            */
            /* SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
                dictionary.Add("1", "Likitha");
                dictionary.Add("4", "Likitha");
                dictionary.Add("2", "pppp");
                dictionary.Add("6", "wwwww");
                dictionary.Add("3", "ttttt");
                foreach (KeyValuePair<string, string> keyvalue in dictionary)
                {
                    Console.WriteLine(keyvalue);
                }
            */
            /*SortedList<int, string> list = new SortedList<int, string>();
                list.Add(1, "Appp");
                list.Add(6, "Ap");
                list.Add(5, "App");
                list.Add(2, "Bppp");
                list.Add(7, "Appp");
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
            */

            /*GenericExample<String> genericexample = new GenericExample<String>("this is string");
            GenericExample<int> genericexample1 = new GenericExample<int>(45);
            GenericExample<char> genericexample2 = new GenericExample<char>('k');
            */
            FileStream f = new FileStream("C:\\Users\\Likitha\\OneDrive\\Desktop\\lik.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            f.WriteByte(70);
            Console.WriteLine("Data written into file");

            f.Close();
            Console.WriteLine("File Stream closed");

        }
        }
}