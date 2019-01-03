using ScheduleLib;
using ScheduleLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleUI
{
	public partial class Form1 : Form
	{
		List<Course> Courses = new List<Course>();

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

		private void GroupClick(Group group)
		{
			Form2 form2 = new Form2(group);
			form2.ShowDialog();
		}

		private void AddKM1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[0].Divisions[0], KMList1.Items.Count + 1, 1);
			Courses[0].Divisions[0].Groups.Add(tmpGroup);
			KMList1.Items.Add(tmpGroup);
		}

		private void AddKV1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[0].Divisions[1], KVList1.Items.Count + 1, 1);
			Courses[0].Divisions[1].Groups.Add(tmpGroup);
			KVList1.Items.Add(tmpGroup);
		}

		private void AddKP1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[0].Divisions[2], KPList1.Items.Count + 1, 1);
			Courses[0].Divisions[2].Groups.Add(tmpGroup);
			KPList1.Items.Add(tmpGroup);
		}



		private void KMList1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void KPList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void KVList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[1].Divisions[0], (sender as ListBox).Items.Count + 1, 2);
			Courses[1].Divisions[0].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[1].Divisions[1], (sender as ListBox).Items.Count + 1, 2);
			Courses[1].Divisions[1].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[1].Divisions[2], (sender as ListBox).Items.Count + 1, 2);
			Courses[1].Divisions[2].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[2].Divisions[0], (sender as ListBox).Items.Count + 1, 3);
			Courses[2].Divisions[0].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[2].Divisions[1], (sender as ListBox).Items.Count + 1, 3);
			Courses[2].Divisions[1].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[2].Divisions[2], (sender as ListBox).Items.Count + 1, 3);
			Courses[2].Divisions[2].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}



		private void button9_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[3].Divisions[0], (sender as ListBox).Items.Count + 1, 4);
			Courses[3].Divisions[0].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[3].Divisions[1], (sender as ListBox).Items.Count + 1, 4);
			Courses[3].Divisions[1].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[3].Divisions[2], (sender as ListBox).Items.Count + 1, 4);
			Courses[3].Divisions[2].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[4].Divisions[0], (sender as ListBox).Items.Count + 1, 5);
			Courses[4].Divisions[0].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[4].Divisions[1], (sender as ListBox).Items.Count + 1, 5);
			Courses[4].Divisions[1].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[4].Divisions[2], (sender as ListBox).Items.Count + 1, 5);
			Courses[4].Divisions[2].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[5].Divisions[0], (sender as ListBox).Items.Count + 1, 6);
			Courses[5].Divisions[0].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[5].Divisions[1], (sender as ListBox).Items.Count + 1, 6);
			Courses[5].Divisions[1].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			var tmpGroup = new Group();
			tmpGroup.CreateName(Courses[5].Divisions[2], (sender as ListBox).Items.Count + 1, 6);
			Courses[5].Divisions[2].Groups.Add(tmpGroup);
			(sender as ListBox).Items.Add(tmpGroup);
		}

		private void listBox15_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox14_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void listBox13_SelectedIndexChanged(object sender, EventArgs e)
		{
			GroupClick((sender as ListBox).SelectedItem as Group);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			
			int courseCounter = 1;
			foreach (var course in Courses)
			{
				StreamWriter writer = new StreamWriter($"{courseCounter}.html");
				foreach (var division in course.Divisions)
				{
					foreach (var group in division.Groups)
					{
						GroupTimetable gtt = new GroupTimetable(group.Name);
						for (int i = 0; i < group.Days.Capacity; i++)
						{
							gtt.AddElement(group.Days[i].ToString("dd MMM ddd").ToLower(),
								group.Lessons[i].GetExamInfo());
						}
						writer.Write(gtt.CreateTable());
					}
				}
				courseCounter++;
				writer.Close();
			}
		}
	}
}
