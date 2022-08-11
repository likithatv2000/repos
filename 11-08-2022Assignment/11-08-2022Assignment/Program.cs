namespace _11_08_2022Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "C:\\Users\\Likitha\\OneDrive\\Desktop\\liki.txt";
            FileStream fs = new FileStream(filename, FileMode.Append);//it is an existing file

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Welcome to this sesion on AI & ML");
            sw.WriteLine("Pleasure to have u all here");
            sw.WriteLine("Hope u all will like this session");
            sw.WriteLine("Lets start ");

            sw.Close();

            Console.WriteLine("file is apended");
            using (StreamReader sr = File.OpenText(filename))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
                sr.Close();

                fs.Close();
            }
        }
    }
}