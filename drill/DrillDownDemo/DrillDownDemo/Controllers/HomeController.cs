using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DrillDownDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
              List<Models.Student> Students = new List<Models.Student>()
            {
                new Models.Student
                { ID = 1, FirstName = "Jhon", LastName = "Smith",
                            Courses = new List<Models.Course>()
                            {
                                new Models.Course { ID = 1,
                            CourseName = "CS 101",
                            SemesterName = "Winter 2010"
                          },
                                new Models.Course { ID = 2,
                            CourseName = "MATH 102",
                             SemesterName = "Fall 2010"
                          },
                                new Models.Course { ID = 3,
                            CourseName = "ENG 103",
                            SemesterName = "Winter 2011"
                          },
                                new Models.Course { ID = 4,
                            CourseName = "EE 104",
                            SemesterName = "Fall 2012"
                          }
                            }
                },
                new Models.Student
                { ID = 2, FirstName = "Jorge", LastName = "Garcia",
                            Courses = new List<Models.Course>()
                            {
                                new Models.Course { ID = 5,
                            CourseName = "CS 205",
                            SemesterName = "Winter 2010"
                          },
                                new Models.Course { ID = 6,
                            CourseName = "MATH 206",
                            SemesterName = "Fall 2010"
                          },
                                new Models.Course { ID = 7,
                            CourseName = "ENG 207",
                            SemesterName = "Winter 2011"
                          },
                                new Models.Course { ID = 8,
                            CourseName = "EE 208",
                            SemesterName = "Fall 2012"
                          }
                            }
                },
                new Models.Student
                { ID = 3, FirstName = "Gorge", LastName = "Klene",
                            Courses = new List<Models.Course>()
                            {
                                new Models.Course { ID = 9,
                            CourseName = "CS 301",
                            SemesterName = "Winter 2010"
                          },
                                new Models.Course { ID = 10,
                            CourseName = "MATH 302",
                            SemesterName = "Fall 2010"
                          },
                                new Models.Course { ID = 11,
                            CourseName = "ENG 303",
                            SemesterName = "Winter 2011"
                          },
                                new Models.Course { ID = 12,
                            CourseName = "EE 304",
                            SemesterName = "Fall 2012"
                          }
                            }
                }
                 };



            return View(Students);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
       

    }
}