/************************The MIT License *********************************
 * Copyright (c) 2010 Whiteboard-IT
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Castle.Core.Logging;
using WB;
using WB.Net.Mail;


namespace Emailer
{
	public partial class EmailForm : Form
	{

		public EmailForm()
		{
			InitializeComponent();
			MailerService = new DotNetMailer("localhost");
		}
		public DotNetMailer MailerService { get; set; }
		private Log logForm = new Log();

		private void SendEmailFromFile(object sender, EventArgs e)
		{
			MailerService.Logger = logForm;
			var ofd = new OpenFileDialog();
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				logForm.Show();
				IEmail email = GetEmail();
				var file = File.ReadAllText(ofd.FileName);
				var emailPattern = new Regex("\\b[A-Z0-9._%-]+@[A-Z0-9.-]+\\.[A-Z]{2,4}\\b", RegexOptions.IgnoreCase);

				var matches = emailPattern.Matches(file);
				foreach (var match in matches)
				{
					var emailToSend = match.ToString();
					email.ToAddress = emailToSend;
					SendEmail(email, emailToSend);
				}
			}
		}

		private void SendEmail(IEmail email, string emailToSend)
		{
			try
			{
				email.ToAddress = emailToSend;
				if (MailerService.Send(email, new object(), ""))
				{
					logForm.LogError("Successfully sent to [" + emailToSend + "]"); ;	
				}else
				{
					logForm.LogError("Error sending to [" + emailToSend + "]");	
				}
						
			}catch(Exception ex)
			{
				logForm.LogError("Error sending to [" + emailToSend + "]:" + ex.Message); 
			}
		}

		private IEmail GetEmail()
		{
			IEmail email = new SimpleEmail();
			email.EmailAddress = this.FromAddress.Text;
			email.Subject = this.Subject.Text;
			email.Body = this.Body.Text;
			return email;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			IEmail email = GetEmail();
			var sendTo = new SendTo();
			sendTo.Closed += (s, args) =>
			{
				logForm.Show();
				SendEmail(email, sendTo.EmailAddress);
			};
			sendTo.ShowDialog();
			
		}

		private void ChangeSettings_Click(object sender, EventArgs e)
		{
			var settingsForm = new SmtpSettingsForm();
			settingsForm.Closing += (s, obj) =>
			                        	{
			                        		this.MailerService = settingsForm.Mailer;
			                        	};
			settingsForm.ShowDialog();
		}

		
		
	}

}
