using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using YazilimMuhendisligiProje.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace YazilimMuhendisligiProje.Dal.Initializer
{
    public class AppSeedController : Controller
    {

        private AppDbContext db;
        public AppSeedController(AppDbContext db)
        {
            this.db = db;
            Start();
        }
        private void Start()
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new AppDbContext()));
            manager.Create(new ApplicationUser { UserName = "ibrahimekinci", Email = "ibrahimekinci36@hotmail.com" }, ".standart");
            manager.Create(new ApplicationUser { UserName = "admin", Email = "info@admin.com.tr" }, "123456");
        }
    }
}
