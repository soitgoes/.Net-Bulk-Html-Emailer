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
using System.Windows.Forms;
using Castle.Core.Logging;

namespace Emailer
{
	public partial class Log : Form, Castle.Core.Logging.ILogger 

	{
		public Log()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LogMessage = "";
			this.Hide();			
			return;
		}

		public string LogMessage { get { return logMessage.Text; } set { logMessage.Text = value; } }
		public void LogError(string message)
		{
			LogMessage += DateTime.Now.ToString("hh:MM:ss tt:  ") +message + "\n";
		}
		public void Debug(string message)
		{
			LogError(message);
		}

		public void Debug(string message, Exception exception)
		{
			LogError(message);
		}

		public void Debug(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void DebugFormat(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void DebugFormat(Exception exception, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void Info(string message)
		{
			LogError(message);
		}

		public void Info(string message, Exception exception)
		{
			LogError(message);
		}

		public void Info(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void InfoFormat(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void InfoFormat(Exception exception, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void Warn(string message)
		{
			LogError(message);
		}

		public void Warn(string message, Exception exception)
		{
			LogError(message);
		}

		public void Warn(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void WarnFormat(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void WarnFormat(Exception exception, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void Error(string message)
		{
			LogError(message);
		}

		public void Error(string message, Exception exception)
		{
			LogError(message);
		}

		public void Error(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void ErrorFormat(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void ErrorFormat(Exception exception, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void Fatal(string message)
		{
			throw new System.NotImplementedException();
		}

		public void Fatal(string message, Exception exception)
		{
			LogError(message);
		}

		public void Fatal(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void FatalFormat(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void FatalFormat(Exception exception, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public void FatalError(string message)
		{
			throw new System.NotImplementedException();
		}

		public void FatalError(string message, Exception exception)
		{
			throw new System.NotImplementedException();
		}

		public void FatalError(string format, params object[] args)
		{
			throw new System.NotImplementedException();
		}

		public ILogger CreateChildLogger(string loggerName)
		{
			throw new System.NotImplementedException();
		}

		public bool IsDebugEnabled
		{
			get { throw new System.NotImplementedException(); }
		}

		public bool IsInfoEnabled
		{
			get { throw new System.NotImplementedException(); }
		}

		public bool IsWarnEnabled
		{
			get { throw new System.NotImplementedException(); }
		}

		public bool IsErrorEnabled
		{
			get { throw new System.NotImplementedException(); }
		}

		public bool IsFatalEnabled
		{
			get { throw new System.NotImplementedException(); }
		}

		public bool IsFatalErrorEnabled
		{
			get { throw new System.NotImplementedException(); }
		}
	}
}
