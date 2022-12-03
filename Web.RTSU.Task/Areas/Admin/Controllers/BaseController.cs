using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.RTSU.Task.Areas.Admin.Controllers
{
    //[Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class BaseController : Controller
    {
        
    }
}
