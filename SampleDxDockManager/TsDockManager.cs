using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking.Helpers;

namespace SampleDxDockManager
{
	public class TsDockManager : DockManager
	{
		private bool _alwayTop = false;

		public TsDockManager(IContainer container) : base(container)
		{

		}

		public TsDockPanel AddAlwaysTopFloat(Point point)
		{
			_alwayTop = true;
			var tsDockPanel = base.AddPanel(point) as TsDockPanel;
			_alwayTop = false;

			return tsDockPanel;
		}

		protected override FloatForm CreateFloatForm()
		{
			return new TsFloatForm();
		}

		protected override void MakeFloatFormVisible(FloatForm floatForm)
		{
			var tsDockPanels = floatForm.Controls.Cast<TsDockPanel>().FirstOrDefault();
			if (tsDockPanels != null)
				((TsFloatForm) floatForm).AlwaysTop = tsDockPanels.AlwaysTop;

			base.MakeFloatFormVisible(floatForm);
		}

		protected override DockPanel CreateDockPanel(DockingStyle dock, bool createControlContainer)
		{
			return new TsDockPanel(createControlContainer, dock, this, _alwayTop);
		}

		protected override object XtraCreatePanelsItem(XtraItemEventArgs e)
		{
			DockingStyle dock = DockLayoutUtils.ConvertToDockingStyle(e.Item.ChildProperties["Dock"].Value.ToString());
			TsDockPanel result = new TsDockPanel(e.Item.ChildProperties["Count"].Value.ToString() == "0", dock, this, e.Item.ChildProperties["AlwaysTop"].Value.ToString() == "true");//CreateDockPanel(dock, e.Item.ChildProperties["Count"].Value.ToString() == "0", e.Item.ChildProperties["AlwaysTop"]);
			if (IsDesignMode && Site != null && Site.Container != null)
				Site.Container.Add(result);

			return result;
		}
	}
}
