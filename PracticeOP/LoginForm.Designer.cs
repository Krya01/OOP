namespace PracticeOP
{
	partial class LoginForm
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.PassField = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginField = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.CloseButtom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MainPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(9)))), ((int)(((byte)(103)))));
			this.MainPanel.Controls.Add(this.linkLabel1);
			this.MainPanel.Controls.Add(this.button1);
			this.MainPanel.Controls.Add(this.label3);
			this.MainPanel.Controls.Add(this.PassField);
			this.MainPanel.Controls.Add(this.label2);
			this.MainPanel.Controls.Add(this.LoginField);
			this.MainPanel.Controls.Add(this.panel2);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(350, 389);
			this.MainPanel.TabIndex = 0;
			this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
			this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.ForeColor = System.Drawing.Color.White;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(252, 329);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(95, 18);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Нет аккаунта?";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
			this.button1.Location = new System.Drawing.Point(0, 350);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.button1.Size = new System.Drawing.Size(350, 39);
			this.button1.TabIndex = 5;
			this.button1.Text = "Войти";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(46, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 35);
			this.label3.TabIndex = 4;
			this.label3.Text = "Пароль:";
			// 
			// PassField
			// 
			this.PassField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.PassField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PassField.Location = new System.Drawing.Point(43, 234);
			this.PassField.Name = "PassField";
			this.PassField.PasswordChar = '•';
			this.PassField.Size = new System.Drawing.Size(268, 37);
			this.PassField.TabIndex = 3;
			this.PassField.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(46, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 35);
			this.label2.TabIndex = 2;
			this.label2.Text = "Логин:";
			// 
			// LoginField
			// 
			this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.LoginField.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginField.Location = new System.Drawing.Point(43, 159);
			this.LoginField.Multiline = true;
			this.LoginField.Name = "LoginField";
			this.LoginField.Size = new System.Drawing.Size(268, 34);
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
			this.panel2.Size = new System.Drawing.Size(350, 75);
			this.panel2.TabIndex = 0;
			// 
			// CloseButtom
			// 
			this.CloseButtom.AutoSize = true;
			this.CloseButtom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButtom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButtom.ForeColor = System.Drawing.Color.White;
			this.CloseButtom.Location = new System.Drawing.Point(328, 0);
			this.CloseButtom.Name = "CloseButtom";
			this.CloseButtom.Size = new System.Drawing.Size(22, 23);
			this.CloseButtom.TabIndex = 2;
			this.CloseButtom.Text = "X";
			this.CloseButtom.Click += new System.EventHandler(this.CloseButtom_Click);
			this.CloseButtom.MouseEnter += new System.EventHandler(this.CloseButtom_MouseEnter);
			this.CloseButtom.MouseLeave += new System.EventHandler(this.CloseButtom_MouseLeave);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Snow;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(350, 67);
			this.label1.TabIndex = 0;
			this.label1.Text = "Авторизация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 389);
			this.Controls.Add(this.MainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LoginField;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PassField;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label CloseButtom;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}