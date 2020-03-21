using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeOP
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void CloseButtom_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void CloseButtom_MouseEnter(object sender, EventArgs e)
		{
			CloseButtom.ForeColor = Color.Black;
		}

		private void CloseButtom_MouseLeave(object sender, EventArgs e)
		{
			CloseButtom.ForeColor = Color.White;
		}

		Point lastPoint;
		private void MainPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void MainPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			RegisterForm registerForm = new RegisterForm();
			registerForm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm mainForm = new MainForm();
			mainForm.Show();
		}
	}
}
