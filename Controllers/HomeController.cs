using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Models;

namespace Ecommerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    //Eyeglasses
    public IActionResult Eyeglasses()
    {
        return View();
    }

    public IActionResult MenEyeglasses()
    {
        return View();
    }

    public IActionResult WomenEyeglasses()
    {
        return View();
    }

    //Sunglasses
    public IActionResult Sunglasses()
    {
        return View();
    }

    public IActionResult MenSunglasses()
    {
        return View();
    }

    public IActionResult WomenSunglasses()
    {
        return View();
    }

    //Brands
    public IActionResult Brands()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

