namespace Emailer
{
	partial class Log
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
			this.logMessage = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// logMessage
			// 
			this.logMessage.Location = new System.Drawing.Point(11, 16);
			this.logMessage.Name = "logMessage";
			this.logMessage.Size = new System.Drawing.Size(791, 461);
			this.logMessage.TabIndex = 0;
			this.logMessage.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(824, 492);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Log
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(917, 540);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.logMessage);
			this.Name = "Log";
			this.Text = "Log";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox logMessage;
		private System.Windows.Forms.Button button1;
	}
}