using BDLab3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDLab3.Controllers
{
    public class HomeController : Controller
    {
        MyContext db = new MyContext();
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult Employee()
        {

            return View(db.Employees.ToList());
        }

        #region Wantknow

        public ActionResult WantKnow()
        {
            return View(db.Employees.ToList());
        }
        public ActionResult Pozitions()
        {
       
            return View(db.Positions.ToList());
        }
        public ActionResult Departments()
        {
            return View(db.Departments.ToList());
        }
        public ActionResult Educations()
        {
            return View(db.Educations.ToList());
        }
        public ActionResult Specialise()
        {
            return View(db.Specialty.ToList());
        }
        public ActionResult Penalties()
        {
            return View(db.Penalties.ToList());
        }
        public ActionResult Salaries()
        {
            return View(db.Salaries.ToList());
        }
        #endregion Wantknow

        #region Services
        public ActionResult Services()
        {
            return View(db.Employees.ToList());
        }

        #endregion

        #region Serach
        public ActionResult Search(int zp=0,int penalt =0, string education = null,string spec=null,string pos=null)
        {
            ViewBag.Zp = zp;
            ViewBag.Penalt = penalt;
            ViewBag.Edu = new SelectList(db.Educations, "Name", "Name");
            ViewBag.VEdu = education;
            ViewBag.Spec = new SelectList(db.Specialty, "Name", "Name");
            ViewBag.VSpec = spec;
            ViewBag.Pos = new SelectList(db.Positions, "Name", "Name");
            ViewBag.VPos = pos;
            return View(db.Employees.ToList());
        }

        #endregion


        #region CRUD

        #region Employee
        [HttpGet]
        public ActionResult CreateEmplo()
        {
            ViewBag.Edu = new SelectList(db.Educations, "Id", "Name");
            ViewBag.Spec = new SelectList(db.Specialty, "Id", "Name");
            ViewBag.Pos = new SelectList(db.Positions, "Id", "Name");
            ViewBag.Dep = new SelectList(db.Departments, "Id", "Name");
            ViewBag.Pen = new SelectList(db.Penalties, "Id", "Amount");
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmplo(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Employee");
        }

        public ActionResult DeleteEmplo(int id)
        {
            Employee temp = db.Employees.Find(id);
            db.Employees.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Employee");
        }
        [HttpGet]
        public ActionResult EditEmplo(int id)
        {

            ViewBag.Edu = new SelectList(db.Educations, "Id", "Name");
            ViewBag.Spec = new SelectList(db.Specialty, "Id", "Name");
            ViewBag.Pos = new SelectList(db.Positions, "Id", "Name");
            ViewBag.Dep = new SelectList(db.Departments, "Id", "Name");
            ViewBag.Pen = new SelectList(db.Penalties, "Id", "Amount");
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult EditEmplo(Employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Employee");
        }
        public ActionResult DetailsEmplo(int id)
        {
            ViewBag.Edu = new SelectList(db.Educations, "Id", "Name");
            ViewBag.Spec = new SelectList(db.Specialty, "Id", "Name");
            ViewBag.Pos = new SelectList(db.Positions, "Id", "Name");
            ViewBag.Dep = new SelectList(db.Departments, "Id", "Name");
            ViewBag.Pen = new SelectList(db.Penalties, "Id", "Amount");
            Employee employee = db.Employees.Find(id);
            return View(employee);
        }
        #endregion

        #region Positions
        public ActionResult CreatePos()
        {
            ViewBag.Salaries = new SelectList(db.Salaries, "Id", "Amount");

            return View();
        }
        [HttpPost]
        public ActionResult CreatePos(Position position)
        {
            db.Positions.Add(position);
            db.SaveChanges();
            return RedirectToAction("Pozitions");
        }
        public ActionResult EditPos(int id)
        {
            ViewBag.Salaries = new SelectList(db.Salaries, "Id", "Amount");
            Position place = db.Positions.Find(id);
            return View(place);
        }

        [HttpPost]
        public ActionResult EditPos(Position position)
        {
            db.Entry(position).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Pozitions");
        }
        public ActionResult DeletePos(int id)
        {
            Position temp = db.Positions.Find(id);
            db.Positions.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Pozitions");
        }
        #endregion

        #region Department

        public ActionResult CreateDep()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateDep(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Departments");
        }
        public ActionResult EditDep(int id)
        {
            Department departments = db.Departments.Find(id);
            return View(departments);
        }

        [HttpPost]
        public ActionResult EditDep(Department department)
        {
            db.Entry(department).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Departments");
        }
        public ActionResult DeleteDep(int id)
        {
            Department temp = db.Departments.Find(id);
            db.Departments.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Departments");
        }
        #endregion

        #region Penalties
        public ActionResult CreatePen()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreatePen(Penaltie penaltie)
        {
            db.Penalties.Add(penaltie);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }
        public ActionResult EditPen(int id)
        {
            Penaltie penaltie = db.Penalties.Find(id);
            return View(penaltie);
        }

        [HttpPost]
        public ActionResult EditPen(Penaltie penaltie)
        {
            db.Entry(penaltie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }
        public ActionResult DeletePen(int id)
        {
            Penaltie temp = db.Penalties.Find(id);
            db.Penalties.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Penalties");
        }
        #endregion

        #region Education
        public ActionResult CreateEdu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEdu(Education education)
        {
            db.Educations.Add(education);
            db.SaveChanges();
            return RedirectToAction("Educations");
        }
        public ActionResult EditEdu(int id)
        {
            Education educations = db.Educations.Find(id);
            return View(educations);
        }

        [HttpPost]
        public ActionResult EditEdu(Education education)
        {
            db.Entry(education).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Educations");
        }
        public ActionResult DeleteEdu(int id)
        {
            Education temp = db.Educations.Find(id);
            db.Educations.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Educations");
        }
        #endregion

        #region Speciality
        public ActionResult CreateSpec()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSpec(Specialty specialty)
        {
            db.Specialty.Add(specialty);
            db.SaveChanges();
            return RedirectToAction("Specialise");
        }
        public ActionResult EditSpec(int id)
        {
            Specialty specialty = db.Specialty.Find(id);
            return View(specialty);
        }

        [HttpPost]
        public ActionResult EditSpec(Specialty specialty)
        {
            db.Entry(specialty).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Specialise");
        }
        public ActionResult DeleteSpec(int id)
        {
            Specialty temp = db.Specialty.Find(id);
            db.Specialty.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Specialise");
        }
        #endregion

        #region Salarie
        public ActionResult CreateSal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSal(Salarie salarie)
        {
            db.Salaries.Add(salarie);
            db.SaveChanges();
            return RedirectToAction("Salaries");
        }
        public ActionResult EditSal(int id)
        {
            Salarie salarie = db.Salaries.Find(id);
            return View(salarie);
        }

        [HttpPost]
        public ActionResult EditSal(Salarie salarie)
        {
            db.Entry(salarie).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Salaries");
        }
        public ActionResult DeleteSal(int id)
        {
            Salarie temp = db.Salaries.Find(id);
            db.Salaries.Remove(temp);
            db.SaveChanges();
            return RedirectToAction("Salaries");
        }
        #endregion

        #endregion
    }
}