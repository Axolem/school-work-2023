namespace TUT3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TXTidNumber = new System.Windows.Forms.TextBox();
			this.BTNcreate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TXTname = new System.Windows.Forms.TextBox();
			this.BTNsave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.TXTsurname = new System.Windows.Forms.TextBox();
			this.BTNread = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.BTNclear = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.BTNexit = new System.Windows.Forms.Button();
			this.LSTdisplay = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.LBLemail = new System.Windows.Forms.Label();
			this.LBLage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(119, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = "UJ Staff Portal";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID Number:";
			// 
			// TXTidNumber
			// 
			this.TXTidNumber.Location = new System.Drawing.Point(113, 132);
			this.TXTidNumber.Name = "TXTidNumber";
			this.TXTidNumber.Size = new System.Drawing.Size(111, 20);
			this.TXTidNumber.TabIndex = 2;
			// 
			// BTNcreate
			// 
			this.BTNcreate.Location = new System.Drawing.Point(240, 132);
			this.BTNcreate.Name = "BTNcreate";
			this.BTNcreate.Size = new System.Drawing.Size(75, 23);
			this.BTNcreate.TabIndex = 3;
			this.BTNcreate.Text = "Create";
			this.BTNcreate.UseVisualStyleBackColor = true;
			this.BTNcreate.Click += new System.EventHandler(this.BTNcreate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Name:";
			// 
			// TXTname
			// 
			this.TXTname.Location = new System.Drawing.Point(113, 161);
			this.TXTname.Name = "TXTname";
			this.TXTname.Size = new System.Drawing.Size(111, 20);
			this.TXTname.TabIndex = 2;
			// 
			// BTNsave
			// 
			this.BTNsave.Location = new System.Drawing.Point(240, 161);
			this.BTNsave.Name = "BTNsave";
			this.BTNsave.Size = new System.Drawing.Size(75, 23);
			this.BTNsave.TabIndex = 3;
			this.BTNsave.Text = "Save";
			this.BTNsave.UseVisualStyleBackColor = true;
			this.BTNsave.Click += new System.EventHandler(this.BTNsave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 193);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Surname:";
			// 
			// TXTsurname
			// 
			this.TXTsurname.Location = new System.Drawing.Point(113, 190);
			this.TXTsurname.Name = "TXTsurname";
			this.TXTsurname.Size = new System.Drawing.Size(111, 20);
			this.TXTsurname.TabIndex = 2;
			// 
			// BTNread
			// 
			this.BTNread.Location = new System.Drawing.Point(240, 190);
			this.BTNread.Name = "BTNread";
			this.BTNread.Size = new System.Drawing.Size(75, 23);
			this.BTNread.TabIndex = 3;
			this.BTNread.Text = "Read";
			this.BTNread.UseVisualStyleBackColor = true;
			this.BTNread.Click += new System.EventHandler(this.BTNread_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 222);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Email:";
			// 
			// BTNclear
			// 
			this.BTNclear.Location = new System.Drawing.Point(240, 219);
			this.BTNclear.Name = "BTNclear";
			this.BTNclear.Size = new System.Drawing.Size(75, 23);
			this.BTNclear.TabIndex = 3;
			this.BTNclear.Text = "Clear";
			this.BTNclear.UseVisualStyleBackColor = true;
			this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 251);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Age:";
			// 
			// BTNexit
			// 
			this.BTNexit.Location = new System.Drawing.Point(240, 248);
			this.BTNexit.Name = "BTNexit";
			this.BTNexit.Size = new System.Drawing.Size(75, 23);
			this.BTNexit.TabIndex = 3;
			this.BTNexit.Text = "Exit";
			this.BTNexit.UseVisualStyleBackColor = true;
			this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
			// 
			// LSTdisplay
			// 
			this.LSTdisplay.FormattingEnabled = true;
			this.LSTdisplay.Location = new System.Drawing.Point(13, 289);
			this.LSTdisplay.Name = "LSTdisplay";
			this.LSTdisplay.Size = new System.Drawing.Size(302, 95);
			this.LSTdisplay.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(110, 222);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 13);
			this.label7.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(110, 251);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(0, 13);
			this.label8.TabIndex = 1;
			// 
			// LBLemail
			// 
			this.LBLemail.AutoSize = true;
			this.LBLemail.Location = new System.Drawing.Point(110, 229);
			this.LBLemail.Name = "LBLemail";
			this.LBLemail.Size = new System.Drawing.Size(0, 13);
			this.LBLemail.TabIndex = 1;
			// 
			// LBLage
			// 
			this.LBLage.AutoSize = true;
			this.LBLage.Location = new System.Drawing.Point(110, 253);
			this.LBLage.Name = "LBLage";
			this.LBLage.Size = new System.Drawing.Size(0, 13);
			this.LBLage.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 396);
			this.Controls.Add(this.LSTdisplay);
			this.Controls.Add(this.BTNexit);
			this.Controls.Add(this.BTNclear);
			this.Controls.Add(this.BTNread);
			this.Controls.Add(this.TXTsurname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.BTNsave);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.LBLage);
			this.Controls.Add(this.LBLemail);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TXTname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BTNcreate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TXTidNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXTidNumber;
		private System.Windows.Forms.Button BTNcreate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXTname;
		private System.Windows.Forms.Button BTNsave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TXTsurname;
		private System.Windows.Forms.Button BTNread;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BTNclear;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BTNexit;
		private System.Windows.Forms.ListBox LSTdisplay;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label LBLemail;
		private System.Windows.Forms.Label LBLage;
	}
}

