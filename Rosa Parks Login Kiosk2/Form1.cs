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
using System.Drawing.Printing;

namespace Rosa_Parks_Login_Kiosk2
{

    public partial class Form1 : Form
	{
        private int countUp = 0;
        private bool newDayReset = false;
        public static LinkedList<String> loggedInList; //See http://tinyurl.com/joneal102b
        public static LinkedList<String> loggedOutList; //See http://tinyurl.com/joneal102b
        public Form1()
		{
			loggedInList = new LinkedList<String>();
            loggedOutList = new LinkedList<String>();
            InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            //See http://tinyurl.com/joneal101e
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            
            //See http://tinyurl.com/joneal106b
            var parameterDate = DateTime.ParseExact("02/28/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var todaysDate = DateTime.Today;
            if (todaysDate.Hour == 2)
            {
                newDayReset = true;
            }
                if (todaysDate.Hour == 3 && todaysDate.Minute == 0 && newDayReset == true)
            {
                newDayReset = false;
                countUp++;
                testRemoveJONeal.Text = countUp.ToString();
                PrintDocument printDoc = new PrintDocument();

                // Set the printer name to the installed printer you want to use
                printDoc.PrinterSettings.PrinterName = "0230A-TechHall-HP2055";

                // Check if the specified printer exists
                if (printDoc.PrinterSettings.IsValid)
                {
                    // Handle the PrintPage event
                    printDoc.PrintPage += (jonealfebsender, jonealfe) =>
                    {
                        // Starting position for the printed text
                        float yPos = 100; // Starting position on the page
                        float leftMargin = jonealfe.MarginBounds.Left;
                        Font printFont = new Font("Arial", 12);

                        // Loop through the logged-in users and print them
                        foreach (string user in loggedInList)
                        {
                            jonealfe.Graphics.DrawString(user, printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(jonealfe.Graphics); // Move to the next line
                        }
                        foreach (string userLoggedOut in loggedOutList)
                        {
                            jonealfe.Graphics.DrawString(userLoggedOut, printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(jonealfe.Graphics); // Move to the next line
                        }
                    };

                    // Print the document
                    printDoc.Print();
                    string filePath = @"C:\Temp\users.txt";

                    using (StreamWriter writer = new StreamWriter(filePath, true)) // Append mode
                    {
                        foreach (string user in loggedInList)
                        {
                            writer.WriteLine($"Did not sign out: {user}");
                        }
                    }
                    loggedInList.Clear();
                    loggedOutList.Clear();

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


            }
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
        loggedOutList.Clear();
        }

        private void printLoggedInUsers_Click(object sender, EventArgs e)
        {

            //private void printReport_Click(object sender, EventArgs e)
        //{
            DialogResult result = MessageBox.Show(
           "Are you sure you want to print this report?",
           "Confirm Print",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            // Handle the result
            if (result == DialogResult.Yes)
            {
                Console.WriteLine("User selected Yes. Proceed with printing.");

                //{
                //  writer.WriteLine($"Did not sign out: {user}");
                //}
                // Create a PrintDocument object
                PrintDocument printDoc = new PrintDocument();

                // Set the printer name to the installed printer you want to use
                printDoc.PrinterSettings.PrinterName = "0230A-TechHall-HP2055";

                // Check if the specified printer exists
                if (printDoc.PrinterSettings.IsValid)
                {
                    // Handle the PrintPage event
                    printDoc.PrintPage += (jonealfebsender, jonealfe) =>
                    {
                        // Starting position for the printed text
                        float yPos = 100; // Starting position on the page
                        float leftMargin = jonealfe.MarginBounds.Left;
                        Font printFont = new Font("Arial", 12);

                        // Loop through the logged-in users and print them
                        foreach (string user in loggedInList)
                        {
                            jonealfe.Graphics.DrawString(user, printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(jonealfe.Graphics); // Move to the next line
                        }
                        foreach (string userLoggedOut in loggedOutList)
                        {
                            jonealfe.Graphics.DrawString(userLoggedOut, printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(jonealfe.Graphics); // Move to the next line
                        }
                    };

                    // Print the document
                    printDoc.Print();
                }
                else
                {
                    //Console.WriteLine("The specified printer is not available.");
                }
            }// End of printing section

        
            else
            {
                //Console.WriteLine("User selected No. Cancel the printing.");
                // Add code here to cancel the printing process
            }

        }
    }
}
