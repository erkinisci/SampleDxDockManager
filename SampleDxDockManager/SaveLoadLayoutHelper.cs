using System.IO;
using System.Windows.Forms;

namespace SampleDxDockManager
{
	public class SaveLoadLayoutHelper
	{
		private static string FilePath { get; }
		private static string FullFileName { get; }

		static SaveLoadLayoutHelper()
		{
			FilePath = Application.StartupPath;

			FullFileName = Path.Combine(FilePath, "SampleDxDockManager.xml");
		}

		public static void Save(TsDockManager tsDockManager1)
		{
			tsDockManager1.SaveLayoutToXml(FullFileName);
		}

		public static void Load(TsDockManager tsDockManager1)
		{
			tsDockManager1.Clear();

			tsDockManager1.RestoreFromXml(FullFileName);
		}
	}
}