using System;
using System.Collections.Generic;
using System.Text;

namespace ScheduleUI.Models
{
	public  class Lesson
	{
		public string Name { get; set; }
		public string Class { get; set; }
		public string Teacher { get; set; }

		public Group Owner { get; set; }

		public string GetExamInfo()
		{
			return $"{Name}<\br>{Class}<br/>{Teacher}<br/>";
		}
	}
}
