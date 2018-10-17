namespace _181011p
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
            this.rtbVýpis = new System.Windows.Forms.RichTextBox();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnCyan = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnMagenta = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.tbMagenta = new System.Windows.Forms.TrackBar();
            this.tbYellow = new System.Windows.Forms.TrackBar();
            this.tbCyan = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMagenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCyan)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbVýpis
            // 
            this.rtbVýpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbVýpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rtbVýpis.Location = new System.Drawing.Point(12, 356);
            this.rtbVýpis.Name = "rtbVýpis";
            this.rtbVýpis.Size = new System.Drawing.Size(607, 47);
            this.rtbVýpis.TabIndex = 4;
            this.rtbVýpis.Text = "";
            // 
            // tbRed
            // 
            this.tbRed.BackColor = System.Drawing.Color.Red;
            this.tbRed.LargeChange = 20;
            this.tbRed.Location = new System.Drawing.Point(12, 12);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(183, 45);
            this.tbRed.TabIndex = 8;
            this.tbRed.TickFrequency = 10;
            this.tbRed.Value = 255;
            this.tbRed.ValueChanged += new System.EventHandler(this.tbRed_ValueChanged);
            // 
            // btnGray
            // 
            this.btnGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGray.BackColor = System.Drawing.Color.Gray;
            this.btnGray.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGray.Location = new System.Drawing.Point(400, 310);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(89, 30);
            this.btnGray.TabIndex = 15;
            this.btnGray.Text = "D";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnCyan
            // 
            this.btnCyan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCyan.BackColor = System.Drawing.Color.Cyan;
            this.btnCyan.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCyan.Location = new System.Drawing.Point(580, 274);
            this.btnCyan.Name = "btnCyan";
            this.btnCyan.Size = new System.Drawing.Size(30, 30);
            this.btnCyan.TabIndex = 14;
            this.btnCyan.Text = "x";
            this.btnCyan.UseVisualStyleBackColor = false;
            this.btnCyan.Click += new System.EventHandler(this.btnCyan_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnYellow.Location = new System.Drawing.Point(543, 274);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(30, 30);
            this.btnYellow.TabIndex = 13;
            this.btnYellow.Text = "y";
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnGreen.Location = new System.Drawing.Point(508, 274);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(29, 30);
            this.btnGreen.TabIndex = 12;
            this.btnGreen.Text = "p";
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRed.Location = new System.Drawing.Point(472, 274);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(30, 30);
            this.btnRed.TabIndex = 11;
            this.btnRed.Text = "z";
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnMagenta
            // 
            this.btnMagenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMagenta.BackColor = System.Drawing.Color.Magenta;
            this.btnMagenta.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnMagenta.Location = new System.Drawing.Point(436, 274);
            this.btnMagenta.Name = "btnMagenta";
            this.btnMagenta.Size = new System.Drawing.Size(29, 30);
            this.btnMagenta.TabIndex = 10;
            this.btnMagenta.Text = "q";
            this.btnMagenta.UseVisualStyleBackColor = false;
            this.btnMagenta.Click += new System.EventHandler(this.btnMagenta_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBlue.Location = new System.Drawing.Point(399, 274);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(30, 30);
            this.btnBlue.TabIndex = 9;
            this.btnBlue.Text = "{";
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // tbBlue
            // 
            this.tbBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBlue.BackColor = System.Drawing.Color.Blue;
            this.tbBlue.LargeChange = 20;
            this.tbBlue.Location = new System.Drawing.Point(436, 12);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(183, 45);
            this.tbBlue.TabIndex = 16;
            this.tbBlue.TickFrequency = 10;
            this.tbBlue.Value = 255;
            this.tbBlue.ValueChanged += new System.EventHandler(this.tbBlue_ValueChanged);
            // 
            // tbGreen
            // 
            this.tbGreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGreen.BackColor = System.Drawing.Color.Green;
            this.tbGreen.LargeChange = 20;
            this.tbGreen.Location = new System.Drawing.Point(224, 12);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(183, 45);
            this.tbGreen.TabIndex = 17;
            this.tbGreen.TickFrequency = 10;
            this.tbGreen.Value = 128;
            this.tbGreen.ValueChanged += new System.EventHandler(this.tbGreen_ValueChanged);
            // 
            // tbMagenta
            // 
            this.tbMagenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMagenta.BackColor = System.Drawing.Color.Magenta;
            this.tbMagenta.LargeChange = 20;
            this.tbMagenta.Location = new System.Drawing.Point(224, 60);
            this.tbMagenta.Maximum = 255;
            this.tbMagenta.Name = "tbMagenta";
            this.tbMagenta.Size = new System.Drawing.Size(183, 45);
            this.tbMagenta.TabIndex = 20;
            this.tbMagenta.TickFrequency = 10;
            this.tbMagenta.ValueChanged += new System.EventHandler(this.tbMagenta_ValueChanged);
            // 
            // tbYellow
            // 
            this.tbYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbYellow.BackColor = System.Drawing.Color.Yellow;
            this.tbYellow.LargeChange = 20;
            this.tbYellow.Location = new System.Drawing.Point(436, 60);
            this.tbYellow.Maximum = 255;
            this.tbYellow.Name = "tbYellow";
            this.tbYellow.Size = new System.Drawing.Size(183, 45);
            this.tbYellow.TabIndex = 19;
            this.tbYellow.TickFrequency = 10;
            this.tbYellow.ValueChanged += new System.EventHandler(this.tbYellow_ValueChanged);
            // 
            // tbCyan
            // 
            this.tbCyan.BackColor = System.Drawing.Color.Cyan;
            this.tbCyan.LargeChange = 20;
            this.tbCyan.Location = new System.Drawing.Point(12, 60);
            this.tbCyan.Maximum = 255;
            this.tbCyan.Name = "tbCyan";
            this.tbCyan.Size = new System.Drawing.Size(183, 45);
            this.tbCyan.TabIndex = 18;
            this.tbCyan.TickFrequency = 10;
            this.tbCyan.ValueChanged += new System.EventHandler(this.tbCyan_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 415);
            this.Controls.Add(this.tbMagenta);
            this.Controls.Add(this.tbYellow);
            this.Controls.Add(this.tbCyan);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnCyan);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnMagenta);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.rtbVýpis);
            this.Name = "Form1";
            this.Text = "Barvy OMG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMagenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCyan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbVýpis;
        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnCyan;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnMagenta;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.TrackBar tbMagenta;
        private System.Windows.Forms.TrackBar tbYellow;
        private System.Windows.Forms.TrackBar tbCyan;
    }
}

