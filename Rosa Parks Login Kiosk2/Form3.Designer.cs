namespace Rosa_Parks_Login_Kiosk2
{
	partial class Form3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.loggedinGuest = new System.Windows.Forms.DataGridView();
			this.Visitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.loggedinGuest)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(677, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Logout";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(555, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Check your name in this list and then click Log Out.";
			// 
			// loggedinGuest
			// 
			this.loggedinGuest.AllowUserToAddRows = false;
			this.loggedinGuest.AllowUserToDeleteRows = false;
			this.loggedinGuest.AllowUserToResizeColumns = false;
			this.loggedinGuest.AllowUserToResizeRows = false;
			this.loggedinGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loggedinGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visitor});
			this.loggedinGuest.Location = new System.Drawing.Point(75, 64);
			this.loggedinGuest.MultiSelect = false;
			this.loggedinGuest.Name = "loggedinGuest";
			this.loggedinGuest.ReadOnly = true;
			this.loggedinGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loggedinGuest.Size = new System.Drawing.Size(703, 301);
			this.loggedinGuest.TabIndex = 3;
			// 
			// Visitor
			// 
			this.Visitor.HeaderText = "Visitor";
			this.Visitor.Name = "Visitor";
			this.Visitor.ReadOnly = true;
			this.Visitor.Width = 600;
			// 
			// Form3
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.loggedinGuest);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Logout";
			this.Load += new System.EventHandler(this.Form3_Load);
			((System.ComponentModel.ISupportInitialize)(this.loggedinGuest)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView loggedinGuest;
		private System.Windows.Forms.DataGridViewTextBoxColumn Visitor;
	}
}