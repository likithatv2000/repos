using Microsoft.AspNetCore.Mvc;

namespace solution2.Controllers
{
    public class HomeController : Controller
    {
        string books = ""; public string display(string subject)
        {            /*if(subject == "History")            {                books = Historybooks();            }            if (subject == "Mathematics")            {                books = Mathsbooks();            }            if (subject == "Computer")            {                books = Computerbooks();            }*/
            switch (subject) { case "History": books = Historybooks(); break; case "Mathematics": books = Mathsbooks(); break; case "Computer": books = Computerbooks(); break; default: books = "no such subject found"; break; }
            return books;
        }
        public string Historybooks() { return $"World War  1 \n World war 2 \n The Empire 3"; }
        public string Mathsbooks() { return $"Alzebra \n Regular Expressions \nCalculus"; }
        public string Computerbooks() { return $"HTML \nCSS \njava script"; }

    }
}
