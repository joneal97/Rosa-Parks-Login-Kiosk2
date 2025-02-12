using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rosa_Parks_Login_Kiosk2
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form4_Load(object sender, EventArgs e)
		{
			
   
   
   
   this.TopMost = true;
			logUsers.Text = File.ReadAllText("c:\\Temp\\users.txt");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
