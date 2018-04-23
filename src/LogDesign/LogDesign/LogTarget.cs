using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
	public interface ILogTarget
	{
		void Log(LogMessage msg);
	}

	public abstract class BaseLogTarget
	{
		protected BaseLogTarget()
		{
			//MinLevel = LogLevel.Verbose;
		}

		public LogLevel MinLevel { get; set; }
	}

	public class FileLogger
		: BaseLogTarget, ILogTarget
	{
		public string LogFilePath { get; set; }
		public string DateFormat { get; set; }

		public void Log(LogMessage message)
		{
			if (this.MinLevel <= message.Level)
			{
				using (StreamWriter sw = new StreamWriter(new FileStream(LogFilePath, FileMode.Append, FileAccess.Write)))
				{
					sw.Write(message.LogTimestampUTC.ToString(DateFormat));
					sw.Write(message.Level + " ");
					sw.Write(message.LogName + " ");
					sw.Write(message.Message + " ");
					if (message.Exc != null)
					{
						sw.Write(message.Exc.Message + " ");
					}
					if (message.Data.Count > 0)
					{
						sw.WriteLine();
						foreach (KeyValuePair<string, string> kvp in message.Data)
						{
							sw.WriteLine("\t" + kvp.Key + ": " + kvp.Value);
						}
					}
					sw.WriteLine();
				}
			}
		}
	}
}
