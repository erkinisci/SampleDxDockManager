using System;
using System.Runtime.InteropServices;
using DevExpress.XtraBars.Docking;

namespace SampleDxDockManager
{
	public class TsFloatForm : FloatForm
	{
		public bool AlwaysTop = false;

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		private const UInt32 SWP_NOSIZE = 0x0001;
		private const UInt32 SWP_NOMOVE = 0x0002;
		private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

		public TsFloatForm()
		{
			if (!DesignModeChecker.IsInDesignMode())
			{
				Load += delegate
				{
					if (AlwaysTop)
						SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
				};
			}
		}
	}
}