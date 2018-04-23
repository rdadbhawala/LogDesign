using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
	public class LogMessage
	{

		public LogMessage()
		{
			this.Level = LogLevel.Debug;
			this.LogTimestampUTC = DateTime.UtcNow;
			this.Data = new Dictionary<string, string>();
		}

		public DateTime LogTimestampUTC { get; private set; }
		public string Message { get; set; }
		public string LogName { get; set; }
		public LogLevel Level { get; set; }
		public Exception Exc { get; set; }

		public Dictionary<string, string> Data { get; private set; }
	}
}
