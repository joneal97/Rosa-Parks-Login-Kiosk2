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
using System.Drawing.Printing;


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
				Form1.loggedOutList.AddLast(loggedinGuest.SelectedCells[0].Value.ToString() + " Out:" + DateTime.Now.ToString("MMMM dd  h:mm tt"));
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

        
        //private void loggedinList_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
