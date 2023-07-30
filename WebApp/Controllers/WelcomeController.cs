using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;
public class WelcomeController : Controller
{
    public string Index(){
        return "Welcome Ladies and Gentlemen";
    }
    //welcome/hi
    //Views
    public IActionResult Hi(){
        return View();
    }
    public IActionResult Example(){

        Student s1 = new Student("456");
        s1.Name = "Thang";

        System.Console.WriteLine(s1.Password);

        Student s2 = new Student("123"){ Name  = "Thien", Email = "thien@cse.net.vn"};
        System.Console.WriteLine(s2.Name);
        System.Console.WriteLine(s2.Password);

        return View(s2);
    }
}