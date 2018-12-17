using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Docking;

namespace SampleDxDockManager
{
	public class TsDockPanel : DockPanel
	{
		[XtraSerializableProperty]
		public bool AlwaysTop { get; set; }
		public TsDockPanel(bool createControlContainer, DockingStyle dock, DockManager dockManager, bool alwaysTop) :base(createControlContainer, dock, dockManager)
		{
			AlwaysTop = alwaysTop;
		}
	}
}