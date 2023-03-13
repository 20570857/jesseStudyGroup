using jesseStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jesseStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>
        {
            new Student() { StudentNumber = "u20570857", StudentName = "Jesse", StudentSurname = "Kotze", StudentEmail = "jesse.kotze@tuks.co.za" } ,
            new Student() { StudentNumber = "u19054708", StudentName = "John", StudentSurname = "Doe", StudentEmail = "john.doe@tuks.co.za" } ,
            new Student() { StudentNumber = "u18652589", StudentName = "Dillan", StudentSurname = "Drake", StudentEmail = "dillan.drake@tuks.co.za" } ,
            new Student() { StudentNumber = "u20258450", StudentName = "Kate", StudentSurname = "Moss", StudentEmail = "kate.moss@tuks.co.za" } ,
            new Student() { StudentNumber = "u21055848", StudentName = "Frank", StudentSurname = "Felix", StudentEmail = "frank.felix@tuks.co.za" }
        };
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }
    }
}