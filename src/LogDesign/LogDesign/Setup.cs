using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDesign
{
	public class Setup
	{
		static ILogTarget[] currentTargets = null;
		public static void LogTargets(ILogTarget[] targets)
		{
			currentTargets = targets;
		}

		internal static void LogToTargets(LogMessage message) {
			foreach (ILogTarget oneTarget in currentTargets) {
				oneTarget.Log(message);
			}
		}
	}
}
