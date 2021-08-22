using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UserDataBase.Models;
using UserDataBaseDAL.EFCore;
using UserDataBaseUI.Models;
using UserDataBaseBLL.Interfaces;
using UserDataBaseUI.Mapping;

namespace UserDataBase.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _service;
        public HomeController(IUserService service)
        {
            _service = service;
        }

        public async Task<ActionResult> Index()
        {
            var usersList = await Task.Run(() =>_service.GetUsers().MapToEnumerableUserView().ToList());

            return View(usersList);
        }

        public async Task<ActionResult> ShowDetails(int positionUserOfTableInView)
        {
            var user = await Task.Run(() => _service.GetUsers().FirstOrDefault(x => x.Id == positionUserOfTableInView));
            ViewBag.User = user.MapToViewUser();

            return PartialView();
        }


        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            var user = _service.GetUsers().FirstOrDefault(x => x.Id == id);

            if (user != null)
            {
                await Task.Run(() => _service.Delete(user));
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(UserViewModel user)
        {
            await Task.Run(() => _service.AddUser(user.MapToBLLUser()));

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
