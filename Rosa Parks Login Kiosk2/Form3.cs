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


using System.Media;
using bpac;
using System.Drawing.Printing;

namespace Rosa_Parks_Login_Kiosk2
{
	public partial class Form3 : Form
	{

		//Form1 form1 = new Form1(); //See http://tinyurl.com/joneal102a

		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//See: http://tinyurl.com/joneal102d
			string createText = "";
			//foreach (Object Items in loggedinGuests.CheckedItems)
			int logoutswitch = 0;
			if (loggedinGuest.SelectedRows.Count > 0)
			{
				createText = loggedinGuest.SelectedCells[0].Value.ToString() + "... Out " + DateTime.Now.ToString("MMMM dd h:mm tt"); //see http://tinyurl.com/joneal103a
				Form1.loggedInList.Remove(loggedinGuest.SelectedCells[0].Value.ToString());
				File.AppendAllText("c:\\Temp\\users.txt", createText + Environment.NewLine);
				logoutswitch = 1;
			}
			if (logoutswitch == 1)
			{
				SoundPlayer audio = new SoundPlayer(Rosa_Parks_Login_Kiosk2.Properties.Resources.Logout);
				audio.Play();
			}
			this.Close();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
			loggedinGuest.Font = new Font(FontFamily.GenericMonospace,10);
			foreach (string str in Form1.loggedInList)
			{
				//See http://tinyurl.com/joneal102c
				//loggedinGuests.Items.Add(str, false);
				//See http://tinyurl.com/joneal106c
				loggedinGuest.Rows.Add(str.ToString());
			}
			
		}

        private void printReport_Click(object sender, EventArgs e)
        {
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
                    printDoc.PrintPage += (sender, e) =>
                    {
                        // Starting position for the printed text
                        float yPos = 100; // Starting position on the page
                        float leftMargin = e.MarginBounds.Left;
                        Font printFont = new Font("Arial", 12);

                        // Loop through the logged-in users and print them
                        foreach (string user in loggedInList)
                        {
                            e.Graphics.DrawString(user, printFont, Brushes.Black, leftMargin, yPos);
                            yPos += printFont.GetHeight(e.Graphics); // Move to the next line
                        }
                    };

                    // Print the document
                    printDoc.Print();
                }
                else
                {
                    Console.WriteLine("The specified printer is not available.");
                }
            }// End of printing section

        }
            else
            {
                Console.WriteLine("User selected No. Cancel the printing.");
                // Add code here to cancel the printing process
            }
        }

        //private void loggedinList_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
