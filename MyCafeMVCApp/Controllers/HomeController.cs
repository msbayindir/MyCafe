using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCafe.Dtos.ProductDtos;
using MyCafeBusinessLayer.Interfaces;
using MyCafeMVCApp.Models;

namespace MyCafeMVCApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IProductService _productService;

    public HomeController(ILogger<HomeController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }
    public async Task<IActionResult> deneme()
    {
        var productList = await _productService.GetAll();
        return View(productList);
    }
    public async Task<IActionResult> Index()
    {
        var productList = await _productService.GetAll();
        return  View(productList);
    }
    public IActionResult Create()
    {
        return View(new ProductAddDto());
    }
    [HttpPost]
    public async Task<IActionResult> Create(ProductAddDto addDto,List<IFormFile> ProductImage)
    {
        if (ModelState.IsValid)
        {
            foreach (var item in ProductImage)
            {
                if (item.Length>0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await item.CopyToAsync(stream);
                        addDto.ProductImage = stream.ToArray();
                    }
                }
            }
            await _productService.Add(addDto);
            return RedirectToAction("Index");
        }
       
        return View(addDto);
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

