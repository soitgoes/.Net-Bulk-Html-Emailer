namespace Emailer
{
	partial class SmtpSettingsForm
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
			this.btnSaveSettings = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Server = new System.Windows.Forms.TextBox();
			this.User = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.UseSSL = new System.Windows.Forms.CheckBox();
			this.Port = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSaveSettings
			// 
			this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveSettings.Location = new System.Drawing.Point(175, 182);
			this.btnSaveSettings.Name = "btnSaveSettings";
			this.btnSaveSettings.Size = new System.Drawing.Size(148, 48);
			this.btnSaveSettings.TabIndex = 0;
			this.btnSaveSettings.Text = "Save Settings";
			this.btnSaveSettings.UseVisualStyleBackColor = true;
			this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "SMTP Server";
			// 
			// Server
			// 
			this.Server.Location = new System.Drawing.Point(10, 33);
			this.Server.Name = "Server";
			this.Server.Size = new System.Drawing.Size(313, 20);
			this.Server.TabIndex = 2;
			// 
			// User
			// 
			this.User.Location = new System.Drawing.Point(10, 84);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(312, 20);
			this.User.TabIndex = 3;
			// 
			// Password
			// 
			this.Password.Location = new System.Drawing.Point(10, 142);
			this.Password.Name = "Password";
			this.Password.PasswordChar = '*';
			this.Password.Size = new System.Drawing.Size(312, 20);
			this.Password.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "User Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Port";
			// 
			// UseSSL
			// 
			this.UseSSL.AutoSize = true;
			this.UseSSL.Location = new System.Drawing.Point(74, 194);
			this.UseSSL.Name = "UseSSL";
			this.UseSSL.Size = new System.Drawing.Size(74, 17);
			this.UseSSL.TabIndex = 9;
			this.UseSSL.Text = "Use SSL?";
			this.UseSSL.UseVisualStyleBackColor = true;
			// 
			// Port
			// 
			this.Port.Location = new System.Drawing.Point(10, 192);
			this.Port.Name = "Port";
			this.Port.Size = new System.Drawing.Size(44, 20);
			this.Port.TabIndex = 10;
			this.Port.Text = "22";
			// 
			// SmtpSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 236);
			this.Controls.Add(this.Port);
			this.Controls.Add(this.UseSSL);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.User);
			this.Controls.Add(this.Server);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSaveSettings);
			this.Name = "SmtpSettingsForm";
			this.Text = "SmtpSettingsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSaveSettings;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Server;
		private System.Windows.Forms.TextBox User;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox UseSSL;
		private System.Windows.Forms.TextBox Port;
	}
}