
using Clase5.Data;
using Clase5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clase5.Controllers;
public class CarController : Controller
{
    private readonly CarContext _context;

    public CarController(CarContext serv)
    {
        this._context = serv;
    }

    public IActionResult Index()
    {
        var listado = _context.Cars.ToList();
        return View(listado);
    }

    public IActionResult Detail(int id)
    {
        if (id == null)
        {
            RedirectToAction("Index");
        }
        var value = _context.Cars.FirstOrDefault(x => x.Id == id);
        return View(value);
    }

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult OnPostCreate(Car value)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Create");
        }
        _context.Cars.Add(value);
        _context.SaveChanges();
        return RedirectToAction("Index");

    }

    public IActionResult Delete(int id)
    {
        var borrar = _context.Cars.FirstOrDefault(x => x.Id == id);

        _context.Cars.Remove(borrar);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var value = _context.Cars.FirstOrDefault(x => x.Id == id);
        return View(value);
    }

    public IActionResult OnPostEdit(Car item)
    {
        if (!ModelState.IsValid)
        {
            return RedirectToAction("Edit");
        }
        var value = _context.Cars.FirstOrDefault(x => x.Id == item.Id);
        _context.Cars.Remove(value);
        _context.Cars.Add(item);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}