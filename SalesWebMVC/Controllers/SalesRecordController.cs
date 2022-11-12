using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;
using System;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class SalesRecordController : Controller
    {
        public readonly SalesRecordService _salesRecordService;
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            var list = await _salesRecordService.FindByDateAsync(minDate, maxDate);
            return View(list);
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }

    }
}
