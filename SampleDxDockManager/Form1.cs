using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace SampleDxDockManager
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dockManagerControl1.AddFloatPanel();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			dockManagerControl1.AddTsFloatPanel();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dockManagerControl1.SaveLayout();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			dockManagerControl1.LoadLayout();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			dockManagerControl1.AddDockPanel(DockingStyle.Right);
		}
	}
}
