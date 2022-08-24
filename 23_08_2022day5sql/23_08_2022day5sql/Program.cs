using System.Data.SqlClient;
namespace day5;


public class day5
{
    public static void Main(String[] args)
    {

        string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=master;trusted_connection=true";
        SqlConnection sqlconn = new SqlConnection(Connect);
        sqlconn.Open();
        SqlCommand cmd = new SqlCommand("PassportInfo", sqlconn);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //cmd.Parameters.Add("@BaseOffice",System.Data.SqlDbType.VarChar).Value=BaseOffice;
        /*cmd.Parameters.Add("@salary", System.Data.SqlDbType.VarChar).Value = sal;
        SqlDataReader dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
            /* Console.WriteLine(dr[0].ToString());
            Console.WriteLine(dr[1].ToString());
            Console.WriteLine(dr[2].ToString()); */
    }
    

    dr.Close();
        sqlconn.Close();
    }
}