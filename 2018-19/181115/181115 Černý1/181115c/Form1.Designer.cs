namespace _181115c
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
            this.btnNacti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudByteDM = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trbByte = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudByteHM = new System.Windows.Forms.NumericUpDown();
            this.nudBytePočet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trbInt16 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInt16HM = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudInt16Počet = new System.Windows.Forms.NumericUpDown();
            this.nudInt16DM = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.trbInt32 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudInt32Počet = new System.Windows.Forms.NumericUpDown();
            this.nudInt32HM = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudInt32DM = new System.Windows.Forms.NumericUpDown();
            this.btnGeneruj = new System.Windows.Forms.Button();
            this.lbVýpis = new System.Windows.Forms.Label();
            this.btnVypis = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trbDouble = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudDouble = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudByteDM)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudByteHM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytePočet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16HM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16Počet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16DM)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32Počet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32HM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32DM)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDouble)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNacti
            // 
            this.btnNacti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNacti.Location = new System.Drawing.Point(672, 12);
            this.btnNacti.Name = "btnNacti";
            this.btnNacti.Size = new System.Drawing.Size(75, 23);
            this.btnNacti.TabIndex = 0;
            this.btnNacti.Text = "Načti";
            this.btnNacti.UseVisualStyleBackColor = true;
            this.btnNacti.Click += new System.EventHandler(this.btnNacti_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dolní mez <Byte>";
            // 
            // nudByteDM
            // 
            this.nudByteDM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudByteDM.Location = new System.Drawing.Point(106, 34);
            this.nudByteDM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudByteDM.Name = "nudByteDM";
            this.nudByteDM.Size = new System.Drawing.Size(44, 20);
            this.nudByteDM.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trbByte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudByteHM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudByteDM);
            this.groupBox1.Controls.Add(this.nudBytePočet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 348);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Byte";
            // 
            // trbByte
            // 
            this.trbByte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbByte.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trbByte.Location = new System.Drawing.Point(6, 80);
            this.trbByte.Name = "trbByte";
            this.trbByte.Size = new System.Drawing.Size(144, 262);
            this.trbByte.TabIndex = 6;
            this.trbByte.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horní mez <Byte>";
            // 
            // nudByteHM
            // 
            this.nudByteHM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudByteHM.Location = new System.Drawing.Point(106, 54);
            this.nudByteHM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudByteHM.Name = "nudByteHM";
            this.nudByteHM.Size = new System.Drawing.Size(44, 20);
            this.nudByteHM.TabIndex = 4;
            // 
            // nudBytePočet
            // 
            this.nudBytePočet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBytePočet.Location = new System.Drawing.Point(106, 14);
            this.nudBytePočet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBytePočet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBytePočet.Name = "nudBytePočet";
            this.nudBytePočet.Size = new System.Drawing.Size(44, 20);
            this.nudBytePočet.TabIndex = 5;
            this.nudBytePočet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Počet <5,20>";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.trbInt16);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudInt16HM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudInt16Počet);
            this.groupBox2.Controls.Add(this.nudInt16DM);
            this.groupBox2.Location = new System.Drawing.Point(166, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 348);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Int16";
            // 
            // trbInt16
            // 
            this.trbInt16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbInt16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trbInt16.Location = new System.Drawing.Point(6, 80);
            this.trbInt16.Name = "trbInt16";
            this.trbInt16.Size = new System.Drawing.Size(144, 262);
            this.trbInt16.TabIndex = 8;
            this.trbInt16.Text = "";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horní mez <Int16>";
            // 
            // nudInt16HM
            // 
            this.nudInt16HM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt16HM.Location = new System.Drawing.Point(110, 54);
            this.nudInt16HM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInt16HM.Name = "nudInt16HM";
            this.nudInt16HM.Size = new System.Drawing.Size(44, 20);
            this.nudInt16HM.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Počet <5,20>";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dolní mez <Int16>";
            // 
            // nudInt16Počet
            // 
            this.nudInt16Počet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt16Počet.Location = new System.Drawing.Point(110, 14);
            this.nudInt16Počet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudInt16Počet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudInt16Počet.Name = "nudInt16Počet";
            this.nudInt16Počet.Size = new System.Drawing.Size(44, 20);
            this.nudInt16Počet.TabIndex = 7;
            this.nudInt16Počet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudInt16DM
            // 
            this.nudInt16DM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt16DM.Location = new System.Drawing.Point(110, 34);
            this.nudInt16DM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInt16DM.Name = "nudInt16DM";
            this.nudInt16DM.Size = new System.Drawing.Size(44, 20);
            this.nudInt16DM.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.trbInt32);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nudInt32Počet);
            this.groupBox3.Controls.Add(this.nudInt32HM);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudInt32DM);
            this.groupBox3.Location = new System.Drawing.Point(329, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 348);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Int32";
            // 
            // trbInt32
            // 
            this.trbInt32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbInt32.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trbInt32.Location = new System.Drawing.Point(6, 80);
            this.trbInt32.Name = "trbInt32";
            this.trbInt32.Size = new System.Drawing.Size(143, 262);
            this.trbInt32.TabIndex = 10;
            this.trbInt32.Text = "";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Počet <5,20>";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Horní mez <Int32>";
            // 
            // nudInt32Počet
            // 
            this.nudInt32Počet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt32Počet.Location = new System.Drawing.Point(109, 16);
            this.nudInt32Počet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudInt32Počet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudInt32Počet.Name = "nudInt32Počet";
            this.nudInt32Počet.Size = new System.Drawing.Size(44, 20);
            this.nudInt32Počet.TabIndex = 9;
            this.nudInt32Počet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudInt32HM
            // 
            this.nudInt32HM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt32HM.Location = new System.Drawing.Point(109, 56);
            this.nudInt32HM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInt32HM.Name = "nudInt32HM";
            this.nudInt32HM.Size = new System.Drawing.Size(44, 20);
            this.nudInt32HM.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dolní mez <Int32>";
            // 
            // nudInt32DM
            // 
            this.nudInt32DM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudInt32DM.Location = new System.Drawing.Point(109, 36);
            this.nudInt32DM.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudInt32DM.Name = "nudInt32DM";
            this.nudInt32DM.Size = new System.Drawing.Size(44, 20);
            this.nudInt32DM.TabIndex = 2;
            // 
            // btnGeneruj
            // 
            this.btnGeneruj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneruj.Location = new System.Drawing.Point(672, 37);
            this.btnGeneruj.Name = "btnGeneruj";
            this.btnGeneruj.Size = new System.Drawing.Size(75, 23);
            this.btnGeneruj.TabIndex = 6;
            this.btnGeneruj.Text = "Generuj";
            this.btnGeneruj.UseVisualStyleBackColor = true;
            this.btnGeneruj.Click += new System.EventHandler(this.btnGeneruj_Click);
            // 
            // lbVýpis
            // 
            this.lbVýpis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVýpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.lbVýpis, 4);
            this.lbVýpis.Location = new System.Drawing.Point(3, 354);
            this.lbVýpis.Name = "lbVýpis";
            this.lbVýpis.Size = new System.Drawing.Size(648, 30);
            this.lbVýpis.TabIndex = 7;
            this.lbVýpis.Text = "Info";
            this.lbVýpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVypis
            // 
            this.btnVypis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVypis.Location = new System.Drawing.Point(672, 62);
            this.btnVypis.Name = "btnVypis";
            this.btnVypis.Size = new System.Drawing.Size(75, 23);
            this.btnVypis.TabIndex = 8;
            this.btnVypis.Text = "Vypiš";
            this.btnVypis.UseVisualStyleBackColor = true;
            this.btnVypis.Click += new System.EventHandler(this.btnVypis_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.trbDouble);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nudDouble);
            this.groupBox4.Location = new System.Drawing.Point(492, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 348);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Double";
            // 
            // trbDouble
            // 
            this.trbDouble.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trbDouble.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trbDouble.Location = new System.Drawing.Point(6, 42);
            this.trbDouble.Name = "trbDouble";
            this.trbDouble.Size = new System.Drawing.Size(145, 300);
            this.trbDouble.TabIndex = 10;
            this.trbDouble.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Počet <5,20>";
            // 
            // nudDouble
            // 
            this.nudDouble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDouble.Location = new System.Drawing.Point(111, 16);
            this.nudDouble.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDouble.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDouble.Name = "nudDouble";
            this.nudDouble.Size = new System.Drawing.Size(44, 20);
            this.nudDouble.TabIndex = 9;
            this.nudDouble.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbVýpis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(654, 384);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnVypis);
            this.Controls.Add(this.btnGeneruj);
            this.Controls.Add(this.btnNacti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudByteDM)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudByteHM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBytePočet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16HM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16Počet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt16DM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32Počet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32HM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInt32DM)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDouble)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNacti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudByteDM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox trbByte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudByteHM;
        private System.Windows.Forms.NumericUpDown nudBytePočet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox trbInt16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInt16HM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudInt16Počet;
        private System.Windows.Forms.NumericUpDown nudInt16DM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox trbInt32;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudInt32Počet;
        private System.Windows.Forms.NumericUpDown nudInt32HM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudInt32DM;
        private System.Windows.Forms.Button btnGeneruj;
        private System.Windows.Forms.Label lbVýpis;
        private System.Windows.Forms.Button btnVypis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox trbDouble;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudDouble;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

