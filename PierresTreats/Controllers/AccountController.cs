using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
//using PierresTreats.ViewModels;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
  public class AccountController : Controller
  {
    private readonly PierresTreatsContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(PierresTreatsContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
      _db = db;
      _userManager = userManager;
      _signInManager = signInManager;
    }

    public ActionResult Index()
    {
      return View();
    }
  }
}