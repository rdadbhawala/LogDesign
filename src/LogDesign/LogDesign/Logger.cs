using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
	public class Logger
	{
		public Logger(string pName)
		{
			Name = pName;
		}

		public string Name { get; private set; }

		public void Log(string message, Exception exc = null)
		{
			Log(new LogMessage()
			{
				Message = message,
				Level = LogLevel.Debug,
				Name = this.Name,
				Exception = exc
			});
		}

		public void LogError(string message, Exception exc = null)
		{
			Log(new LogMessage()
			{
				Message = message,
				Level = LogLevel.Error,
				Name = this.Name,
				Exception = exc
			});
		}

		public void Log(LogMessage msg)
		{
			Setup.Log(msg);
		}

	}
}
