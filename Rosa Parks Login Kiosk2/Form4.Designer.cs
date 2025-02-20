namespace Rosa_Parks_Login_Kiosk2
{
	partial class Form4
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
            this.logUsers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loggedoutGuest = new System.Windows.Forms.DataGridView();
            this.Visitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loggedoutGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // logUsers
            // 
            this.logUsers.Location = new System.Drawing.Point(18, 18);
            this.logUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logUsers.Multiline = true;
            this.logUsers.Name = "logUsers";
            this.logUsers.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logUsers.Size = new System.Drawing.Size(1135, 582);
            this.logUsers.TabIndex = 0;
            this.logUsers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 625);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loggedoutGuest
            // 
            this.loggedoutGuest.AllowUserToAddRows = false;
            this.loggedoutGuest.AllowUserToDeleteRows = false;
            this.loggedoutGuest.AllowUserToResizeColumns = false;
            this.loggedoutGuest.AllowUserToResizeRows = false;
            this.loggedoutGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loggedoutGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visitor});
            this.loggedoutGuest.Location = new System.Drawing.Point(13, 610);
            this.loggedoutGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loggedoutGuest.MultiSelect = false;
            this.loggedoutGuest.Name = "loggedoutGuest";
            this.loggedoutGuest.ReadOnly = true;
            this.loggedoutGuest.RowHeadersWidth = 62;
            this.loggedoutGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loggedoutGuest.Size = new System.Drawing.Size(733, 82);
            this.loggedoutGuest.TabIndex = 4;
            // 
            // Visitor
            // 
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.MinimumWidth = 8;
            this.Visitor.Name = "Visitor";
            this.Visitor.ReadOnly = true;
            this.Visitor.Width = 600;
            // 
            // Form4
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.loggedoutGuest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loggedoutGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox logUsers;
		private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView loggedoutGuest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visitor;
    }
}