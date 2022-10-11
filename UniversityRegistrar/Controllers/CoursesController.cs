// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.AspNetCore.Mvc;
// using UniversityRegistrar.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace UniversityRegistrar.Controllers
// {
//   public class CoursesController : Controller
//   {
//     private readonly UniversityRegistrarContext _db;

//     public CoursesController(UniversityRegistrarContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index ()
//     {
//       return View(_db.Courses.ToList());
//     }

//     public ActionResult Create()
//     {
//       ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "Name");
//       return View();
//     }


//   }
// }