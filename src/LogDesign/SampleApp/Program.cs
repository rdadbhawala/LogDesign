using LogDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
	class Program
	{
		static Logger logger = new Logger("Program");

		static void Main(string[] args)
		{
			Setup.LogTargets(new ILogTarget[]{
				new FileLogger() {
					LogFilePath = "log.log",
					DateFormat = "yy-MM-dd HH:mm:ss ",
					MinLevel = LogLevel.Verbose
				},
				new FileLogger() {
					LogFilePath = "err.log",
					DateFormat = "yy-MM-dd HH:mm:ss ",
					MinLevel = LogLevel.Error
				}
			});

			logger.Log(LogLevel.Debug, "Hello New");
			logger.Log(LogLevel.Info, "New World");
			logger.LogDebug("Debug Hello");

			try
			{
				throw new Exception("My New Error");
			}
			catch (Exception exc)
			{
				logger.Log(LogLevel.Error, "Some Error Occured: ", exc);
				LogMessage msg = new LogMessage();
				msg.Data["abc"] = "XYZ";
				logger.Log(msg);
			}
		}
	}
}
