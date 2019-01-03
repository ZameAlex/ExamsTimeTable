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
	public partial class Form1 : Form
	{
		List<Course> Courses;
		public Form1()
		{
			for (int i = 0; i < 6; i++)
				Courses.Add(new Course()
					{
						Number = i + 1,
						Divisions = new List<Division>()
						{
							new Division()
							{
								Name = "КМ"
							},
							new Division()
							{
								Name = "КВ"
							},
							new Division()
							{
								Name = "КП"
							}

						}
					}
				);
			InitializeComponent();
		}

		private void AddKM1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.Name = $"КМ-{DateTime.Now.Year % 10}{KMList1.Items.Count + 1}";
			Courses[0].Divisions[0].Groups.Add(tmpGroup);
			ListViewItem lvi = new ListViewItem(tmpGroup.Name);
			KMList1.Items.Add(lvi);
		}

		private void AddKV1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.Name = $"КВ-{DateTime.Now.Year % 10}{KMList1.Items.Count + 1}";
			Courses[0].Divisions[1].Groups.Add(tmpGroup);
			ListViewItem lvi = new ListViewItem(tmpGroup.Name);
			KMList1.Items.Add(lvi);
		}

		private void AddKP1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.Name = $"КП-{DateTime.Now.Year % 10}{KMList1.Items.Count + 1}";
			Courses[0].Divisions[2].Groups.Add(tmpGroup);
			ListViewItem lvi = new ListViewItem(tmpGroup.Name);
			KMList1.Items.Add(lvi);
		}

		private void KMList1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
