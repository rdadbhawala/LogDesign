using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
    public class StaticLogging
    {
		public static void Log(LogMessage message)
		{
			Setup.LogToTargets(message);
		} 
    }
}
