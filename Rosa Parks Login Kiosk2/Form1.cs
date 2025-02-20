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
using System.IO;

namespace Rosa_Parks_Login_Kiosk2
{

    public partial class Form1 : Form
	{
        private int countUp = 0;
        public static LinkedList<String> loggedInList; //See http://tinyurl.com/joneal102b
		public Form1()
		{
			loggedInList = new LinkedList<String>();
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//See http://tinyurl.com/joneal106b
			var parameterDate = DateTime.ParseExact("02/28/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture);
			var todaysDate = DateTime.Today;
			if (todaysDate.Hour == 3 && todaysDate.Minute == 0 && todaysDate.Second == 0)
			{
                countUp++;
                testRemoveJONeal.Text = countUp.ToString();
                string filePath = @"C:\Temp\users.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
                {
                    foreach (string user in loggedInList)
                    {
                        writer.WriteLine($"Did not sign out: {user}");
                    }
                }
                loggedInList.Clear();

            }

                if (parameterDate < todaysDate)
			{
				updateBox.Hide();
				logEveryoneOut.Hide();

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

        private void button4_Click_1(object sender, EventArgs e)
        {
			
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
         
            string filePath = @"C:\Temp\users.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
            {
                foreach (string user in loggedInList)
                {
                    writer.WriteLine($"Did not sign out: {user}");
                }
            }
        loggedInList.Clear();
        }

    }
}
