using Domain.EntitiesDto;
using Microsoft.AspNetCore.Mvc;
using Services.EntitiesServices.DocumentServices;

namespace Web.RTSU.Task.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IDocumentService _documentService;
        private readonly ILogger<DocumentController> _logger;
        public DocumentController(IDocumentService documentService, ILogger<DocumentController> logger)
        {
            _documentService = documentService;
            _logger = logger;
        }
        // GET: DocumentController
        public async ValueTask<ActionResult> Index()
        {   
            var documents =
                await _documentService.GetAllAsync();
            return View(documents);
        }

        // GET: DocumentController/Details/5
        public async ValueTask<ActionResult<DepartmentDto>> Details(int id)
        {   var doc=
                await _documentService.GetByIdAsync(id);
            return View(doc);
        }

        // GET: DocumentController/Create
        public ActionResult Create()
        {
            var newDoc = new DocumentDto();
            return View(newDoc);
        }

        // POST: DocumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Create(DocumentDto dto)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    _logger.LogInformation("");
                    await _documentService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
                return View(dto);
            }
            catch
            {
                 _logger.LogError("");
                return View();
            }
        }

        // GET: DocumentController/Edit/5
        public async ValueTask<ActionResult> Edit(int id)
        {
            return View( await Details(id));
        }

        // POST: DocumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Edit(DocumentDto dto)
        {
            try
            {
                if (ModelState.IsValid){
                    await _documentService.UpdateAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
                return View(dto);
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Delete/5
        public async ValueTask<ActionResult> Delete(int id)
        {
            return View(await Details(id));
        }

        // POST: DocumentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<ActionResult> Delete(int id,byte n=0)
        {
            try
            {
                if (id != 0)
                {
                    _logger.LogInformation("");
                    await _documentService.DeleteByIdAsync(id);
                    return RedirectToAction(nameof(Index));
                }
                return View(id);
            }
            catch
            {
                return View();
            }
        }
    }
}
