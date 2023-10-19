using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    private readonly ToDoListContext _db;

    public HomeController(ToDoListContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Tag[] tags = _db.Tags.ToArray();
      Item[] items = _db.Items.ToArray();
      Dictionary<string, object[]> model = new Dictionary<string, object[]>();
      model.Add("tags", tags);
      model.Add("items", items);
      return View(model);
    }
  }
}