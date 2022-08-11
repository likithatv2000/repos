public class ex4
{
    public void GenericMethod<T, U, V>(T id, U name, V result)
    {
        Console.WriteLine("Id: " + id + " Name: " + name + " Result :" + result);

    }
    public static void Main(String[] args)
    {
        ex4 gen = new ex4();
        gen.GenericMethod(1, "lIKITHA",'A');
        gen.GenericMethod(2, "JYOSHNA", 'B');
        gen.GenericMethod(15, "MOUNIKA", 'C');
        gen.GenericMethod(19, "NISCHAL", 'Y');
        gen.GenericMethod(21, "YUIOOP", 'D');


    }
}