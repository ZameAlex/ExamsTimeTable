using System;
using System.Collections.Generic;
using System.IO;

namespace ExamShedule
{
	class Program
	{
		static void Main(string[] args)
		{
			StreamWriter writer = new StreamWriter("1.html");
			Shceduler sc = new Shceduler();
			Console.WriteLine("Enter course");
			Int32.TryParse(Console.ReadLine(), out int course);
			sc.Year = course;
			Console.WriteLine("Enter department");
			string department = Console.ReadLine();
			sc.Department = department;
			Console.WriteLine("Enter number of groups");
			Int32.TryParse(Console.ReadLine(), out int groupsCount);
			sc.GroupsCount = groupsCount;
			Console.WriteLine("Enter exams count");
			Int32.TryParse(Console.ReadLine(), out int examsCount);
			List<Lesson> lessons = new List<Lesson>();
			for (int i = 0; i < examsCount; i++)
			{
				Lesson tmp = new Lesson();
				Console.WriteLine("Enter lesson name");
				tmp.Name = Console.ReadLine();
				Console.WriteLine("Enter teacher name");
				tmp.Teacher = Console.ReadLine();
				Console.WriteLine("Enter class");
				tmp.Class = Console.ReadLine();
				lessons.Add(tmp);
			}
			for (int group = 0; group < groupsCount; group++)
			{
				Console.WriteLine($"For {group + 1} group:");
				List<int> dates = new List<int>();
				for (int i = 0; i < examsCount; i++)
				{
					Console.WriteLine("Enter day");
					Int32.TryParse(Console.ReadLine(), out int date);
					dates.Add(date);
				}
				var temp = sc.CreateRow(group+1, dates, lessons);
				temp = temp.Replace(@"&lt;", "<").Replace(@"&gt;", ">").Replace(@"&amp;", "&") + "\n";
				writer.Write(temp);
			}
			writer.Close();

		}
	}
}
