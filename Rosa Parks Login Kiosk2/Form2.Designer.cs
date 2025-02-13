namespace Rosa_Parks_Login_Kiosk2
{
	partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.parentsName = new System.Windows.Forms.TextBox();
            this.checkInText = new System.Windows.Forms.Label();
            this.checkInButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parentsName
            // 
            this.parentsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentsName.Location = new System.Drawing.Point(155, 80);
            this.parentsName.Name = "parentsName";
            this.parentsName.Size = new System.Drawing.Size(292, 49);
            this.parentsName.TabIndex = 0;
            // 
            // checkInText
            // 
            this.checkInText.AutoSize = true;
            this.checkInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInText.Location = new System.Drawing.Point(150, 36);
            this.checkInText.Name = "checkInText";
            this.checkInText.Size = new System.Drawing.Size(330, 25);
            this.checkInText.TabIndex = 1;
            this.checkInText.Text = "Enter your first and last name:";
            this.checkInText.Click += new System.EventHandler(this.checkInText_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInButton.Location = new System.Drawing.Point(359, 241);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(121, 54);
            this.checkInButton.TabIndex = 5;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosa_Parks_Login_Kiosk2.Properties.Resources.tigercub;
            this.pictureBox1.Location = new System.Drawing.Point(22, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 98);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // roomName
            // 
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.Location = new System.Drawing.Point(155, 174);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(292, 49);
            this.roomName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter destination or room#";
            // 
            // Form2
            // 
            this.AcceptButton = this.checkInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.checkInText);
            this.Controls.Add(this.parentsName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Check In";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox parentsName;
		private System.Windows.Forms.Label checkInText;
		private System.Windows.Forms.Button checkInButton;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.Label label1;
    }
}