using ScheduleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleUI.Services
{
	public class DataService
	{
		public List<Course> CurrentCourses { get; set; } = new List<Course>();
	}
}
