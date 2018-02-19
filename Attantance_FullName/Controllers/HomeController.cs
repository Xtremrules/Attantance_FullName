using Attantance_FullName.Models;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Attantance_FullName.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public async Task<ActionResult> logs()
        {
            var username = User.Identity.Name;
            var logs = await db.Logs.Where(x => x.AppUserID == username).ToListAsync();
            return View(logs);
        }
    }
}