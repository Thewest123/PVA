namespace _190110c
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
            this.tbVstup = new System.Windows.Forms.TextBox();
            this.btnSplitAsterisk = new System.Windows.Forms.Button();
            this.btnSplitLowerA = new System.Windows.Forms.Button();
            this.btnSplitSlash = new System.Windows.Forms.Button();
            this.btnSplitMinus = new System.Windows.Forms.Button();
            this.btnSplitDot = new System.Windows.Forms.Button();
            this.rtbVystup = new System.Windows.Forms.RichTextBox();
            this.btnSubstring1 = new System.Windows.Forms.Button();
            this.btnSubstring2 = new System.Windows.Forms.Button();
            this.nudOd = new System.Windows.Forms.NumericUpDown();
            this.nudKolik = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplace1 = new System.Windows.Forms.Button();
            this.btnReplace2 = new System.Windows.Forms.Button();
            this.tbCo = new System.Windows.Forms.TextBox();
            this.tbČím = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPadRight1 = new System.Windows.Forms.Button();
            this.btnPadLeft1 = new System.Windows.Forms.Button();
            this.btnSplitCapitalA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNa = new System.Windows.Forms.NumericUpDown();
            this.btnPadLeft2 = new System.Windows.Forms.Button();
            this.btnPadRight2 = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btbSplitTwo = new System.Windows.Forms.Button();
            this.btnSplitX = new System.Windows.Forms.Button();
            this.btnSplitTilda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbZnaky = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudOd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNa)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVstup
            // 
            this.tbVstup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVstup.Location = new System.Drawing.Point(12, 12);
            this.tbVstup.Multiline = true;
            this.tbVstup.Name = "tbVstup";
            this.tbVstup.Size = new System.Drawing.Size(287, 67);
            this.tbVstup.TabIndex = 0;
            this.tbVstup.Text = "123*456*789";
            // 
            // btnSplitAsterisk
            // 
            this.btnSplitAsterisk.Location = new System.Drawing.Point(12, 85);
            this.btnSplitAsterisk.Name = "btnSplitAsterisk";
            this.btnSplitAsterisk.Size = new System.Drawing.Size(25, 23);
            this.btnSplitAsterisk.TabIndex = 1;
            this.btnSplitAsterisk.Text = "*";
            this.btnSplitAsterisk.UseVisualStyleBackColor = true;
            this.btnSplitAsterisk.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitLowerA
            // 
            this.btnSplitLowerA.Location = new System.Drawing.Point(12, 108);
            this.btnSplitLowerA.Name = "btnSplitLowerA";
            this.btnSplitLowerA.Size = new System.Drawing.Size(25, 23);
            this.btnSplitLowerA.TabIndex = 2;
            this.btnSplitLowerA.Text = "a";
            this.btnSplitLowerA.UseVisualStyleBackColor = true;
            this.btnSplitLowerA.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitSlash
            // 
            this.btnSplitSlash.Location = new System.Drawing.Point(12, 131);
            this.btnSplitSlash.Name = "btnSplitSlash";
            this.btnSplitSlash.Size = new System.Drawing.Size(25, 23);
            this.btnSplitSlash.TabIndex = 3;
            this.btnSplitSlash.Text = "/";
            this.btnSplitSlash.UseVisualStyleBackColor = true;
            this.btnSplitSlash.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitMinus
            // 
            this.btnSplitMinus.Location = new System.Drawing.Point(12, 154);
            this.btnSplitMinus.Name = "btnSplitMinus";
            this.btnSplitMinus.Size = new System.Drawing.Size(25, 23);
            this.btnSplitMinus.TabIndex = 4;
            this.btnSplitMinus.Text = "-";
            this.btnSplitMinus.UseVisualStyleBackColor = true;
            this.btnSplitMinus.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitDot
            // 
            this.btnSplitDot.Location = new System.Drawing.Point(12, 177);
            this.btnSplitDot.Name = "btnSplitDot";
            this.btnSplitDot.Size = new System.Drawing.Size(25, 23);
            this.btnSplitDot.TabIndex = 5;
            this.btnSplitDot.Text = ".";
            this.btnSplitDot.UseVisualStyleBackColor = true;
            this.btnSplitDot.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // rtbVystup
            // 
            this.rtbVystup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbVystup.Location = new System.Drawing.Point(12, 301);
            this.rtbVystup.Name = "rtbVystup";
            this.rtbVystup.Size = new System.Drawing.Size(287, 135);
            this.rtbVystup.TabIndex = 6;
            this.rtbVystup.Text = "";
            // 
            // btnSubstring1
            // 
            this.btnSubstring1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubstring1.Location = new System.Drawing.Point(43, 85);
            this.btnSubstring1.Name = "btnSubstring1";
            this.btnSubstring1.Size = new System.Drawing.Size(140, 23);
            this.btnSubstring1.TabIndex = 7;
            this.btnSubstring1.Text = "SubString(od)";
            this.btnSubstring1.UseVisualStyleBackColor = true;
            this.btnSubstring1.Click += new System.EventHandler(this.btnSubstring1_Click);
            // 
            // btnSubstring2
            // 
            this.btnSubstring2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubstring2.Location = new System.Drawing.Point(43, 108);
            this.btnSubstring2.Name = "btnSubstring2";
            this.btnSubstring2.Size = new System.Drawing.Size(140, 23);
            this.btnSubstring2.TabIndex = 8;
            this.btnSubstring2.Text = "SubString(od,kolik)";
            this.btnSubstring2.UseVisualStyleBackColor = true;
            this.btnSubstring2.Click += new System.EventHandler(this.btnSubstring2_Click);
            // 
            // nudOd
            // 
            this.nudOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudOd.Location = new System.Drawing.Point(248, 88);
            this.nudOd.Name = "nudOd";
            this.nudOd.Size = new System.Drawing.Size(51, 20);
            this.nudOd.TabIndex = 9;
            this.nudOd.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudKolik
            // 
            this.nudKolik.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudKolik.Location = new System.Drawing.Point(248, 111);
            this.nudKolik.Name = "nudKolik";
            this.nudKolik.Size = new System.Drawing.Size(51, 20);
            this.nudKolik.TabIndex = 10;
            this.nudKolik.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "od";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "kolik";
            // 
            // btnReplace1
            // 
            this.btnReplace1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace1.Location = new System.Drawing.Point(43, 131);
            this.btnReplace1.Name = "btnReplace1";
            this.btnReplace1.Size = new System.Drawing.Size(140, 23);
            this.btnReplace1.TabIndex = 13;
            this.btnReplace1.Text = "Replace(z,z)";
            this.btnReplace1.UseVisualStyleBackColor = true;
            this.btnReplace1.Click += new System.EventHandler(this.btnReplace1_Click);
            // 
            // btnReplace2
            // 
            this.btnReplace2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace2.Location = new System.Drawing.Point(43, 154);
            this.btnReplace2.Name = "btnReplace2";
            this.btnReplace2.Size = new System.Drawing.Size(140, 23);
            this.btnReplace2.TabIndex = 14;
            this.btnReplace2.Text = "Replace(s,s)";
            this.btnReplace2.UseVisualStyleBackColor = true;
            this.btnReplace2.Click += new System.EventHandler(this.btnReplace2_Click);
            // 
            // tbCo
            // 
            this.tbCo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCo.Location = new System.Drawing.Point(248, 133);
            this.tbCo.Name = "tbCo";
            this.tbCo.Size = new System.Drawing.Size(51, 20);
            this.tbCo.TabIndex = 15;
            // 
            // tbČím
            // 
            this.tbČím.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbČím.Location = new System.Drawing.Point(248, 156);
            this.tbČím.Name = "tbČím";
            this.tbČím.Size = new System.Drawing.Size(51, 20);
            this.tbČím.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "čím";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "co";
            // 
            // btnPadRight1
            // 
            this.btnPadRight1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPadRight1.Location = new System.Drawing.Point(43, 223);
            this.btnPadRight1.Name = "btnPadRight1";
            this.btnPadRight1.Size = new System.Drawing.Size(140, 23);
            this.btnPadRight1.TabIndex = 20;
            this.btnPadRight1.Text = "PadRight(i)";
            this.btnPadRight1.UseVisualStyleBackColor = true;
            this.btnPadRight1.Click += new System.EventHandler(this.btnPadRight1_Click);
            // 
            // btnPadLeft1
            // 
            this.btnPadLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPadLeft1.Location = new System.Drawing.Point(43, 177);
            this.btnPadLeft1.Name = "btnPadLeft1";
            this.btnPadLeft1.Size = new System.Drawing.Size(140, 23);
            this.btnPadLeft1.TabIndex = 19;
            this.btnPadLeft1.Text = "PadLeft(i)";
            this.btnPadLeft1.UseVisualStyleBackColor = true;
            this.btnPadLeft1.Click += new System.EventHandler(this.btnPadLeft1_Click);
            // 
            // btnSplitCapitalA
            // 
            this.btnSplitCapitalA.Location = new System.Drawing.Point(12, 200);
            this.btnSplitCapitalA.Name = "btnSplitCapitalA";
            this.btnSplitCapitalA.Size = new System.Drawing.Size(25, 23);
            this.btnSplitCapitalA.TabIndex = 21;
            this.btnSplitCapitalA.Text = "A";
            this.btnSplitCapitalA.UseVisualStyleBackColor = true;
            this.btnSplitCapitalA.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "na";
            // 
            // nudNa
            // 
            this.nudNa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNa.Location = new System.Drawing.Point(248, 180);
            this.nudNa.Name = "nudNa";
            this.nudNa.Size = new System.Drawing.Size(51, 20);
            this.nudNa.TabIndex = 22;
            this.nudNa.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnPadLeft2
            // 
            this.btnPadLeft2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPadLeft2.Location = new System.Drawing.Point(43, 200);
            this.btnPadLeft2.Name = "btnPadLeft2";
            this.btnPadLeft2.Size = new System.Drawing.Size(140, 23);
            this.btnPadLeft2.TabIndex = 24;
            this.btnPadLeft2.Text = "PadLeft(i,z)";
            this.btnPadLeft2.UseVisualStyleBackColor = true;
            this.btnPadLeft2.Click += new System.EventHandler(this.btnPadLeft2_Click);
            // 
            // btnPadRight2
            // 
            this.btnPadRight2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPadRight2.Location = new System.Drawing.Point(43, 246);
            this.btnPadRight2.Name = "btnPadRight2";
            this.btnPadRight2.Size = new System.Drawing.Size(140, 23);
            this.btnPadRight2.TabIndex = 25;
            this.btnPadRight2.Text = "PadRight(i,z)";
            this.btnPadRight2.UseVisualStyleBackColor = true;
            this.btnPadRight2.Click += new System.EventHandler(this.btnPadRight2_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrim.Location = new System.Drawing.Point(43, 269);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(140, 23);
            this.btnTrim.TabIndex = 26;
            this.btnTrim.Text = "Trim...";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btbSplitTwo
            // 
            this.btbSplitTwo.Location = new System.Drawing.Point(12, 223);
            this.btbSplitTwo.Name = "btbSplitTwo";
            this.btbSplitTwo.Size = new System.Drawing.Size(25, 23);
            this.btbSplitTwo.TabIndex = 27;
            this.btbSplitTwo.Text = "2";
            this.btbSplitTwo.UseVisualStyleBackColor = true;
            this.btbSplitTwo.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitX
            // 
            this.btnSplitX.Location = new System.Drawing.Point(12, 246);
            this.btnSplitX.Name = "btnSplitX";
            this.btnSplitX.Size = new System.Drawing.Size(25, 23);
            this.btnSplitX.TabIndex = 28;
            this.btnSplitX.Text = "x";
            this.btnSplitX.UseVisualStyleBackColor = true;
            this.btnSplitX.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // btnSplitTilda
            // 
            this.btnSplitTilda.Location = new System.Drawing.Point(12, 269);
            this.btnSplitTilda.Name = "btnSplitTilda";
            this.btnSplitTilda.Size = new System.Drawing.Size(25, 23);
            this.btnSplitTilda.TabIndex = 29;
            this.btnSplitTilda.Text = "~";
            this.btnSplitTilda.UseVisualStyleBackColor = true;
            this.btnSplitTilda.Click += new System.EventHandler(this.btnSplitAny_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "znaky";
            // 
            // tbZnaky
            // 
            this.tbZnaky.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbZnaky.Location = new System.Drawing.Point(248, 272);
            this.tbZnaky.Name = "tbZnaky";
            this.tbZnaky.Size = new System.Drawing.Size(51, 20);
            this.tbZnaky.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbZnaky);
            this.Controls.Add(this.btnSplitTilda);
            this.Controls.Add(this.btnSplitX);
            this.Controls.Add(this.btbSplitTwo);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnPadRight2);
            this.Controls.Add(this.btnPadLeft2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudNa);
            this.Controls.Add(this.btnSplitCapitalA);
            this.Controls.Add(this.btnPadRight1);
            this.Controls.Add(this.btnPadLeft1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbČím);
            this.Controls.Add(this.tbCo);
            this.Controls.Add(this.btnReplace2);
            this.Controls.Add(this.btnReplace1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudKolik);
            this.Controls.Add(this.nudOd);
            this.Controls.Add(this.btnSubstring2);
            this.Controls.Add(this.btnSubstring1);
            this.Controls.Add(this.rtbVystup);
            this.Controls.Add(this.btnSplitDot);
            this.Controls.Add(this.btnSplitMinus);
            this.Controls.Add(this.btnSplitSlash);
            this.Controls.Add(this.btnSplitLowerA);
            this.Controls.Add(this.btnSplitAsterisk);
            this.Controls.Add(this.tbVstup);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudOd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVstup;
        private System.Windows.Forms.Button btnSplitAsterisk;
        private System.Windows.Forms.Button btnSplitLowerA;
        private System.Windows.Forms.Button btnSplitSlash;
        private System.Windows.Forms.Button btnSplitMinus;
        private System.Windows.Forms.Button btnSplitDot;
        private System.Windows.Forms.RichTextBox rtbVystup;
        private System.Windows.Forms.Button btnSubstring1;
        private System.Windows.Forms.Button btnSubstring2;
        private System.Windows.Forms.NumericUpDown nudOd;
        private System.Windows.Forms.NumericUpDown nudKolik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReplace1;
        private System.Windows.Forms.Button btnReplace2;
        private System.Windows.Forms.TextBox tbCo;
        private System.Windows.Forms.TextBox tbČím;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPadRight1;
        private System.Windows.Forms.Button btnPadLeft1;
        private System.Windows.Forms.Button btnSplitCapitalA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudNa;
        private System.Windows.Forms.Button btnPadLeft2;
        private System.Windows.Forms.Button btnPadRight2;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btbSplitTwo;
        private System.Windows.Forms.Button btnSplitX;
        private System.Windows.Forms.Button btnSplitTilda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbZnaky;
    }
}

