using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Altinator;

namespace AltinatorTrayApp
{
	internal static class Program
	{
		[STAThread]
		public static void Main()
		{
			//ApplicationConfiguration.Initialize();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TrayAppContext());
			InterceptKeys.InitComponent();
		}
	}
}