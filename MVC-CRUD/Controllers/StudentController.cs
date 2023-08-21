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
                                      Degree = b ==null?"":b.DegreeName

                                  };
                return View(studentData);

            }
            catch(Exception ex)
            {
                //Console.WriteLine(ex);
                return View();
            }
            
        }

        public IActionResult Create()
        {
            LoadDegrees();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(student obj)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (_DbData.student.Any(s => s.Email == obj.Email))
                    {
                        ModelState.AddModelError("Email", "Email already exists.");
                    }
                    else
                    {
                        _DbData.student.Add(obj);
                        await _DbData.SaveChangesAsync();
                        return RedirectToAction("StudentList");
                    }
                }

                LoadDegrees();
                return View("Create", obj); // Return to the create view with the model data and error message
            }
            catch (Exception ex)
            {
                // Handle exception here if needed
            }

            // If an error occurred, return the same view with the model data and error message
            LoadDegrees();
            return View("Create", obj);
        }



        private void LoadDegrees()
        {
            try
            {
                List<degree> degrees = new List<degree>();
                degrees = _DbData.degrees.ToList();
                degrees.Insert(0, new degree { DegreeId = 0, DegreeName = "Please Select" });

                ViewBag.Degrees = degrees;

            }
            catch (Exception ex)
            {

            }
        }

        private bool CheckEmail(string emal)
        {
            try
            {
                List<student> emails = new List<student>();
                emails = _DbData.student.ToList();
                var allEmails = emails.Select(student => student.Email).ToList();
                if (allEmails.Contains(emal))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
