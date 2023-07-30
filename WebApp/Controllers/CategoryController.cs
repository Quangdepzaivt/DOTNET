using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
namespace WebApp.Controllers ;
public class CategoryController : Controller
{
    CategoryRepository repository ;
    public CategoryController(CategoryRepository repository)
    {
        this.repository = repository;
    }
    public IActionResult Index()
    {
        return View(repository.GetCategories());
    }
    [HttpPost]
    public IActionResult Add(Category obj)
    {
        int ret= repository.Add(obj);
        if (ret>0)
        {
            return Redirect("/category");
        }
        return Redirect("/category/error");
    }
    
}