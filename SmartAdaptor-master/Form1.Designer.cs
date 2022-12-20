namespace ArduinoProject
{
    partial class Arduino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arduino));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbSerialPort = new System.Windows.Forms.ComboBox();
            this.btnON = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.lblBatteryName = new System.Windows.Forms.Label();
            this.lblBatteryStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtChargeStatus = new System.Windows.Forms.TextBox();
            this.txtLineStatus = new System.Windows.Forms.TextBox();
            this.txtChargeON = new System.Windows.Forms.TextBox();
            this.txtChargeOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.RichTextBox();
            this.bt5 = new System.Windows.Forms.RichTextBox();
            this.bt4 = new System.Windows.Forms.RichTextBox();
            this.bt3 = new System.Windows.Forms.RichTextBox();
            this.bt2 = new System.Windows.Forms.RichTextBox();
            this.battbox = new System.Windows.Forms.GroupBox();
            this.petir = new System.Windows.Forms.PictureBox();
            this.txtBatere = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtFullLifetime = new System.Windows.Forms.TextBox();
            this.txtLifeRemaining = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.battbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petir)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSerialPort
            // 
            this.cmbSerialPort.FormattingEnabled = true;
            this.cmbSerialPort.Location = new System.Drawing.Point(11, 45);
            this.cmbSerialPort.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSerialPort.Name = "cmbSerialPort";
            this.cmbSerialPort.Size = new System.Drawing.Size(237, 21);
            this.cmbSerialPort.TabIndex = 0;
            this.cmbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cmbSerialPort_SelectedIndexChanged);
            // 
            // btnON
            // 
            this.btnON.ForeColor = System.Drawing.Color.Black;
            this.btnON.Location = new System.Drawing.Point(11, 71);
            this.btnON.Margin = new System.Windows.Forms.Padding(2);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(111, 31);
            this.btnON.TabIndex = 1;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnOff
            // 
            this.btnOff.ForeColor = System.Drawing.Color.Black;
            this.btnOff.Location = new System.Drawing.Point(138, 71);
            this.btnOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(111, 31);
            this.btnOff.TabIndex = 2;
            this.btnOff.Text = "Off";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // lblBatteryName
            // 
            this.lblBatteryName.AutoSize = true;
            this.lblBatteryName.Location = new System.Drawing.Point(276, 17);
            this.lblBatteryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatteryName.Name = "lblBatteryName";
            this.lblBatteryName.Size = new System.Drawing.Size(35, 13);
            this.lblBatteryName.TabIndex = 4;
            this.lblBatteryName.Text = "label1";
            // 
            // lblBatteryStatus
            // 
            this.lblBatteryStatus.AutoSize = true;
            this.lblBatteryStatus.Location = new System.Drawing.Point(273, 119);
            this.lblBatteryStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBatteryStatus.Name = "lblBatteryStatus";
            this.lblBatteryStatus.Size = new System.Drawing.Size(35, 13);
            this.lblBatteryStatus.TabIndex = 5;
            this.lblBatteryStatus.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtChargeStatus
            // 
            this.txtChargeStatus.Location = new System.Drawing.Point(391, 154);
            this.txtChargeStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtChargeStatus.Name = "txtChargeStatus";
            this.txtChargeStatus.Size = new System.Drawing.Size(126, 20);
            this.txtChargeStatus.TabIndex = 6;
            // 
            // txtLineStatus
            // 
            this.txtLineStatus.Location = new System.Drawing.Point(391, 189);
            this.txtLineStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtLineStatus.Name = "txtLineStatus";
            this.txtLineStatus.Size = new System.Drawing.Size(126, 20);
            this.txtLineStatus.TabIndex = 10;
            // 
            // txtChargeON
            // 
            this.txtChargeON.Location = new System.Drawing.Point(33, 182);
            this.txtChargeON.Margin = new System.Windows.Forms.Padding(2);
            this.txtChargeON.Name = "txtChargeON";
            this.txtChargeON.Size = new System.Drawing.Size(68, 20);
            this.txtChargeON.TabIndex = 11;
            this.txtChargeON.Text = "50";
            this.txtChargeON.TextChanged += new System.EventHandler(this.txtChargeON_TextChanged);
            // 
            // txtChargeOff
            // 
            this.txtChargeOff.Location = new System.Drawing.Point(160, 182);
            this.txtChargeOff.Margin = new System.Windows.Forms.Padding(2);
            this.txtChargeOff.Name = "txtChargeOff";
            this.txtChargeOff.Size = new System.Drawing.Size(68, 20);
            this.txtChargeOff.TabIndex = 12;
            this.txtChargeOff.Text = "55";
            this.txtChargeOff.TextChanged += new System.EventHandler(this.txtChargeOff_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Charging ON Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Charging OFF Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Charging Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Power Status";
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.Green;
            this.bt1.Location = new System.Drawing.Point(9, 14);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(42, 63);
            this.bt1.TabIndex = 21;
            this.bt1.Text = "";
            this.bt1.Visible = false;
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.Green;
            this.bt5.Location = new System.Drawing.Point(186, 14);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(42, 63);
            this.bt5.TabIndex = 22;
            this.bt5.Text = "";
            this.bt5.Visible = false;
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.Green;
            this.bt4.Location = new System.Drawing.Point(141, 14);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(42, 63);
            this.bt4.TabIndex = 23;
            this.bt4.Text = "";
            this.bt4.Visible = false;
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.Green;
            this.bt3.Location = new System.Drawing.Point(97, 14);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(42, 63);
            this.bt3.TabIndex = 24;
            this.bt3.Text = "";
            this.bt3.Visible = false;
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.Green;
            this.bt2.Location = new System.Drawing.Point(53, 14);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(42, 63);
            this.bt2.TabIndex = 25;
            this.bt2.Text = "";
            this.bt2.Visible = false;
            // 
            // battbox
            // 
            this.battbox.Controls.Add(this.petir);
            this.battbox.Controls.Add(this.bt5);
            this.battbox.Controls.Add(this.bt2);
            this.battbox.Controls.Add(this.bt1);
            this.battbox.Controls.Add(this.bt3);
            this.battbox.Controls.Add(this.bt4);
            this.battbox.Location = new System.Drawing.Point(276, 28);
            this.battbox.Name = "battbox";
            this.battbox.Size = new System.Drawing.Size(239, 85);
            this.battbox.TabIndex = 26;
            this.battbox.TabStop = false;
            // 
            // petir
            // 
            this.petir.BackColor = System.Drawing.Color.Green;
            this.petir.Image = ((System.Drawing.Image)(resources.GetObject("petir.Image")));
            this.petir.Location = new System.Drawing.Point(102, 30);
            this.petir.Name = "petir";
            this.petir.Size = new System.Drawing.Size(32, 32);
            this.petir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.petir.TabIndex = 29;
            this.petir.TabStop = false;
            // 
            // txtBatere
            // 
            this.txtBatere.AutoSize = true;
            this.txtBatere.BackColor = System.Drawing.Color.SlateGray;
            this.txtBatere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBatere.Location = new System.Drawing.Point(518, 64);
            this.txtBatere.Name = "txtBatere";
            this.txtBatere.Size = new System.Drawing.Size(20, 15);
            this.txtBatere.TabIndex = 27;
            this.txtBatere.Text = "bs";
            this.txtBatere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtBatere.Click += new System.EventHandler(this.txtBatere_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SlateGray;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(515, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.Size = new System.Drawing.Size(37, 41);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            // 
            // txtFullLifetime
            // 
            this.txtFullLifetime.Location = new System.Drawing.Point(391, 278);
            this.txtFullLifetime.Margin = new System.Windows.Forms.Padding(2);
            this.txtFullLifetime.Name = "txtFullLifetime";
            this.txtFullLifetime.Size = new System.Drawing.Size(126, 20);
            this.txtFullLifetime.TabIndex = 7;
            this.txtFullLifetime.Visible = false;
            // 
            // txtLifeRemaining
            // 
            this.txtLifeRemaining.Location = new System.Drawing.Point(391, 243);
            this.txtLifeRemaining.Margin = new System.Windows.Forms.Padding(2);
            this.txtLifeRemaining.Name = "txtLifeRemaining";
            this.txtLifeRemaining.Size = new System.Drawing.Size(126, 20);
            this.txtLifeRemaining.TabIndex = 9;
            this.txtLifeRemaining.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Battery Full Lifetime";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Battery Life Remaining";
            this.label5.Visible = false;
            // 
            // Arduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(573, 225);
            this.Controls.Add(this.txtBatere);
            this.Controls.Add(this.battbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChargeOff);
            this.Controls.Add(this.txtChargeON);
            this.Controls.Add(this.txtLineStatus);
            this.Controls.Add(this.txtLifeRemaining);
            this.Controls.Add(this.txtFullLifetime);
            this.Controls.Add(this.txtChargeStatus);
            this.Controls.Add(this.lblBatteryStatus);
            this.Controls.Add(this.lblBatteryName);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.cmbSerialPort);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Arduino";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.battbox.ResumeLayout(false);
            this.battbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbSerialPort;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Label lblBatteryName;
        private System.Windows.Forms.Label lblBatteryStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtChargeStatus;
        private System.Windows.Forms.TextBox txtLineStatus;
        private System.Windows.Forms.TextBox txtChargeON;
        private System.Windows.Forms.TextBox txtChargeOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox bt1;
        private System.Windows.Forms.RichTextBox bt5;
        private System.Windows.Forms.RichTextBox bt4;
        private System.Windows.Forms.RichTextBox bt3;
        private System.Windows.Forms.RichTextBox bt2;
        private System.Windows.Forms.GroupBox battbox;
        private System.Windows.Forms.Label txtBatere;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtFullLifetime;
        private System.Windows.Forms.TextBox txtLifeRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox petir;
    }
}

