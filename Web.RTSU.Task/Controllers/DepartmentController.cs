using Domain.EntitiesDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.EntitiesServices.DepartmentServices;

namespace Web.RTSU.Task.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        // GET: DepartmentController
        public async Task<ActionResult> Index()
        {
            var list = await _departmentService.GetAllAsync();
            return View(list);
        }

        // GET: DepartmentController/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var d = await _departmentService.GetByIdAsync(id);
            return View(d);
        }

        // GET: DepartmentController/Create
        public ActionResult Create()
        {
            return View(new DepartmentDto());
        }

        // POST: DepartmentController/Create
        [HttpPost]
        public async Task<ActionResult> Create(DepartmentDto dto)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _departmentService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
                return View(dto);
                
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: DepartmentController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var d = await _departmentService.GetByIdAsync(id);
            return View(d);
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(DepartmentDto department)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _departmentService.UpdateAsync(department);
                    return RedirectToAction(nameof(Index));
                }
                return View(department);

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: DepartmentController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var d = await _departmentService.GetByIdAsync(id);
            return View(d);
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id,int n=0)
        {
            try
            {   
                await _departmentService.DeleteByIdAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
