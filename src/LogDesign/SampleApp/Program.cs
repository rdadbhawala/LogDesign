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
		static Logger log = new Logger("Program");

		static void Main(string[] args)
		{
			LogDesign.Setup.SetupTargets(new ILogTarget[]{
				new SimpleFileTarget() {
					FilePath = "log.log",
					MinLevel = LogLevel.Verbose
				},
				new SimpleFileTarget() {
					FilePath = "err.log",
					MinLevel = LogLevel.Error
				}
			});

			log.Log("Hello");
			log.Log("World");
			log.Log(new LogMessage()
			{
				Level = LogLevel.Error,
				Message = "Err",
				Name = "Program"
			});
			log.LogError("err");

			try
			{
				throw new Exception("Exc");
			}
			catch (Exception exc)
			{
				log.LogError("Exception occured", exc);
			}

			ICode cd = new Code();
			cd.SomeMethod();
		}
	}
}
