using Microsoft.AspNetCore.Mvc;
using MVC_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly studentContext _DbData;

        public StudentController(studentContext dbdata)
        {
            _DbData = dbdata;
        }
        public IActionResult StudentList()
        {
            try
            {
                //var studentData = _DbData.student.ToList();
                var studentData = from a in _DbData.student
                                  join b in _DbData.degrees
                                  on a.DegreeId equals b.DegreeId
                                  into Data
                                  from b in Data.DefaultIfEmpty()

                                  select new student
                                  {
                                      StudentId = a.StudentId,
                                      FirstName = a.FirstName,
                                      LastName = a.LastName,
                                      DOB = a.DOB,
                                      Email = a.Email,
                                      Address = a.Address,
                                      Phone = a.Phone,
                                      Gender = a.Gender,
                                      Major = a.Major,
                                      DegreeId = a.DegreeId

                                  };
                return View(studentData);

            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex);
                return View();
            }
            
        }
    }
}
