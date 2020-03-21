namespace PracticeOP
{
	partial class MainForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.CloseButtom = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.CloseButtom);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(514, 75);
			this.panel2.TabIndex = 0;
			// 
			// CloseButtom
			// 
			this.CloseButtom.AutoSize = true;
			this.CloseButtom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButtom.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButtom.ForeColor = System.Drawing.Color.White;
			this.CloseButtom.Location = new System.Drawing.Point(492, 0);
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
			this.label1.Size = new System.Drawing.Size(514, 75);
			this.label1.TabIndex = 0;
			this.label1.Text = "Главный экран";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainPanel
			// 
			this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(9)))), ((int)(((byte)(103)))));
			this.MainPanel.Controls.Add(this.panel2);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(514, 436);
			this.MainPanel.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 436);
			this.Controls.Add(this.MainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.MainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label CloseButtom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel MainPanel;
	}
}