using Altinator.Properties;// Needed for Resources.AppIcon
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltinatorTray
{
	public class TrayAppContext : ApplicationContext
	{
		private NotifyIcon trayIcon;

		public TrayAppContext()
		{
			trayIcon = new NotifyIcon()
			{
				Icon = Resources.AppIcon,
				ContextMenuStrip = new ContextMenuStrip()
				{
					Items = { new ToolStripMenuItem("Exit", null, Exit) }
				},
				Visible = true
			};
		}

		void Exit(object sender, EventArgs e)
		{
			trayIcon.Visible = false;
			Application.Exit();
		}
	}
}