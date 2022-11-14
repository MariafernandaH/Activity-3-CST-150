using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void button1_MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("You clicked the first button!");
			//clicking the first button will display this message
		}

		private void button2_MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("You clicked the second button!");
			//clicking the second button will display this message
		}

		private void button3_MouseClick(object sender, MouseEventArgs e)
		{
			MessageBox.Show("You clicked the third button!");
			//clicking the third button will display this message
		}

		private void progressBar1_Click(object sender, EventArgs e)
		{

		}

		private void progressBar1_MouseClick(object sender, MouseEventArgs e)
		{
            progressBar1.Value = progressBar1.Value + 5;
			//every time the user clicks on the progress bar, the progress bar's value will increase by 5 and the bar will turn increasingly green
        }
	}
}
