using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using static DAY1.Pages.STUDENTModel;

namespace DAY1.Pages
{
    public class STUDENTModel : PageModel
    {
        public List<Movieinfo> Movielist = new List<Movieinfo>();
        public void OnGet()
        {
            try
                {
                string Connect = "data source=DESKTOP-FVEPOS4\\LIKITHA;initial catalog=students;trusted_connection=true";
                SqlConnection sqlconn = new SqlConnection(Connect);
                Console.WriteLine("BEFORE");
                sqlconn.Open();
                string qs = "select MovieName,Director,Actor,MovieType from Movieinfo";
                SqlCommand cmd = new SqlCommand(qs, sqlconn);
                Console.WriteLine("after");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Movieinfo db = new Movieinfo();
                    db.MovieName = dr.GetString(0);
                    Console.WriteLine(db.MovieName);
                    db.Director = dr.GetString(1);
                    Console.WriteLine(db.Director);
                    db.Actor = dr.GetString(2);
                    Console.WriteLine(db.Actor);
                    db.MovieType = dr.GetString(3);
                    Console.WriteLine(db.MovieType);
                    Movielist.Add(db);

                }

                }
            catch(Exception ex)
            {

            }
        }
        
        public class Movieinfo
        {
            public string  MovieName;
            public string Director;
            public string Actor;
            public string MovieType;

        }
    }
}
