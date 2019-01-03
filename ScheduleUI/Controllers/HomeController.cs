using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScheduleUI.Models;
using ScheduleUI.Services;

namespace ScheduleUI.Controllers
{
	public class HomeController : Controller
	{

		DataService service;

		public HomeController(DataService service)
		{
			this.service = service;
		}
		[HttpGet]
		public IActionResult Index()
		{
			return View("Course",service.CurrentCourses);
		}

		[HttpGet]
		public IActionResult AddCourse()
		{
			return View("AddCourse");
		}

		[HttpPost]
		public IActionResult AddCourse(Course course)
		{
			service.CurrentCourses.Add(course);
			return View("Course");
		}

		[HttpPost]
		public IActionResult Division(Division division)
		{
			//service.CurrentCourse.Divisions.Add(division);
			return View();
		}
		public IActionResult GroupsCount()
		{
			return View();
		}
		public IActionResult ExamsCount()
		{
			return View();
		}
		public IActionResult SetExams()
		{
			return View();
		}


	}
}
