using Domain.EntitiesDto;
using Domain.EntitiesDto.EmployeeDTOs;
using Microsoft.AspNetCore.Mvc;
using Services.EntitiesServices.DepartmentServices;
using Services.EntitiesServices.EmployeeServices;

namespace Web.RTSU.Task.Controllers
{
    public class EmployeeController : Controller
    {  
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IDepartmentService _departmentService;
        public EmployeeController(IEmployeeService service,
           ILogger<EmployeeController> logger,
           IDepartmentService dservice)
        {
            _employeeService = service;
            _logger = logger;
            _departmentService = dservice;
        }
        // GET: EmployeeController
        public async ValueTask<ActionResult> Index()
        {
            var employees =
                await _employeeService.GetEmployees();

            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public async ValueTask<ActionResult<GetEmployeeDto>> Details(int id)
        {
            var employee =
                await _employeeService.GetEmployeeById(id);

            return View(employee);
        }

        // GET: EmployeeController/Create
        public async ValueTask<ActionResult> Create()
        {
            var departments =
                await _departmentService.GetAllAsync();

            ViewBag.Departments = departments;

            var employee =
                new EmployeeDto();

            return View(employee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Create(EmployeeDto employee)
        {
            var departments =
                await _departmentService.GetAllAsync();

            ViewBag.Departments = departments;

            try
            {
                if (ModelState.IsValid)
                {
                    await _employeeService.InsertAsync(employee);
                    return RedirectToAction(nameof(Index));
                }
                
                return View(employee);
            }
            catch(Exception ex )
            {
                _logger.LogError(ex.Message, "в коде есть ошибка ");

                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public async ValueTask<ActionResult> Edit(int id)
        {
            var departments =
                await _departmentService.GetAllAsync();

            ViewBag.Departments = departments;

            var employee = await Details(id);

            return View(employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Edit(EmployeeDto employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _employeeService.UpdateAsync(employee);
                    return RedirectToAction(nameof(Index));
                }
                else if(employee.Image == null)
                {
                    await _employeeService.UpdateAsync(employee);
                    return RedirectToAction(nameof(Index));
                }
                return View(employee);
                
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message, "");
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public async ValueTask<ActionResult> Delete(int id)
        {  
            var employee = await Details(id);

            return View(employee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Delete(int id,byte i=0)
        {
            try
            {
                if(id != 0)
                {  
                    await _employeeService.DeleteByIdAsync(id);
                    return RedirectToAction(nameof(Index));
                }
                return View(id);
            }
            catch(Exception? ex)
            {
                _logger.LogError(ex.Message, "");
                return View();
            }
        }
    }
}
