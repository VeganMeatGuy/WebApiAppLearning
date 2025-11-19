using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTestApp.Models;

namespace WebApiTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CounterController : ControllerBase
    {
        [HttpGet("New", Name = "GetCounter")]
        public Counter Get()
        {
            return new Counter() { Value = 0};
        }

        [HttpPatch("Value/up", Name = "PatchCounterValueUp")]
        public Counter PatchCounterValueUp(Counter counter)
        {
            counter.Value += 1;
            return counter;
        }
        
        [HttpPatch("Value/down", Name = "PatchCounterValueDown")]
        public Counter PatchCounterValueDown(Counter counter)
        {
            counter.Value -= 1;
            return counter;
        }



        //// GET: GroupController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: GroupController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: GroupController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: GroupController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GroupController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: GroupController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GroupController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: GroupController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
