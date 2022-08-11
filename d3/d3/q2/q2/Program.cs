public class ex2
{
    public static void Main()
    {
        string file1 = "C:\\Users\\Likitha\\source\\repos\\file1.txt";
        string file2 = "C:\\Users\\Likitha\\source\\repos\\file2.txt";

        FileStream fs = new FileStream(file1, FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("this is likitha");
        sw.WriteLine("welcome");
        sw.WriteLine("i am studying in be in ise");
        sw.Close();
        fs.Close();
        //File.Move(file1, file2);
        Console.WriteLine("File is moved in the same directory with another name");
        using (StreamReader sr = File.OpenText(file2))
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