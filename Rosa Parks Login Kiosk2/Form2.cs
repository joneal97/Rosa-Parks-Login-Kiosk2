using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // See http://tinyurl.com/joneal102e

namespace Rosa_Parks_Login_Kiosk2
{


	public partial class Form2 : Form
	{
//		Const sPath = Rosa_Parks_Login_Kiosk2.Properties.Resources.RosaParksVisitor;

		//Form1 form1 = new Form1(); //See http://tinyurl.com/joneal102a

		public Form2(String loggedinUsers = "?")
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			this.TopMost = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(!parentsName.Text.Contains(" "))

                {
                MessageBox.Show("Please enter your full name.");
                return;
            }

            if (parentsName.TextLength <= 0)
			{
				parentsName.Text = "Visitor";
			}
			if (parentsName.TextLength.Equals("j oneal")) ;
            {
                MessageBox.Show("Contact Jeremiah ONeal if you see this. 2/13/2025")
                Environment.Exit(0);
            }
            if (roomName.TextLength <= 0)
            {
                parentsName.Text = "Main Office";
            }
            //;
            string textspacing = " ";
			for(int intAddSpacing = parentsName.TextLength; intAddSpacing < 30; intAddSpacing++)
			{
				textspacing = textspacing + " ";
			}
			Form1.loggedInList.AddLast(parentsName.Text.ToString() + textspacing + roomName.Text.ToString() + textspacing +  " In:" + DateTime.Now.ToString("MMMM dd  h:mm tt"));
			SoundPlayer audio = new SoundPlayer(Rosa_Parks_Login_Kiosk2.Properties.Resources.Login);
			audio.Play();
			checkInButton.Hide();
			checkInText.Hide();
			//See: http://tinyurl.com/joneal102g and http://tinyurl.com/joneal102h
			bpac.Document doc = new bpac.Document();
            //if (doc.Open(Rosa_Parks_Login_Kiosk2.Properties.Resources.RosaParksVisitor.ToString()))
            string[] lines = File.ReadAllLines("C:\\Temp\\funfacts.txt"); //i hope that the file is not too big
            Random rand = new Random();
            if (doc.Open("c:\\Temp\\RosaParksVisitor.lbx"))

			{
				doc.GetObject("objName").Text = parentsName.Text.ToString();
                doc.GetObject("objRoom").Text = "Room: " + roomName.Text.ToString();
                doc.GetObject("objCompany").Text = DateTime.Now.ToString("MMMM dd h:mm tt");
                doc.GetObject("funfacts").Text = "Fun fact " + lines[rand.Next(lines.Length)];

                doc.StartPrint("", bpac.PrintOptionConstants.bpoDefault);
				doc.PrintOut(1, bpac.PrintOptionConstants.bpoDefault);
				doc.EndPrint();
				doc.Close();
			}
			else
			{
				MessageBox.Show("Missing c:\\Temp\\RosaParksVisitor.lbx Contact\nJeremiah ONeal at Ext 3038.");
			}
			this.Close();
		}

        private void checkInText_Click(object sender, EventArgs e)
        {

        }
    }
}
