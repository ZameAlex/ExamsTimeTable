using ScheduleLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUI
{
	public partial class Form2 : Form
	{
		Group currentGroup;
		public Form2(Group group)
		{
			currentGroup = group;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			currentGroup.Lessons = new List<Lesson>(Int32.Parse(textBox1.Text));
			currentGroup.Days = new List<DateTime>(Int32.Parse(textBox1.Text));
		}
	}
}
