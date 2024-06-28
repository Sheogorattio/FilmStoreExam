using FilmStoreExam.Interfaces;
using FilmStoreExam.Models;
using FilmStoreExam.Models.Pages;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IProduct _products;
    private readonly ICategory _categories;
    private readonly IActor _actors;

    public HomeController(IProduct products, ICategory categories, IActor actors)
    {
        _products = products;
        _categories = categories;
        _actors = actors;
    }
    //[HttpGet]
    //public IActionResult Index()
    //{
    //    return View(_products.GetAllProducts());
    //}
    [HttpGet]
    public IActionResult UpdateProduct(int id)
    {
        ViewBag.Categories = _categories.GetAllCategories();
        ViewBag.Actors = _actors.GetAllActors();
        return View(id == 0 ? new Product() : _products.GetProduct(id));
    }
    [HttpPost]
    public IActionResult UpdateProduct(Product product)
    {
        if (product.Id == 0)
        {
            _products.AddProduct(product);
        }
        else
        {
            _products.UpdateProduct(product);
        }
        return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    public IActionResult DeleteProduct(Product product)
    {
        _products.DeleteProduct(product);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public IActionResult Index(QueryOptions options)
    {
        ViewBag.Actors = _actors.GetAllActors().ToList();
        return View(_products.GetProducts(options));
    }
}