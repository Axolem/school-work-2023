namespace LabEx1_Questio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTNcalculate = new System.Windows.Forms.Button();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNexit = new System.Windows.Forms.Button();
            this.TXTBXname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTBXprice = new System.Windows.Forms.TextBox();
            this.LSTBXdisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // BTNcalculate
            // 
            this.BTNcalculate.Location = new System.Drawing.Point(12, 240);
            this.BTNcalculate.Name = "BTNcalculate";
            this.BTNcalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNcalculate.TabIndex = 2;
            this.BTNcalculate.Text = "Calculate";
            this.BTNcalculate.UseVisualStyleBackColor = true;
            this.BTNcalculate.Click += new System.EventHandler(this.BTNcalculate_Click);
            // 
            // BTNclear
            // 
            this.BTNclear.Location = new System.Drawing.Point(127, 240);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(75, 23);
            this.BTNclear.TabIndex = 2;
            this.BTNclear.Text = "Clear";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNexit
            // 
            this.BTNexit.Location = new System.Drawing.Point(243, 240);
            this.BTNexit.Name = "BTNexit";
            this.BTNexit.Size = new System.Drawing.Size(75, 23);
            this.BTNexit.TabIndex = 2;
            this.BTNexit.Text = "Exit";
            this.BTNexit.UseVisualStyleBackColor = true;
            this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // TXTBXname
            // 
            this.TXTBXname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBXname.Location = new System.Drawing.Point(55, 21);
            this.TXTBXname.Name = "TXTBXname";
            this.TXTBXname.Size = new System.Drawing.Size(134, 25);
            this.TXTBXname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price:";
            // 
            // TXTBXprice
            // 
            this.TXTBXprice.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBXprice.Location = new System.Drawing.Point(243, 21);
            this.TXTBXprice.Name = "TXTBXprice";
            this.TXTBXprice.Size = new System.Drawing.Size(75, 25);
            this.TXTBXprice.TabIndex = 3;
            // 
            // LSTBXdisplay
            // 
            this.LSTBXdisplay.FormattingEnabled = true;
            this.LSTBXdisplay.Location = new System.Drawing.Point(12, 68);
            this.LSTBXdisplay.Name = "LSTBXdisplay";
            this.LSTBXdisplay.Size = new System.Drawing.Size(306, 147);
            this.LSTBXdisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 278);
            this.Controls.Add(this.LSTBXdisplay);
            this.Controls.Add(this.TXTBXprice);
            this.Controls.Add(this.TXTBXname);
            this.Controls.Add(this.BTNexit);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNcalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Payment schedule";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNcalculate;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNexit;
        private System.Windows.Forms.TextBox TXTBXname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTBXprice;
        private System.Windows.Forms.ListBox LSTBXdisplay;
    }
}

