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
            this.printLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parentsName
            // 
            this.parentsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentsName.Location = new System.Drawing.Point(232, 123);
            this.parentsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parentsName.Name = "parentsName";
            this.parentsName.Size = new System.Drawing.Size(436, 70);
            this.parentsName.TabIndex = 0;
            // 
            // checkInText
            // 
            this.checkInText.AutoSize = true;
            this.checkInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInText.Location = new System.Drawing.Point(225, 55);
            this.checkInText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkInText.Name = "checkInText";
            this.checkInText.Size = new System.Drawing.Size(476, 37);
            this.checkInText.TabIndex = 1;
            this.checkInText.Text = "Enter your first and last name:";
            this.checkInText.Click += new System.EventHandler(this.checkInText_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInButton.Location = new System.Drawing.Point(538, 371);
            this.checkInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(182, 83);
            this.checkInButton.TabIndex = 5;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rosa_Parks_Login_Kiosk2.Properties.Resources.tigercub;
            this.pictureBox1.Location = new System.Drawing.Point(33, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 151);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // roomName
            // 
            this.roomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomName.Location = new System.Drawing.Point(232, 268);
            this.roomName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(436, 70);
            this.roomName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter destination or room#";
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Checked = true;
            this.printLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.printLabel.Location = new System.Drawing.Point(85, 387);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(104, 24);
            this.printLabel.TabIndex = 6;
            this.printLabel.Text = "Print label";
            this.printLabel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AcceptButton = this.checkInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 491);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.checkInText);
            this.Controls.Add(this.parentsName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.CheckBox printLabel;
    }
}