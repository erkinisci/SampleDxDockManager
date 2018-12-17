using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Behaviors.Common;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Ribbon;

namespace SampleDxDockManager
{
	public partial class DockManagerControl : UserControl
	{
		public DockManagerControl()
		{
			InitializeComponent();
		}

		public void AddFloatPanel()
		{
			var panel = tsDockManager1.AddPanel(new Point(0, 0));
			panel.Text = "FloatPanel";
			panel.Name = "FloatPanel";
		}

		public void AddTsFloatPanel()
		{
			//tsDockManager1.AlwaysTop = true;
			var panel = tsDockManager1.AddAlwaysTopFloat(new Point(0, 0));
			//var panel = tsDockManager1.AddPanel(new Point(0, 0));
			panel.Text = "TsFloatPanel";
			panel.Name = "TsFloatPanel";
			//tsDockManager1.AlwaysTop = false;
		}

		public void SaveLayout()
		{
			SaveLoadLayoutHelper.Save(tsDockManager1);
		}

		public void LoadLayout()
		{
			SaveLoadLayoutHelper.Load(tsDockManager1);
		}

		public void AddDockPanel(DockingStyle side)
		{
			tsDockManager1.AddPanel(side);
		}
	}
}
