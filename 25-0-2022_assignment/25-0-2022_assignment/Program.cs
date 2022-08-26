using System.Data.SqlClient;

namespace day5;


public class day5
{
    public static void Main(String[] args)
    {

        string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(Connect);
        sqlconn.Open();
        Console.WriteLine("enter a subject");
        String Subject = Console.ReadLine();
        //String QueryString= "select  students.dbo.FN4('"+Subject+"')";
        //Console.WriteLine(QueryString);

        SqlCommand cmd = new SqlCommand("select  students.dbo.FN4(@Subject)", sqlconn);
        //SqlCommand sqlcommand=sqlconn.CreateCommand();
        //cmd.CommandType = System.Data.CommandType.StoredProcedure;

        cmd.Parameters.Add("@Subject", System.Data.SqlDbType.VarChar).Value = Subject;
        Console.WriteLine("Built string is" + cmd.CommandText.ToString());

        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString());
        }
        /*String Grade = cmd.ExecuteScalar().ToString();
        
        if(Grade==null || Grade==String.Empty)
        {
            Console.WriteLine("subject is Not There");
        }
        else
        {
            Console.WriteLine("The Grade is " + Grade);
        }*/
        dr.Close();
        sqlconn.Close();
    }
}
