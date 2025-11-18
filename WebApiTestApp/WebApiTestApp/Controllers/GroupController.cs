using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTestApp.Models;

namespace WebApiTestApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        [HttpGet(Name = "GetPerson")]
        public IEnumerable<Group> Get([FromQuery] IEnumerable<string> PersonNames, int GroupSize)
        {
            ///ich weis wie viele leute ich habe
            ///ich weiß wie gro due gruppen sein sollen
            ///wenn meine Anzahl Personen nicht durch die Gruppengroße teilbar ist, 
            ///
            ///--> sollen übrige personen auf bestehende gruppen verteilt werden
            ///ich muss ermitteln, wie viele Personen werden übrig bleiben
            ///was ist die neue Gruppengroße
            ///aufteilen der personen nach neuer Gruppengröße

            ///teile anzahl personen durch Gruppengröße, dann abrunden, mindestens aber eins
            ///Bsp  7 Personen / 2 = 3,5 ==> 3 Gruppen
            ///
            ///ermittle Überhangmandate 7 Personen - (Anzahl Gruppen * Gruppengröße)
            ///Bsp 7 - (3 * 2) = 1 ==> Bedeutet 1 Überhangmandat

            ///fülle die Gruppen mit der Anzahl an leuten anhandf der gruppengröße
            ///wenn ünberhangmandate übrig, hole dir diese von "hinten"



            List<string> shuffled = new List<string>(PersonNames.OrderBy(x => Guid.NewGuid()).ToList());

            int PersonAmount = shuffled.Count();
            decimal GroupAmountExcact = (decimal)shuffled.Count() / (decimal)GroupSize;
            int GroupAmount = Convert.ToInt16(Math.Round(GroupAmountExcact, 0, MidpointRounding.ToNegativeInfinity));
            if (GroupAmount < 1)
                GroupAmount = 1;

            int OverHangPersonAmount = PersonAmount - (GroupSize * GroupAmount);

            List<Group> result = new List<Group>();

            for (int i = 0; i < GroupAmount; i++)
            {
                int StartGruppe = GroupSize * i;
                List<Person> Persons = new List<Person>();

                for (int j = 1; j <= GroupSize; j++)
                {
                    if (StartGruppe + j <= shuffled.Count())
                        Persons.Add(new Person() { Name = shuffled.ToList()[StartGruppe + j - 1] });
                }
just 
                if(OverHangPersonAmount != 0)
                { 
                    Persons.Add(new Person() { Name = shuffled.ToList()[PersonAmount - OverHangPersonAmount] });
                    OverHangPersonAmount--;
                }

                result.Add(new Group() { GroupNumber = i + 1, Members = Persons });
            }
            return result;
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
