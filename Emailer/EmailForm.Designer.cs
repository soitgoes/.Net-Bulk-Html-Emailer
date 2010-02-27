namespace Emailer
{
	partial class EmailForm
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
			this.Subject = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Body = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.FromAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.ChangeSettings = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Subject
			// 
			this.Subject.Location = new System.Drawing.Point(17, 138);
			this.Subject.Name = "Subject";
			this.Subject.Size = new System.Drawing.Size(604, 20);
			this.Subject.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Subject";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 176);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Body";
			// 
			// Body
			// 
			this.Body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.Body.Location = new System.Drawing.Point(17, 201);
			this.Body.Name = "Body";
			this.Body.Size = new System.Drawing.Size(890, 494);
			this.Body.TabIndex = 4;
			this.Body.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(786, 70);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 56);
			this.button1.TabIndex = 5;
			this.button1.Text = "Send Email";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SendEmailFromFile);
			// 
			// FromAddress
			// 
			this.FromAddress.Location = new System.Drawing.Point(19, 52);
			this.FromAddress.Name = "FromAddress";
			this.FromAddress.Size = new System.Drawing.Size(601, 20);
			this.FromAddress.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "From:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(639, 74);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(135, 51);
			this.button2.TabIndex = 8;
			this.button2.Text = "Send Test";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ChangeSettings
			// 
			this.ChangeSettings.Location = new System.Drawing.Point(646, 11);
			this.ChangeSettings.Name = "ChangeSettings";
			this.ChangeSettings.Size = new System.Drawing.Size(116, 34);
			this.ChangeSettings.TabIndex = 9;
			this.ChangeSettings.Text = "Change SMTP Settings";
			this.ChangeSettings.UseVisualStyleBackColor = true;
			this.ChangeSettings.Click += new System.EventHandler(this.ChangeSettings_Click);
			// 
			// EmailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 717);
			this.Controls.Add(this.ChangeSettings);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.FromAddress);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Body);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Subject);
			this.Name = "EmailForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Subject;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox Body;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox FromAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button ChangeSettings;
	}
}

