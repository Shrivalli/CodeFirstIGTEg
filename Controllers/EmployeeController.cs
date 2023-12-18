using codefirsteg;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    public class EmployeeController : Controller
    {
        private readonly CodeFirstIGTcontext db=new CodeFirstIGTcontext();
        // GET: EmployeeController
        public ActionResult GetAllEmployees()
        {
            return View(db.Employees.ToList());
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EmployeeController/Create
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult AddEmployee(Employee e)
        {
            try
            {
                if(ModelState.IsValid)
                {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction(nameof(GetAllEmployees));
                }
                else
                {
                    return View();
                }
            }
            catch(Exception e1)
            {
                Console.WriteLine(e1.Message);
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
