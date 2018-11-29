namespace _181101_Černý1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.tbRounds = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.numCarsNumber = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPocet = new System.Windows.Forms.Label();
            this.lblKolo = new System.Windows.Forms.Label();
            this.btnStartAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rychlost";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(58, 12);
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(104, 45);
            this.tbSpeed.TabIndex = 2;
            this.tbSpeed.Value = 1;
            // 
            // tbRounds
            // 
            this.tbRounds.Location = new System.Drawing.Point(247, 12);
            this.tbRounds.Minimum = 1;
            this.tbRounds.Name = "tbRounds";
            this.tbRounds.Size = new System.Drawing.Size(104, 45);
            this.tbRounds.TabIndex = 4;
            this.tbRounds.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Počet kol";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.FullOpen = true;
            // 
            // numCarsNumber
            // 
            this.numCarsNumber.Location = new System.Drawing.Point(93, 49);
            this.numCarsNumber.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numCarsNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCarsNumber.Name = "numCarsNumber";
            this.numCarsNumber.Size = new System.Drawing.Size(37, 20);
            this.numCarsNumber.TabIndex = 9;
            this.numCarsNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCarsNumber.ValueChanged += new System.EventHandler(this.numCarsNumber_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(326, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 74);
            this.panel2.TabIndex = 10;
            // 
            // lblPocet
            // 
            this.lblPocet.AutoSize = true;
            this.lblPocet.Location = new System.Drawing.Point(12, 51);
            this.lblPocet.Name = "lblPocet";
            this.lblPocet.Size = new System.Drawing.Size(75, 13);
            this.lblPocet.TabIndex = 11;
            this.lblPocet.Text = "Počet autíček";
            // 
            // lblKolo
            // 
            this.lblKolo.AutoSize = true;
            this.lblKolo.Location = new System.Drawing.Point(323, 80);
            this.lblKolo.Name = "lblKolo";
            this.lblKolo.Size = new System.Drawing.Size(31, 13);
            this.lblKolo.TabIndex = 12;
            this.lblKolo.Text = "Kolo:";
            // 
            // btnStartAll
            // 
            this.btnStartAll.Location = new System.Drawing.Point(136, 48);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(75, 23);
            this.btnStartAll.TabIndex = 13;
            this.btnStartAll.Text = "Spustit vše";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 166);
            this.Controls.Add(this.lblKolo);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.lblPocet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numCarsNumber);
            this.Controls.Add(this.tbRounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCarsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.TrackBar tbRounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.NumericUpDown numCarsNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPocet;
        private System.Windows.Forms.Label lblKolo;
        private System.Windows.Forms.Button btnStartAll;
    }
}

