using System;
using System.Globalization; // See http://tinyurl.com/joneal106a
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rosa_Parks_Login_Kiosk2
{
	public partial class Form1 : Form
	{
		public static LinkedList<String> loggedInList; //See http://tinyurl.com/joneal102b
		public Form1()
		{
			loggedInList = new LinkedList<String>();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//See http://tinyurl.com/joneal106b
			var parameterDate = DateTime.ParseExact("11/28/2019", "MM/dd/yyyy", CultureInfo.InvariantCulture);
			var todaysDate = DateTime.Today;

			if (parameterDate > todaysDate)
			{
				aboutButton.Hide();
			}
			//See http://tinyurl.com/joneal101a
			this.Top = 0;
			this.Left = 0;

			this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 10);

			//See http://tinyurl.com/joneal101e
			this.WindowState = FormWindowState.Maximized;
			this.FormBorderStyle = FormBorderStyle.None;
			this.TopMost = true;

		}
		//See http://tinyurl.com/joneal101c
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//See http://tinyurl.com/joneal101f
			Form2 f2 = new Form2(this.loggedinCount.Text);
			f2.ShowDialog();
			loggedinCount.Text = "There are " + Form1.loggedInList.Count + " logged in visitors";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.ShowDialog();
			loggedinCount.Text = "There are " + Form1.loggedInList.Count + " logged in visitors";
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 f4 = new Form4();
			f4.ShowDialog();
			loggedinCount.Text = "There are " + Form1.loggedInList.Count + " logged in visitors";
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form5 f5 = new Form5();
			f5.ShowDialog();
		}
		public void loggedinUsers()
		{
			//loggedinCount.Text = "Test";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			currentTime.Text = DateTime.Now.ToString("MMMM dd h:mm:ss tt");
		}
	}
}
