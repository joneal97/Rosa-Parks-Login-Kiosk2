namespace Rosa_Parks_Login_Kiosk2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printLoggedInUsers = new System.Windows.Forms.Button();
            this.testRemoveJONeal = new System.Windows.Forms.Label();
            this.updateBox = new System.Windows.Forms.Label();
            this.logEveryoneOut = new System.Windows.Forms.Button();
            this.currentTime = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.loggedinCount = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1088, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 128);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 108);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rosa Parks Login Kiosk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.printLoggedInUsers);
            this.groupBox1.Controls.Add(this.testRemoveJONeal);
            this.groupBox1.Controls.Add(this.updateBox);
            this.groupBox1.Controls.Add(this.logEveryoneOut);
            this.groupBox1.Controls.Add(this.currentTime);
            this.groupBox1.Controls.Add(this.aboutButton);
            this.groupBox1.Controls.Add(this.loggedinCount);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(63, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1482, 809);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiosk";
            // 
            // printLoggedInUsers
            // 
            this.printLoggedInUsers.Location = new System.Drawing.Point(7, 725);
            this.printLoggedInUsers.Name = "printLoggedInUsers";
            this.printLoggedInUsers.Size = new System.Drawing.Size(189, 30);
            this.printLoggedInUsers.TabIndex = 10;
            this.printLoggedInUsers.Text = "Print logged in users";
            this.printLoggedInUsers.UseVisualStyleBackColor = true;
            this.printLoggedInUsers.Click += new System.EventHandler(this.printLoggedInUsers_Click);
            // 
            // testRemoveJONeal
            // 
            this.testRemoveJONeal.AutoSize = true;
            this.testRemoveJONeal.Location = new System.Drawing.Point(1117, 767);
            this.testRemoveJONeal.Name = "testRemoveJONeal";
            this.testRemoveJONeal.Size = new System.Drawing.Size(105, 20);
            this.testRemoveJONeal.TabIndex = 9;
            this.testRemoveJONeal.Text = "Day\'s running";
            // 
            // updateBox
            // 
            this.updateBox.AutoSize = true;
            this.updateBox.Location = new System.Drawing.Point(18, 767);
            this.updateBox.Name = "updateBox";
            this.updateBox.Size = new System.Drawing.Size(560, 20);
            this.updateBox.TabIndex = 8;
            this.updateBox.Text = "Update 2/24/2025: Resolved issue with logged-out users not clearing next day.";
            // 
            // logEveryoneOut
            // 
            this.logEveryoneOut.Location = new System.Drawing.Point(203, 723);
            this.logEveryoneOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logEveryoneOut.Name = "logEveryoneOut";
            this.logEveryoneOut.Size = new System.Drawing.Size(219, 35);
            this.logEveryoneOut.TabIndex = 7;
            this.logEveryoneOut.Text = "Manually log everyone out";
            this.logEveryoneOut.UseVisualStyleBackColor = true;
            this.logEveryoneOut.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime.Location = new System.Drawing.Point(266, 151);
            this.currentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(526, 64);
            this.currentTime.TabIndex = 4;
            this.currentTime.Text = "There are 0 visitors";
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Location = new System.Drawing.Point(1088, 517);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(201, 106);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // loggedinCount
            // 
            this.loggedinCount.AutoSize = true;
            this.loggedinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggedinCount.Location = new System.Drawing.Point(334, 278);
            this.loggedinCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loggedinCount.Name = "loggedinCount";
            this.loggedinCount.Size = new System.Drawing.Size(320, 37);
            this.loggedinCount.TabIndex = 4;
            this.loggedinCount.Text = "There are 0 visitors.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1088, 678);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Log";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosa_Parks_Login_Kiosk2.Properties.Resources.tigercub;
            this.pictureBox1.Location = new System.Drawing.Point(84, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 122);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1088, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 129);
            this.button2.TabIndex = 3;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 898);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rosa Parks Login Kiosk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.Label loggedinCount;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Button logEveryoneOut;
        private System.Windows.Forms.Label updateBox;
        private System.Windows.Forms.Label testRemoveJONeal;
        private System.Windows.Forms.Button printLoggedInUsers;
    }
}

