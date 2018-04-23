using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
	public class Logger
	{
		public Logger(string name)
		{
			this.LogName = name;
		}

		public string LogName { get; set; }

		public void Log(LogLevel lvl, string message, Exception exc = null)
		{
			this.Log(new LogMessage()
			{
				Level = lvl,
				LogName = this.LogName,
				Message = message,
				Exc = exc
			});
		}


		public void LogDebug(string message)
		{
			this.Log(LogLevel.Debug, message);
		}


		public void Log(LogMessage message)
		{
			StaticLogging.Log(message);
		}
	}
}
