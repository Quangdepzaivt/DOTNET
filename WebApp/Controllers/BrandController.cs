using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;
public class BrandController : Controller
{
    BrandRepository repository;
    public BrandController(BrandRepository repository){
        this.repository = repository;
    }
    

    public IActionResult Index(){
        List<Brand> list = repository.GetBrands();
        return View(list);
    }
}