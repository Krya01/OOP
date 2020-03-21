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
	public partial class RegisterForm : Form
	{
		public RegisterForm()
		{
			InitializeComponent();

			UserSurnameField.Text = "Введите фамилию";
			UserSurnameField.ForeColor = Color.Gray;
			UserNameField.Text = "Введите имя";
			UserNameField.ForeColor = Color.Gray;
			UserGroupField.Text = "Введите вашу группу";
			UserGroupField.ForeColor = Color.Gray;
		}

		private void CloseButtom_Click(object sender, EventArgs e)
		{
			Application.Exit();
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

		private void UserSurnameField_Enter(object sender, EventArgs e)
		{
			if (UserSurnameField.Text == "Введите фамилию")
			{
				UserSurnameField.Text = "";
				UserSurnameField.ForeColor = Color.Black;
			}
		}
		private void UserSurnameField_Leave(object sender, EventArgs e)
		{
			if (UserSurnameField.Text == "")
			{
				UserSurnameField.Text = "Введите фамилию";
				UserSurnameField.ForeColor = Color.Gray;
			}
		}

		private void UserNameField_Enter(object sender, EventArgs e)
		{
			if (UserNameField.Text == "Введите имя")
			{
				UserNameField.Text = "";
				UserNameField.ForeColor = Color.Black;
			}
		}
		private void UserNameField_Leave(object sender, EventArgs e)
		{
			if (UserNameField.Text == "")
			{
				UserNameField.Text = "Введите имя";
				UserNameField.ForeColor = Color.Gray;
			}
		}

		private void UserGroupField_Enter(object sender, EventArgs e)
		{
			if (UserGroupField.Text == "Введите вашу группу")
			{
				UserGroupField.Text = "";
				UserGroupField.ForeColor = Color.Black;
			}
		}
		private void UserGroupField_Leave(object sender, EventArgs e)
		{
			if (UserGroupField.Text == "")
			{
				UserGroupField.Text = "Введите вашу группу";
				UserGroupField.ForeColor = Color.Gray;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			LoginForm loginForm = new LoginForm();
			loginForm.Show();
		}
	}
}
