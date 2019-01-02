
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamShedule
{
	class Shceduler
	{
		public string Department { get; set; }
		public int GroupsCount { get; set; }
		public int Year { get; set; }


		public string CreateRow(int group, List<int> dates, List<Lesson> lessons)
		{
			GroupTimetable gt = new GroupTimetable($"{Department}-{DateTime.Today.Year%10}{group}");
			for (int exam = 0; exam < dates.Count; exam++)
			{
				DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, dates[exam]);
				var day = dt.ToString("dd MMMM ddd").ToLower() ;
				var examInfo = lessons[exam].Name+"<br/>"+ lessons[exam].Class+"<br/>" +lessons[exam].Teacher+"</br>";
				
				gt.AddElement(day, examInfo);
				
			}
			return gt.CreateTable();
		}
	}
}
