﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_winforms_examples
{
	public partial class NavigationBarExampleUserControl : UserControl
	{
		public NavigationBarExampleUserControl()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			label1.Text = ((Button)sender).Text + " Screen";
		}
	}
}
