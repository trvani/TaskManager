using FireSharp.Config;
using FireSharp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace TaskManager.Controllers
{
    public class Tb_User : Controller
    {
        IFirebaseConfig Config = new FirebaseConfig();

        public IActionResult Index()
        {
            return View();
        }
    }
}
