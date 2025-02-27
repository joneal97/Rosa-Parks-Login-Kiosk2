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
            pleaseWait.Visible = false;
            
            //See http://tinyurl.com/joneal106b
            var parameterDate = DateTime.ParseExact("03/04/2025", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var todaysDate = DateTime.Now;
            if (parameterDate < todaysDate)
            {
                    updateBox.Hide();
                    logEveryoneOut.Hide();
                    serviceMode.Hide();

             }
             //See http://tinyurl.com/joneal101a
             this.Top = 0;
             this.Left = 0;

             this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 10);


            
        }//There should not be a need for a bracket here joneal 2PM 2/26/2025
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
            var todaysDate = DateTime.Now;
            if (todaysDate.Hour == 3) //3
            {
                tempNewDay.Text = ((char)('A' + new Random().Next(0, 26))).ToString(); ;
                newDayReset = true;
                pleaseWait.Visible = false;
            }
            if (todaysDate.Hour == 5) //5
            {
                pleaseWait.Visible = false;
            }
            if (todaysDate.Hour == 4 && newDayReset == true) //4
            {
                // joneal 2/26/2025 1:38PM
                if (newDayReset == true)
                {
                    pleaseWait.Visible = true;
                    newDayReset = false;
                    countUp++;
                    testRemoveJONeal.Text = countUp.ToString();
                    // 2/26/2025 9:37AM.

                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrinterSettings.PrinterName = "0230A-TechHall-HP2055";

                    List<string> allUsers = new List<string>();
                    allUsers.AddRange(loggedInList);
                    allUsers.AddRange(loggedOutList);

                    int linesPerPage = 50;
                    int currentLine = 0;

                    if (printDoc.PrinterSettings.IsValid)
                    {
                        printDoc.PrintPage += (jonealfebsender, jonealfe) =>
                        {
                            float yPos = 100;
                            float leftMargin = jonealfe.MarginBounds.Left;
                            Font printFont = new Font("Arial", 12);
                            int linesPrinted = 0;

                            while (currentLine < allUsers.Count && linesPrinted < linesPerPage)
                            {
                                jonealfe.Graphics.DrawString(allUsers[currentLine], printFont, Brushes.Black, leftMargin, yPos);
                                yPos += printFont.GetHeight(jonealfe.Graphics);
                                currentLine++;
                                linesPrinted++;
                            }

                            // Check if there are more lines to print
                            jonealfe.HasMorePages = currentLine < allUsers.Count;
                        };

                        printDoc.Print();

                        // 2/26/2025 9:36AM.
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

                }

            }
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
            pleaseWait.Visible = false;
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
                pleaseWait.Visible = true;


                PrintDocument printDoc = new PrintDocument();
                printDoc.PrinterSettings.PrinterName = "0230A-TechHall-HP2055";

                List<string> allUsers = new List<string>();
                allUsers.AddRange(loggedInList);
                allUsers.AddRange(loggedOutList);

                int linesPerPage = 50;
                int currentLine = 0;

                if (printDoc.PrinterSettings.IsValid)
                {
                    printDoc.PrintPage += (jonealfebsender, jonealfe) =>
                    {
                        float yPos = 100;
                        float leftMargin = jonealfe.MarginBounds.Left;
                        Font printFont = new Font("Arial", 12);
                        int linesPrinted = 0;

                        while (currentLine < allUsers.Count && linesPrinted < linesPerPage)
                        {
                            jonealfe.Graphics.DrawString(allUsers[currentLine], printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(jonealfe.Graphics);
                            currentLine++;
                            linesPrinted++;
                        }

                        // Check if there are more lines to print
                        jonealfe.HasMorePages = currentLine < allUsers.Count;
                    };

                    pleaseWait.Visible = false;
                    printDoc.Print();

                    // 2/26/2025 9:50AM

                }
            }
            else
            {
                //Console.WriteLine("User selected No. Cancel the printing.");
                // Add code here to cancel the printing process
            }

        }

        private void serviceMode_Click(object sender, EventArgs e)
        {
            if(pleaseWait.Visible == false)
            {
                pleaseWait.Visible = true;
            }
            else
            {
                pleaseWait.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            loggedinCount.Text = "There are " + Form1.loggedInList.Count + " logged in visitors";
        }
    }
}
