namespace LabEx1_Question1
{
    partial class CalculatorApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorApp));
            this.TXTBXdisplay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTNminus = new System.Windows.Forms.Button();
            this.BTNmultiply = new System.Windows.Forms.Button();
            this.BTNdevide = new System.Windows.Forms.Button();
            this.BTNnine = new System.Windows.Forms.Button();
            this.BTNsix = new System.Windows.Forms.Button();
            this.BTNthree = new System.Windows.Forms.Button();
            this.BTNeight = new System.Windows.Forms.Button();
            this.BTNseven = new System.Windows.Forms.Button();
            this.BTNfive = new System.Windows.Forms.Button();
            this.BTNfour = new System.Windows.Forms.Button();
            this.BTNtwo = new System.Windows.Forms.Button();
            this.BTNone = new System.Windows.Forms.Button();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNzero = new System.Windows.Forms.Button();
            this.BTNequalsTo = new System.Windows.Forms.Button();
            this.BTNplus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTBXdisplay
            // 
            this.TXTBXdisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TXTBXdisplay.Cursor = System.Windows.Forms.Cursors.No;
            this.TXTBXdisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTBXdisplay.Location = new System.Drawing.Point(12, 12);
            this.TXTBXdisplay.Name = "TXTBXdisplay";
            this.TXTBXdisplay.ReadOnly = true;
            this.TXTBXdisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTBXdisplay.Size = new System.Drawing.Size(238, 35);
            this.TXTBXdisplay.TabIndex = 1;
            this.TXTBXdisplay.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNminus);
            this.groupBox1.Controls.Add(this.BTNmultiply);
            this.groupBox1.Controls.Add(this.BTNdevide);
            this.groupBox1.Controls.Add(this.BTNnine);
            this.groupBox1.Controls.Add(this.BTNsix);
            this.groupBox1.Controls.Add(this.BTNthree);
            this.groupBox1.Controls.Add(this.BTNeight);
            this.groupBox1.Controls.Add(this.BTNseven);
            this.groupBox1.Controls.Add(this.BTNfive);
            this.groupBox1.Controls.Add(this.BTNfour);
            this.groupBox1.Controls.Add(this.BTNtwo);
            this.groupBox1.Controls.Add(this.BTNone);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 248);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BTNminus
            // 
            this.BTNminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNminus.Location = new System.Drawing.Point(178, 128);
            this.BTNminus.Name = "BTNminus";
            this.BTNminus.Size = new System.Drawing.Size(50, 50);
            this.BTNminus.TabIndex = 0;
            this.BTNminus.Text = "-";
            this.BTNminus.UseVisualStyleBackColor = true;
            this.BTNminus.Click += new System.EventHandler(this.Action_All_Operators_Clicks);
            // 
            // BTNmultiply
            // 
            this.BTNmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNmultiply.Location = new System.Drawing.Point(178, 71);
            this.BTNmultiply.Name = "BTNmultiply";
            this.BTNmultiply.Size = new System.Drawing.Size(50, 50);
            this.BTNmultiply.TabIndex = 0;
            this.BTNmultiply.Text = "*";
            this.BTNmultiply.UseVisualStyleBackColor = true;
            this.BTNmultiply.Click += new System.EventHandler(this.Action_All_Operators_Clicks);
            // 
            // BTNdevide
            // 
            this.BTNdevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNdevide.Location = new System.Drawing.Point(178, 15);
            this.BTNdevide.MaximumSize = new System.Drawing.Size(50, 50);
            this.BTNdevide.MinimumSize = new System.Drawing.Size(50, 50);
            this.BTNdevide.Name = "BTNdevide";
            this.BTNdevide.Size = new System.Drawing.Size(50, 50);
            this.BTNdevide.TabIndex = 0;
            this.BTNdevide.Text = "/";
            this.BTNdevide.UseVisualStyleBackColor = true;
            this.BTNdevide.Click += new System.EventHandler(this.Action_All_Operators_Clicks);
            // 
            // BTNnine
            // 
            this.BTNnine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNnine.Location = new System.Drawing.Point(122, 127);
            this.BTNnine.Name = "BTNnine";
            this.BTNnine.Size = new System.Drawing.Size(50, 50);
            this.BTNnine.TabIndex = 0;
            this.BTNnine.Text = "9";
            this.BTNnine.UseVisualStyleBackColor = true;
            this.BTNnine.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNsix
            // 
            this.BTNsix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsix.Location = new System.Drawing.Point(122, 71);
            this.BTNsix.Name = "BTNsix";
            this.BTNsix.Size = new System.Drawing.Size(50, 50);
            this.BTNsix.TabIndex = 0;
            this.BTNsix.Text = "6";
            this.BTNsix.UseVisualStyleBackColor = true;
            this.BTNsix.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNthree
            // 
            this.BTNthree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNthree.Location = new System.Drawing.Point(122, 15);
            this.BTNthree.Name = "BTNthree";
            this.BTNthree.Size = new System.Drawing.Size(50, 50);
            this.BTNthree.TabIndex = 0;
            this.BTNthree.Text = "3";
            this.BTNthree.UseVisualStyleBackColor = true;
            this.BTNthree.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNeight
            // 
            this.BTNeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNeight.Location = new System.Drawing.Point(66, 128);
            this.BTNeight.Name = "BTNeight";
            this.BTNeight.Size = new System.Drawing.Size(50, 50);
            this.BTNeight.TabIndex = 0;
            this.BTNeight.Text = "8";
            this.BTNeight.UseVisualStyleBackColor = true;
            this.BTNeight.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNseven
            // 
            this.BTNseven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNseven.Location = new System.Drawing.Point(10, 128);
            this.BTNseven.Name = "BTNseven";
            this.BTNseven.Size = new System.Drawing.Size(50, 50);
            this.BTNseven.TabIndex = 0;
            this.BTNseven.Text = "7";
            this.BTNseven.UseVisualStyleBackColor = true;
            this.BTNseven.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNfive
            // 
            this.BTNfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfive.Location = new System.Drawing.Point(66, 72);
            this.BTNfive.Name = "BTNfive";
            this.BTNfive.Size = new System.Drawing.Size(50, 50);
            this.BTNfive.TabIndex = 0;
            this.BTNfive.Text = "5";
            this.BTNfive.UseVisualStyleBackColor = true;
            this.BTNfive.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNfour
            // 
            this.BTNfour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNfour.Location = new System.Drawing.Point(10, 72);
            this.BTNfour.Name = "BTNfour";
            this.BTNfour.Size = new System.Drawing.Size(50, 50);
            this.BTNfour.TabIndex = 0;
            this.BTNfour.Text = "4";
            this.BTNfour.UseVisualStyleBackColor = true;
            this.BTNfour.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNtwo
            // 
            this.BTNtwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNtwo.Location = new System.Drawing.Point(66, 16);
            this.BTNtwo.Name = "BTNtwo";
            this.BTNtwo.Size = new System.Drawing.Size(50, 50);
            this.BTNtwo.TabIndex = 0;
            this.BTNtwo.Text = "2";
            this.BTNtwo.UseVisualStyleBackColor = true;
            this.BTNtwo.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNone
            // 
            this.BTNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNone.Location = new System.Drawing.Point(10, 16);
            this.BTNone.Name = "BTNone";
            this.BTNone.Size = new System.Drawing.Size(50, 50);
            this.BTNone.TabIndex = 0;
            this.BTNone.Text = "1";
            this.BTNone.UseVisualStyleBackColor = true;
            this.BTNone.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNclear
            // 
            this.BTNclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNclear.Location = new System.Drawing.Point(22, 248);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(50, 50);
            this.BTNclear.TabIndex = 0;
            this.BTNclear.Text = "C";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNzero
            // 
            this.BTNzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNzero.Location = new System.Drawing.Point(78, 248);
            this.BTNzero.Name = "BTNzero";
            this.BTNzero.Size = new System.Drawing.Size(50, 50);
            this.BTNzero.TabIndex = 0;
            this.BTNzero.Text = "0";
            this.BTNzero.UseVisualStyleBackColor = true;
            this.BTNzero.Click += new System.EventHandler(this.Action_All_Numbers_Clicks);
            // 
            // BTNequalsTo
            // 
            this.BTNequalsTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNequalsTo.Location = new System.Drawing.Point(134, 247);
            this.BTNequalsTo.Name = "BTNequalsTo";
            this.BTNequalsTo.Size = new System.Drawing.Size(50, 50);
            this.BTNequalsTo.TabIndex = 0;
            this.BTNequalsTo.Text = "=";
            this.BTNequalsTo.UseVisualStyleBackColor = true;
            this.BTNequalsTo.Click += new System.EventHandler(this.BTNequalsTo_Click);
            // 
            // BTNplus
            // 
            this.BTNplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNplus.Location = new System.Drawing.Point(190, 247);
            this.BTNplus.Name = "BTNplus";
            this.BTNplus.Size = new System.Drawing.Size(50, 50);
            this.BTNplus.TabIndex = 0;
            this.BTNplus.Text = "+";
            this.BTNplus.UseVisualStyleBackColor = true;
            this.BTNplus.Click += new System.EventHandler(this.Action_All_Operators_Clicks);
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(262, 319);
            this.Controls.Add(this.BTNplus);
            this.Controls.Add(this.TXTBXdisplay);
            this.Controls.Add(this.BTNzero);
            this.Controls.Add(this.BTNequalsTo);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(278, 358);
            this.MinimumSize = new System.Drawing.Size(278, 358);
            this.Name = "CalculatorApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axole\'s Calulator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBXdisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNone;
        private System.Windows.Forms.Button BTNminus;
        private System.Windows.Forms.Button BTNmultiply;
        private System.Windows.Forms.Button BTNdevide;
        private System.Windows.Forms.Button BTNnine;
        private System.Windows.Forms.Button BTNsix;
        private System.Windows.Forms.Button BTNthree;
        private System.Windows.Forms.Button BTNeight;
        private System.Windows.Forms.Button BTNseven;
        private System.Windows.Forms.Button BTNfive;
        private System.Windows.Forms.Button BTNfour;
        private System.Windows.Forms.Button BTNtwo;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNzero;
        private System.Windows.Forms.Button BTNequalsTo;
        private System.Windows.Forms.Button BTNplus;
    }
}

