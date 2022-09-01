using Microsoft.AspNetCore.Mvc;

namespace solution1.Controllers
{
    public class SubjectController : Controller
    {
        public string check(int temp)
        {
            if (temp > 96 && temp <= 99)
                return $"normal";
            if (temp > 99 && temp <= 101)
                return $"Take home care";
            if (temp > 101)
                return $"Medical attention needed";
            else
                return $"check temperature again";
        }
    }
}
