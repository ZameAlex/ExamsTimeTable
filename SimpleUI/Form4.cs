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
	public partial class Form4 : Form
	{
		private Group group;
		public Form4(Group group)
		{
			this.group = group;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			group.Days.Add(dateTimePicker1.Value);
			group.Lessons.Add(new Lesson()
			{
				Name = textBox1.Text,
				Class = textBox2.Text,
				Teacher = textBox3.Text
			});
			this.Close();
		}
	}
}
