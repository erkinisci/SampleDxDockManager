using System;
using System.Windows.Forms;

namespace SampleDxDockManager
{
	public class DesignModeChecker
	{
		public static bool IsInDesignMode()
		{
			if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
			{
				return true;
			}

			return false;
		}
	}
}