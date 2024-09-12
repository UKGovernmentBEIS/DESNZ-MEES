using System.Diagnostics;
using Desnz.Mees.DataTool.Data.Repositories;
using Desnz.Mees.DataTool.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desnz.Mees.DataTool.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IEpcSummaryRepository _epcSummaryRepository;

    public HomeController(ILogger<HomeController> logger, IEpcSummaryRepository epcSummaryRepository)
    {
        _logger = logger;
        _epcSummaryRepository = epcSummaryRepository;
    }

    public async Task<IActionResult> Index()
    {
        var summaries = await _epcSummaryRepository.GetEpcSummaries("E08000034");
        return View(new EpcSummariesViewModel(){EpcNonDomestics = summaries});
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