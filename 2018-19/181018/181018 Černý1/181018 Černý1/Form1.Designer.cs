namespace _181018_Černý1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numNasobenec = new System.Windows.Forms.NumericUpDown();
            this.numPocet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVypis = new System.Windows.Forms.Button();
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNasobenec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Násobenec <-10;10>";
            // 
            // numNasobenec
            // 
            this.numNasobenec.Location = new System.Drawing.Point(127, 12);
            this.numNasobenec.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNasobenec.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numNasobenec.Name = "numNasobenec";
            this.numNasobenec.Size = new System.Drawing.Size(55, 20);
            this.numNasobenec.TabIndex = 1;
            this.numNasobenec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPocet
            // 
            this.numPocet.Location = new System.Drawing.Point(267, 12);
            this.numPocet.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numPocet.Name = "numPocet";
            this.numPocet.Size = new System.Drawing.Size(54, 20);
            this.numPocet.TabIndex = 3;
            this.numPocet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Počet <0;9>";
            // 
            // btnVypis
            // 
            this.btnVypis.Location = new System.Drawing.Point(337, 10);
            this.btnVypis.Name = "btnVypis";
            this.btnVypis.Size = new System.Drawing.Size(75, 23);
            this.btnVypis.TabIndex = 4;
            this.btnVypis.Text = "Násobilka";
            this.btnVypis.UseVisualStyleBackColor = true;
            this.btnVypis.Click += new System.EventHandler(this.btnVypis_Click);
            // 
            // rtbOut
            // 
            this.rtbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOut.Location = new System.Drawing.Point(12, 44);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(400, 167);
            this.rtbOut.TabIndex = 5;
            this.rtbOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 223);
            this.Controls.Add(this.rtbOut);
            this.Controls.Add(this.btnVypis);
            this.Controls.Add(this.numPocet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numNasobenec);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Násobilka";
            ((System.ComponentModel.ISupportInitialize)(this.numNasobenec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPocet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNasobenec;
        private System.Windows.Forms.NumericUpDown numPocet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVypis;
        private System.Windows.Forms.RichTextBox rtbOut;
    }
}

