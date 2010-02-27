namespace Emailer
{
	partial class SendTo
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
			this.emailAddress = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// emailAddress
			// 
			this.emailAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.emailAddress.Location = new System.Drawing.Point(12, 12);
			this.emailAddress.Name = "emailAddress";
			this.emailAddress.Size = new System.Drawing.Size(298, 20);
			this.emailAddress.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(323, 10);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(101, 21);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// SendTo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 43);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.emailAddress);
			this.Name = "SendTo";
			this.Text = "SendTo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox emailAddress;
		private System.Windows.Forms.Button btnSend;
	}
}