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
            this.lblCar4 = new System.Windows.Forms.Label();
            this.lblCar3 = new System.Windows.Forms.Label();
            this.lblCar2 = new System.Windows.Forms.Label();
            this.lblCar1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.tbRounds = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.lblRounds1 = new System.Windows.Forms.Label();
            this.lblRounds2 = new System.Windows.Forms.Label();
            this.lblRounds3 = new System.Windows.Forms.Label();
            this.lblRounds4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblCar4);
            this.panel1.Controls.Add(this.lblCar3);
            this.panel1.Controls.Add(this.lblCar2);
            this.panel1.Controls.Add(this.lblCar1);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 127);
            this.panel1.TabIndex = 0;
            // 
            // lblCar4
            // 
            this.lblCar4.AutoSize = true;
            this.lblCar4.BackColor = System.Drawing.Color.White;
            this.lblCar4.Location = new System.Drawing.Point(25, 93);
            this.lblCar4.Name = "lblCar4";
            this.lblCar4.Size = new System.Drawing.Size(20, 13);
            this.lblCar4.TabIndex = 3;
            this.lblCar4.Text = "Z4";
            this.lblCar4.Click += new System.EventHandler(this.SetCar);
            // 
            // lblCar3
            // 
            this.lblCar3.AutoSize = true;
            this.lblCar3.BackColor = System.Drawing.Color.White;
            this.lblCar3.Location = new System.Drawing.Point(25, 69);
            this.lblCar3.Name = "lblCar3";
            this.lblCar3.Size = new System.Drawing.Size(20, 13);
            this.lblCar3.TabIndex = 2;
            this.lblCar3.Text = "Z3";
            this.lblCar3.Click += new System.EventHandler(this.SetCar);
            // 
            // lblCar2
            // 
            this.lblCar2.AutoSize = true;
            this.lblCar2.BackColor = System.Drawing.Color.White;
            this.lblCar2.Location = new System.Drawing.Point(25, 45);
            this.lblCar2.Name = "lblCar2";
            this.lblCar2.Size = new System.Drawing.Size(20, 13);
            this.lblCar2.TabIndex = 1;
            this.lblCar2.Text = "Z2";
            this.lblCar2.Click += new System.EventHandler(this.SetCar);
            // 
            // lblCar1
            // 
            this.lblCar1.AutoSize = true;
            this.lblCar1.BackColor = System.Drawing.Color.White;
            this.lblCar1.Location = new System.Drawing.Point(25, 21);
            this.lblCar1.Name = "lblCar1";
            this.lblCar1.Size = new System.Drawing.Size(20, 13);
            this.lblCar1.TabIndex = 0;
            this.lblCar1.Text = "Z1";
            this.lblCar1.Click += new System.EventHandler(this.SetCar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "<1;10>";
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
            this.tbRounds.Location = new System.Drawing.Point(216, 12);
            this.tbRounds.Minimum = 1;
            this.tbRounds.Name = "tbRounds";
            this.tbRounds.Size = new System.Drawing.Size(104, 45);
            this.tbRounds.TabIndex = 4;
            this.tbRounds.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "<1;10>";
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
            // lblRounds1
            // 
            this.lblRounds1.AutoSize = true;
            this.lblRounds1.Location = new System.Drawing.Point(327, 84);
            this.lblRounds1.Name = "lblRounds1";
            this.lblRounds1.Size = new System.Drawing.Size(13, 13);
            this.lblRounds1.TabIndex = 5;
            this.lblRounds1.Text = "0";
            // 
            // lblRounds2
            // 
            this.lblRounds2.AutoSize = true;
            this.lblRounds2.Location = new System.Drawing.Point(326, 108);
            this.lblRounds2.Name = "lblRounds2";
            this.lblRounds2.Size = new System.Drawing.Size(13, 13);
            this.lblRounds2.TabIndex = 6;
            this.lblRounds2.Text = "0";
            // 
            // lblRounds3
            // 
            this.lblRounds3.AutoSize = true;
            this.lblRounds3.Location = new System.Drawing.Point(326, 132);
            this.lblRounds3.Name = "lblRounds3";
            this.lblRounds3.Size = new System.Drawing.Size(13, 13);
            this.lblRounds3.TabIndex = 7;
            this.lblRounds3.Text = "0";
            // 
            // lblRounds4
            // 
            this.lblRounds4.AutoSize = true;
            this.lblRounds4.Location = new System.Drawing.Point(326, 156);
            this.lblRounds4.Name = "lblRounds4";
            this.lblRounds4.Size = new System.Drawing.Size(13, 13);
            this.lblRounds4.TabIndex = 8;
            this.lblRounds4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 205);
            this.Controls.Add(this.lblRounds4);
            this.Controls.Add(this.lblRounds3);
            this.Controls.Add(this.lblRounds2);
            this.Controls.Add(this.lblRounds1);
            this.Controls.Add(this.tbRounds);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCar4;
        private System.Windows.Forms.Label lblCar3;
        private System.Windows.Forms.Label lblCar2;
        private System.Windows.Forms.Label lblCar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.TrackBar tbRounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label lblRounds1;
        private System.Windows.Forms.Label lblRounds2;
        private System.Windows.Forms.Label lblRounds3;
        private System.Windows.Forms.Label lblRounds4;
    }
}

