/*ANaswer2 -->movie details*/
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace day5;
public class day5
{
    public static void Main(String[] args)
    {

        string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(Connect);
        sqlconn.Open();
        Console.WriteLine("enter a movieType");
        String Type =Console.ReadLine();
       SqlCommand cmd = new SqlCommand("select * from MovieDetails(@Type)", sqlconn);
         Console.WriteLine("Built string is"+cmd.CommandText.ToString());
        cmd.Parameters.Add("@Type", System.Data.SqlDbType.VarChar).Value = Type;
        cmd.CommandText.ToString();
        SqlDataReader dr=cmd.ExecuteReader();
       /*SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText.ToString(), sqlconn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            Console.WriteLine(dr[0].ToString());
            //Console.WriteLine(dr[1].ToString());
            //Console.WriteLine(dr[2].ToString());
            //Console.WriteLine(dr[3].ToString());
         }
       */
        while(dr.Read())
         {
             Console.WriteLine(dr[0].ToString()+" "+dr[1].ToString()+" "+ dr[2].ToString() +" "+ dr[3].ToString());
         }

         dr.Close();
        sqlconn.Close();
    }
}


/*output:
 Arundathi Balaji Prabhas horror
Anamika venkat George horror
The Rover vick nicolo horror
The Exorcist thrill John horror
Hallowen burgady Aadhrush  horror
Confession JOHN Das Raj Kumar  horror

 
 
 Chotabeem nick chotabheem Animation
Tom & jerry Vlad Micky Animation
Mr Bean bean geogre  Animation
Spider Man vick nicolo Animation
 Sea Beast iojsj venkat  Animation
Lion King Dil Raj uiosh Animation*/


/*answer1    Accounts answer*/
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace day5;


public class day5
{
public static void Main(String[] args)
{

string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
SqlConnection sqlconn = new SqlConnection(Connect);
sqlconn.Open();
Console.WriteLine("enter a balance");
String Balance = Console.ReadLine();
SqlCommand cmd = new SqlCommand("select * from AccDetails(@balance)", sqlconn);
Console.WriteLine("Built string is" + cmd.CommandText.ToString());
cmd.Parameters.Add("@Balance ", System.Data.SqlDbType.Int).Value = Balance;
//cmd.CommandText.ToString();
SqlDataReader dr = cmd.ExecuteReader();
/* SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText.ToString(), sqlconn);
 DataTable dt = new DataTable();
 da.Fill(dt);
 foreach (DataRow dr in dt.Rows)
 {
     Console.WriteLine(dr[0].ToString());
     //Console.WriteLine(dr[1].ToString());
     //Console.WriteLine(dr[2].ToString());
     //Console.WriteLine(dr[3].ToString());

 }
*/
while (dr.Read())
{ 
    Console.WriteLine(dr[0].ToString()+" "+dr[1].ToString()+" "+dr[2].ToString()+" "+ dr[3].ToString()+" "+dr[4].ToString() +  "  " + dr[5].ToString());
}

dr.Close();
sqlconn.Close();
}
}
