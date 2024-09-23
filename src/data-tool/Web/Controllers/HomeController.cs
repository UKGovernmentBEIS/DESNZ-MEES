using System.Diagnostics;
using Desnz.Mees.DataTool.Data.Repositories;
using Desnz.Mees.DataTool.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desnz.Mees.DataTool.Web.Controllers;

public class HomeController(ILogger<HomeController> logger, IEpcSummaryRepository epcSummaryRepository)
    : Controller
{

    public async Task<IActionResult> Index()
    {
        logger.LogInformation("Index called");
        var summaries = await epcSummaryRepository.GetEpcSummaries("E08000025", 10);
        return View(new EpcSummariesViewModel{EpcNonDomestics = summaries});
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