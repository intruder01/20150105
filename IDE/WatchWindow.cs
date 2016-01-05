using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenHTM.IDE
{
	public partial class WatchWindow : Form
	{
		public WatchWindow ()
		{
			InitializeComponent ();
		}

		public WatchWindow (string title)
		{
			InitializeComponent ();
			this.Text = title;
		}

		private void WatchWindow_Load ( object sender, EventArgs e )
		{

		}
	}
}
