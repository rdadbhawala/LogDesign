using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
    public class Logger
    {
		public static void Log(string message)
		{
			using (StreamWriter sw = new StreamWriter(new FileStream("log.log", FileMode.Append, FileAccess.Write)))
			{
				sw.WriteLine(message);
			}
		}
    }
}
