/*answer1*/

using System.Data.SqlClient;
using System.Configuration;
namespace d5;
public class d5
{
    public static void Main(String[] args)
    {

         string Connect = ConfigurationManager.ConnectionStrings["MyKey"].ConnectionString;
       // string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
        Console.WriteLine("Before Connection");
        SqlConnection sqlconn = new SqlConnection(Connect);
        Console.WriteLine(Connect);
        sqlconn.Open();
        Console.WriteLine("After Connection");
        SqlCommand cmd = new SqlCommand("PassInfo", sqlconn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        /*SqlDataReader dr = cmd.ExecuteReader();*/
        for (int i = 0; i<1; i++)
        {
           /* cmd.Parameters.Clear(); */
            Console.WriteLine("enter passport Number");
            String Passno = Console.ReadLine();
            cmd.Parameters.Add("@Passport_Number", System.Data.SqlDbType.Int).Value = Passno;

            Console.WriteLine("enter passport holder name");
            String Passname = Console.ReadLine();
            cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = Passname;

            Console.WriteLine("enter Expirydate");
            String ExpiryDate = Console.ReadLine();
            cmd.Parameters.Add("@ExpiryDate", System.Data.SqlDbType.Date).Value = ExpiryDate;

            Console.WriteLine("enter validity");
            String Validity = Console.ReadLine();
            cmd.Parameters.Add("@validity", System.Data.SqlDbType.Int).Value = Validity;

            Console.WriteLine("enter Channel");
            String Channel = Console.ReadLine();
            cmd.Parameters.Add("@Channel", System.Data.SqlDbType.VarChar).Value = Channel;
            cmd.ExecuteNonQuery();
        }
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

         cmd.Parameters.Clear();
        cmd.CommandText = "fetchinfo";
        SqlDataReader dr = cmd.ExecuteReader();
        Console.WriteLine("Table Created");
       while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString()+" "+ dr[3].ToString()+" "+ dr[4].ToString());
            /* Console.WriteLine(dr[0].ToString());
            Console.WriteLine(dr[1].ToString());
            Console.WriteLine(dr[2].ToString()); */
        }
            dr.Close();
        sqlconn.Close();
       
    }
}

/*answer2   slution 1 */
using System.Data.SqlClient;

namespace day5;


public class day5
{
    public static void Main(String[] args)
    {

        string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(Connect);
        sqlconn.Open();
        Console.WriteLine("enter yerar of study");
        String Year_Of_study = Console.ReadLine();
        SqlCommand cmd = new SqlCommand("student_information", sqlconn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.Parameters.Add("@year", System.Data.SqlDbType.Int).Value = Year_Of_study;
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());

        }
        dr.Close();
        sqlconn.Close();
    }
}
