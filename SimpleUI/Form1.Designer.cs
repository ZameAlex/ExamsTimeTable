namespace SimpleUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Course1 = new System.Windows.Forms.TabPage();
			this.Course2 = new System.Windows.Forms.TabPage();
			this.Course3 = new System.Windows.Forms.TabPage();
			this.Course4 = new System.Windows.Forms.TabPage();
			this.Course5 = new System.Windows.Forms.TabPage();
			this.Course6 = new System.Windows.Forms.TabPage();
			this.KM1 = new System.Windows.Forms.GroupBox();
			this.KV1 = new System.Windows.Forms.GroupBox();
			this.KP1 = new System.Windows.Forms.GroupBox();
			this.KMList1 = new System.Windows.Forms.ListView();
			this.KVList1 = new System.Windows.Forms.ListView();
			this.KPList1 = new System.Windows.Forms.ListView();
			this.AddKM1 = new System.Windows.Forms.Button();
			this.AddKV1 = new System.Windows.Forms.Button();
			this.AddKP1 = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.Course1.SuspendLayout();
			this.KM1.SuspendLayout();
			this.KV1.SuspendLayout();
			this.KP1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Course1);
			this.tabControl1.Controls.Add(this.Course2);
			this.tabControl1.Controls.Add(this.Course3);
			this.tabControl1.Controls.Add(this.Course4);
			this.tabControl1.Controls.Add(this.Course5);
			this.tabControl1.Controls.Add(this.Course6);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(776, 406);
			this.tabControl1.TabIndex = 0;
			// 
			// Course1
			// 
			this.Course1.Controls.Add(this.KP1);
			this.Course1.Controls.Add(this.KV1);
			this.Course1.Controls.Add(this.KM1);
			this.Course1.Location = new System.Drawing.Point(4, 22);
			this.Course1.Name = "Course1";
			this.Course1.Padding = new System.Windows.Forms.Padding(3);
			this.Course1.Size = new System.Drawing.Size(768, 380);
			this.Course1.TabIndex = 0;
			this.Course1.Text = "1";
			this.Course1.UseVisualStyleBackColor = true;
			// 
			// Course2
			// 
			this.Course2.Location = new System.Drawing.Point(4, 22);
			this.Course2.Name = "Course2";
			this.Course2.Padding = new System.Windows.Forms.Padding(3);
			this.Course2.Size = new System.Drawing.Size(768, 380);
			this.Course2.TabIndex = 1;
			this.Course2.Text = "2";
			this.Course2.UseVisualStyleBackColor = true;
			// 
			// Course3
			// 
			this.Course3.Location = new System.Drawing.Point(4, 22);
			this.Course3.Name = "Course3";
			this.Course3.Size = new System.Drawing.Size(768, 380);
			this.Course3.TabIndex = 2;
			this.Course3.Text = "3";
			this.Course3.UseVisualStyleBackColor = true;
			// 
			// Course4
			// 
			this.Course4.Location = new System.Drawing.Point(4, 22);
			this.Course4.Name = "Course4";
			this.Course4.Size = new System.Drawing.Size(768, 380);
			this.Course4.TabIndex = 3;
			this.Course4.Text = "4";
			this.Course4.UseVisualStyleBackColor = true;
			// 
			// Course5
			// 
			this.Course5.Location = new System.Drawing.Point(4, 22);
			this.Course5.Name = "Course5";
			this.Course5.Size = new System.Drawing.Size(768, 380);
			this.Course5.TabIndex = 4;
			this.Course5.Text = "5";
			this.Course5.UseVisualStyleBackColor = true;
			// 
			// Course6
			// 
			this.Course6.Location = new System.Drawing.Point(4, 22);
			this.Course6.Name = "Course6";
			this.Course6.Size = new System.Drawing.Size(768, 380);
			this.Course6.TabIndex = 5;
			this.Course6.Text = "6";
			this.Course6.UseVisualStyleBackColor = true;
			// 
			// KM1
			// 
			this.KM1.Controls.Add(this.AddKM1);
			this.KM1.Controls.Add(this.KMList1);
			this.KM1.Location = new System.Drawing.Point(29, 31);
			this.KM1.Name = "KM1";
			this.KM1.Size = new System.Drawing.Size(200, 278);
			this.KM1.TabIndex = 0;
			this.KM1.TabStop = false;
			this.KM1.Text = "КМ";
			// 
			// KV1
			// 
			this.KV1.Controls.Add(this.AddKV1);
			this.KV1.Controls.Add(this.KVList1);
			this.KV1.Location = new System.Drawing.Point(283, 31);
			this.KV1.Name = "KV1";
			this.KV1.Size = new System.Drawing.Size(200, 278);
			this.KV1.TabIndex = 1;
			this.KV1.TabStop = false;
			this.KV1.Text = "КВ";
			// 
			// KP1
			// 
			this.KP1.Controls.Add(this.AddKP1);
			this.KP1.Controls.Add(this.KPList1);
			this.KP1.Location = new System.Drawing.Point(537, 31);
			this.KP1.Name = "KP1";
			this.KP1.Size = new System.Drawing.Size(200, 278);
			this.KP1.TabIndex = 1;
			this.KP1.TabStop = false;
			this.KP1.Text = "КП";
			// 
			// KMList1
			// 
			this.KMList1.Location = new System.Drawing.Point(37, 30);
			this.KMList1.Name = "KMList1";
			this.KMList1.Size = new System.Drawing.Size(121, 171);
			this.KMList1.TabIndex = 0;
			this.KMList1.UseCompatibleStateImageBehavior = false;
			this.KMList1.SelectedIndexChanged += new System.EventHandler(this.KMList1_SelectedIndexChanged);
			// 
			// KVList1
			// 
			this.KVList1.Location = new System.Drawing.Point(37, 30);
			this.KVList1.Name = "KVList1";
			this.KVList1.Size = new System.Drawing.Size(121, 171);
			this.KVList1.TabIndex = 1;
			this.KVList1.UseCompatibleStateImageBehavior = false;
			// 
			// KPList1
			// 
			this.KPList1.Location = new System.Drawing.Point(45, 30);
			this.KPList1.Name = "KPList1";
			this.KPList1.Size = new System.Drawing.Size(121, 171);
			this.KPList1.TabIndex = 2;
			this.KPList1.UseCompatibleStateImageBehavior = false;
			// 
			// AddKM1
			// 
			this.AddKM1.Location = new System.Drawing.Point(119, 228);
			this.AddKM1.Name = "AddKM1";
			this.AddKM1.Size = new System.Drawing.Size(75, 23);
			this.AddKM1.TabIndex = 1;
			this.AddKM1.Text = "Add";
			this.AddKM1.UseVisualStyleBackColor = true;
			this.AddKM1.Click += new System.EventHandler(this.AddKM1_Click);
			// 
			// AddKV1
			// 
			this.AddKV1.Location = new System.Drawing.Point(119, 228);
			this.AddKV1.Name = "AddKV1";
			this.AddKV1.Size = new System.Drawing.Size(75, 23);
			this.AddKV1.TabIndex = 2;
			this.AddKV1.Text = "Add";
			this.AddKV1.UseVisualStyleBackColor = true;
			this.AddKV1.Click += new System.EventHandler(this.AddKV1_Click);
			// 
			// AddKP1
			// 
			this.AddKP1.Location = new System.Drawing.Point(119, 228);
			this.AddKP1.Name = "AddKP1";
			this.AddKP1.Size = new System.Drawing.Size(75, 23);
			this.AddKP1.TabIndex = 3;
			this.AddKP1.Text = "Add";
			this.AddKP1.UseVisualStyleBackColor = true;
			this.AddKP1.Click += new System.EventHandler(this.AddKP1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Schedule";
			this.tabControl1.ResumeLayout(false);
			this.Course1.ResumeLayout(false);
			this.KM1.ResumeLayout(false);
			this.KV1.ResumeLayout(false);
			this.KP1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Course1;
		private System.Windows.Forms.GroupBox KP1;
		private System.Windows.Forms.ListView KPList1;
		private System.Windows.Forms.GroupBox KV1;
		private System.Windows.Forms.ListView KVList1;
		private System.Windows.Forms.GroupBox KM1;
		private System.Windows.Forms.ListView KMList1;
		private System.Windows.Forms.TabPage Course2;
		private System.Windows.Forms.TabPage Course3;
		private System.Windows.Forms.TabPage Course4;
		private System.Windows.Forms.TabPage Course5;
		private System.Windows.Forms.TabPage Course6;
		private System.Windows.Forms.Button AddKP1;
		private System.Windows.Forms.Button AddKV1;
		private System.Windows.Forms.Button AddKM1;
	}
}

