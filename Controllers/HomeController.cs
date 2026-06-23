using DemoApp.Model;
using DemoApp.Employee;
using Microsoft.AspNetCore.Mvc;
namespace DemoApp.Controllers;

public class HomeController(EmpModel model) : Controller
{
    public IActionResult Index()
    {
        var employees = model.FetchEmployees();
        return View(employees);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Emp emp)
    {
        model.AcceptEmplyee(emp.Id, emp.ENAME, emp.JOB, emp.MGR, emp.HIREDATE, emp.SAL, emp.COMM, emp.DEPTID);
        return RedirectToAction("Index");
    }
}