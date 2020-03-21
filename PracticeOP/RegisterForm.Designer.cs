namespace PracticeOP
{
	partial class RegisterForm
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
			this.MainPanel = new System.Windows.Forms.Panel();
			this.UserGroupField = new System.Windows.Forms.TextBox();
			this.UserNameField = new System.Windows.Forms.TextBox();
			this.UserSurnameField = new System.Windows.Forms.TextBox();
			this.RepeatPassField = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.PassField = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.CloseButtom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.MainPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(9)))), ((int)(((byte)(103)))));
			this.MainPanel.Controls.Add(this.linkLabel1);
			this.MainPanel.Controls.Add(this.UserGroupField);
			this.MainPanel.Controls.Add(this.UserNameField);
			this.MainPanel.Controls.Add(this.UserSurnameField);
			this.MainPanel.Controls.Add(this.RepeatPassField);
			this.MainPanel.Controls.Add(this.label7);
			this.MainPanel.Controls.Add(this.label6);
			this.MainPanel.Controls.Add(this.label5);
			this.MainPanel.Controls.Add(this.label4);
			this.MainPanel.Controls.Add(this.button1);
			this.MainPanel.Controls.Add(this.label3);
			this.MainPanel.Controls.Add(this.PassField);
			this.MainPanel.Controls.Add(this.label2);
			this.MainPanel.Controls.Add(this.LoginField);
			this.MainPanel.Controls.Add(this.panel2);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(580, 561);
			this.MainPanel.TabIndex = 1;
			this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
			this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
			// 
			// UserGroupField
			// 
			this.UserGroupField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.UserGroupField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserGroupField.Location = new System.Drawing.Point(181, 206);
			this.UserGroupField.Name = "UserGroupField";
			this.UserGroupField.Size = new System.Drawing.Size(271, 37);
			this.UserGroupField.TabIndex = 13;
			this.UserGroupField.Enter += new System.EventHandler(this.UserGroupField_Enter);
			this.UserGroupField.Leave += new System.EventHandler(this.UserGroupField_Leave);
			// 
			// UserNameField
			// 
			this.UserNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.UserNameField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserNameField.Location = new System.Drawing.Point(181, 163);
			this.UserNameField.Name = "UserNameField";
			this.UserNameField.Size = new System.Drawing.Size(271, 37);
			this.UserNameField.TabIndex = 12;
			this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
			this.UserNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
			// 
			// UserSurnameField
			// 
			this.UserSurnameField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.UserSurnameField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserSurnameField.Location = new System.Drawing.Point(181, 120);
			this.UserSurnameField.Name = "UserSurnameField";
			this.UserSurnameField.Size = new System.Drawing.Size(271, 37);
			this.UserSurnameField.TabIndex = 11;
			this.UserSurnameField.Enter += new System.EventHandler(this.UserSurnameField_Enter);
			this.UserSurnameField.Leave += new System.EventHandler(this.UserSurnameField_Leave);
			// 
			// RepeatPassField
			// 
			this.RepeatPassField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.RepeatPassField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RepeatPassField.Location = new System.Drawing.Point(277, 409);
			this.RepeatPassField.Name = "RepeatPassField";
			this.RepeatPassField.PasswordChar = '•';
			this.RepeatPassField.Size = new System.Drawing.Size(271, 37);
			this.RepeatPassField.TabIndex = 10;
			this.RepeatPassField.UseSystemPasswordChar = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(27, 411);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(244, 35);
			this.label7.TabIndex = 9;
			this.label7.Text = "Повторите пароль:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(66, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 35);
			this.label6.TabIndex = 8;
			this.label6.Text = "Группа:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(46, 122);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(129, 35);
			this.label5.TabIndex = 7;
			this.label5.Text = "Фамилия:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(102, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 35);
			this.label4.TabIndex = 6;
			this.label4.Text = "Имя:";
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(0, 522);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(580, 39);
			this.button1.TabIndex = 5;
			this.button1.Text = "Зарегистрироваться";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(156, 365);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 35);
			this.label3.TabIndex = 4;
			this.label3.Text = "Пароль:";
			// 
			// PassField
			// 
			this.PassField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.PassField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PassField.Location = new System.Drawing.Point(277, 366);
			this.PassField.Name = "PassField";
			this.PassField.PasswordChar = '•';
			this.PassField.Size = new System.Drawing.Size(271, 37);
			this.PassField.TabIndex = 3;
			this.PassField.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(175, 325);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 35);
			this.label2.TabIndex = 2;
			this.label2.Text = "Логин:";
			// 
			// LoginField
			// 
			this.LoginField.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.LoginField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginField.Location = new System.Drawing.Point(277, 326);
			this.LoginField.Multiline = true;
			this.LoginField.Name = "LoginField";
			this.LoginField.Size = new System.Drawing.Size(271, 34);
			this.LoginField.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.CloseButtom);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(580, 74);
			this.panel2.TabIndex = 0;
			// 
			// CloseButtom
			// 
			this.CloseButtom.AutoSize = true;
			this.CloseButtom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButtom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButtom.ForeColor = System.Drawing.Color.White;
			this.CloseButtom.Location = new System.Drawing.Point(558, 0);
			this.CloseButtom.Name = "CloseButtom";
			this.CloseButtom.Size = new System.Drawing.Size(22, 23);
			this.CloseButtom.TabIndex = 2;
			this.CloseButtom.Text = "X";
			this.CloseButtom.Click += new System.EventHandler(this.CloseButtom_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(580, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "Регистрация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.ForeColor = System.Drawing.Color.White;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(455, 501);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(122, 18);
			this.linkLabel1.TabIndex = 14;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Авторизироваться";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 561);
			this.Controls.Add(this.MainPanel);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PassField;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox LoginField;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label CloseButtom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UserGroupField;
		private System.Windows.Forms.TextBox UserNameField;
		private System.Windows.Forms.TextBox UserSurnameField;
		private System.Windows.Forms.TextBox RepeatPassField;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}