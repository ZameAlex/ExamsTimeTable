using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ScheduleLib
{
    public class GroupTimetable
    {
        public string Group { get; private set; }
        public List<string> Days { get; set; }
        public List<string> Exams { get; set; }

        public GroupTimetable(string group)
        {
            Group = group;
            Days = new List<string>();
            Exams = new List<string>();
        }

        public void AddElement(string day, string examInfo)
        {
            Days.Add(day);
            Exams.Add(examInfo);
        }

        public string CreateTable()
        {
            XElement root = new XElement("table",
                new XAttribute("cellspacing", "0"),
                new XAttribute("cellpadding", "0"),
                new XAttribute("class", "rtab"));
            root.Add(CreateDaysTR());
            root.Add(CreateExamsTR());
	        return root.ToString();
        }

        private XElement CreateDaysTR()
        {
            var tr = new XElement("tr");
            tr.Add(CreateNbsp());
            foreach (var day in Days)
            {
                tr.Add(CreateDays(day));
            }
            return tr;
        }

        private XElement CreateExamsTR()
        {
            var tr = new XElement("tr");
            tr.Add(CreateGroup());
            foreach (var info in Exams)
            {
                tr.Add(CreateExamInfo(info));
            }
            return tr;
        }

        private XElement CreateDays(string day)
        {
            var res = new XElement("td", new XAttribute("class", "tdo2"));
            res.Value = day;
            return res;
        }

        private XElement CreateExamInfo(string info)
        {
            var res = new XElement("td", new XAttribute("class", "tdi2"), new XAttribute("rowspan", "3"));
            res.Value = @info;
            return @res;
        }

        private XElement CreateNbsp()
        {
            var res = new XElement("td", new XAttribute("height", "19"), new XAttribute("class", "tdo1"));
            res.Value = @"&nbsp;";
            return res;
        }

        private XElement CreateGroup()
        {
            var res = new XElement("td", new XAttribute("class", "tdo1"), new XAttribute("rowspan", "3"));
            res.Value = this.Group;
            return res;
        }
    }

}
