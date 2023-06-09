using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class ItemsController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);
    }
    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/items")]
    public ActionResult Create(string itemName, string purchasedStatus, string packedStatus, int cost, int weight)
    {
      Item myItem = new Item(itemName, purchasedStatus, packedStatus, cost, weight);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Item.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Item foundItem = Item.Find(id);
      return View(foundItem);
    }
    // [HttpGet("/edit")]
    // public ActionResult Edit(int id)
    // {
    //   Item editItem = Item.Find(id);
    //   editItem.MarkItemAsPacked();
    //   return View (editItem);
    // }
  }

}