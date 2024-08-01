namespace wsu_software
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateWSB = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPeopleCount = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvActivityMonitor = new System.Windows.Forms.DataGridView();
            this.btnStrtMntr = new System.Windows.Forms.Button();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabTrack = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnValidate = new System.Windows.Forms.Button();
            this.radioEmergency = new System.Windows.Forms.RadioButton();
            this.radioSSD = new System.Windows.Forms.RadioButton();
            this.radioRescueStation = new System.Windows.Forms.RadioButton();
            this.radioVerificationMuster = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.tabPeopleCount = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.lboxPeopleList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRFID = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dudSense = new System.Windows.Forms.DomainUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dudPower = new System.Windows.Forms.DomainUpDown();
            this.lbxRoomCount = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabTrack.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            this.tabPeopleCount.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGenerateWSB);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Location = new System.Drawing.Point(140, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 84);
            this.panel1.TabIndex = 5;
            // 
            // btnGenerateWSB
            // 
            this.btnGenerateWSB.Location = new System.Drawing.Point(181, 25);
            this.btnGenerateWSB.Name = "btnGenerateWSB";
            this.btnGenerateWSB.Size = new System.Drawing.Size(114, 35);
            this.btnGenerateWSB.TabIndex = 6;
            this.btnGenerateWSB.Text = "Generate WSB";
            this.btnGenerateWSB.UseVisualStyleBackColor = true;
            this.btnGenerateWSB.Click += new System.EventHandler(this.btnGenerateWSB_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(20, 25);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 35);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Initial Phase:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tracking Phase :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPeopleCount);
            this.panel3.Controls.Add(this.btnTrack);
            this.panel3.Location = new System.Drawing.Point(140, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 81);
            this.panel3.TabIndex = 10;
            // 
            // btnPeopleCount
            // 
            this.btnPeopleCount.Location = new System.Drawing.Point(181, 25);
            this.btnPeopleCount.Name = "btnPeopleCount";
            this.btnPeopleCount.Size = new System.Drawing.Size(105, 33);
            this.btnPeopleCount.TabIndex = 4;
            this.btnPeopleCount.Text = "People Count";
            this.btnPeopleCount.UseVisualStyleBackColor = true;
            this.btnPeopleCount.Click += new System.EventHandler(this.btnPeopleCount_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Location = new System.Drawing.Point(20, 25);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(107, 33);
            this.btnTrack.TabIndex = 3;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.dgvActivityMonitor);
            this.panel4.Controls.Add(this.btnStrtMntr);
            this.panel4.Location = new System.Drawing.Point(157, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(549, 364);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Activity Monitor";
            // 
            // dgvActivityMonitor
            // 
            this.dgvActivityMonitor.Location = new System.Drawing.Point(3, 63);
            this.dgvActivityMonitor.Name = "dgvActivityMonitor";
            this.dgvActivityMonitor.Size = new System.Drawing.Size(543, 225);
            this.dgvActivityMonitor.TabIndex = 5;
            // 
            // btnStrtMntr
            // 
            this.btnStrtMntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrtMntr.Location = new System.Drawing.Point(200, 317);
            this.btnStrtMntr.Name = "btnStrtMntr";
            this.btnStrtMntr.Size = new System.Drawing.Size(140, 24);
            this.btnStrtMntr.TabIndex = 2;
            this.btnStrtMntr.Text = "Start Monitoring";
            this.btnStrtMntr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStrtMntr.UseVisualStyleBackColor = true;
            this.btnStrtMntr.Click += new System.EventHandler(this.btnStrtMntr_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabTrack);
            this.tab.Controls.Add(this.tabPeopleCount);
            this.tab.Location = new System.Drawing.Point(470, 118);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(795, 439);
            this.tab.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(787, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Activity Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabTrack
            // 
            this.tabTrack.Controls.Add(this.panel2);
            this.tabTrack.Controls.Add(this.label5);
            this.tabTrack.Controls.Add(this.dgvTrack);
            this.tabTrack.Location = new System.Drawing.Point(4, 22);
            this.tabTrack.Name = "tabTrack";
            this.tabTrack.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrack.Size = new System.Drawing.Size(787, 413);
            this.tabTrack.TabIndex = 1;
            this.tabTrack.Text = "Track";
            this.tabTrack.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnValidate);
            this.panel2.Controls.Add(this.radioEmergency);
            this.panel2.Controls.Add(this.radioSSD);
            this.panel2.Controls.Add(this.radioRescueStation);
            this.panel2.Controls.Add(this.radioVerificationMuster);
            this.panel2.Location = new System.Drawing.Point(25, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 35);
            this.panel2.TabIndex = 10;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(504, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 10;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // radioEmergency
            // 
            this.radioEmergency.AutoSize = true;
            this.radioEmergency.Location = new System.Drawing.Point(259, 9);
            this.radioEmergency.Name = "radioEmergency";
            this.radioEmergency.Size = new System.Drawing.Size(78, 17);
            this.radioEmergency.TabIndex = 8;
            this.radioEmergency.TabStop = true;
            this.radioEmergency.Text = "Emergency";
            this.radioEmergency.UseVisualStyleBackColor = true;
            // 
            // radioSSD
            // 
            this.radioSSD.AutoSize = true;
            this.radioSSD.Location = new System.Drawing.Point(354, 9);
            this.radioSSD.Name = "radioSSD";
            this.radioSSD.Size = new System.Drawing.Size(107, 17);
            this.radioSSD.TabIndex = 9;
            this.radioSSD.TabStop = true;
            this.radioSSD.Text = "Special Sea Duty";
            this.radioSSD.UseVisualStyleBackColor = true;
            this.radioSSD.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioRescueStation
            // 
            this.radioRescueStation.AutoSize = true;
            this.radioRescueStation.Location = new System.Drawing.Point(144, 9);
            this.radioRescueStation.Name = "radioRescueStation";
            this.radioRescueStation.Size = new System.Drawing.Size(98, 17);
            this.radioRescueStation.TabIndex = 7;
            this.radioRescueStation.TabStop = true;
            this.radioRescueStation.Text = "Rescue Station";
            this.radioRescueStation.UseVisualStyleBackColor = true;
            // 
            // radioVerificationMuster
            // 
            this.radioVerificationMuster.AutoSize = true;
            this.radioVerificationMuster.Location = new System.Drawing.Point(26, 9);
            this.radioVerificationMuster.Name = "radioVerificationMuster";
            this.radioVerificationMuster.Size = new System.Drawing.Size(112, 17);
            this.radioVerificationMuster.TabIndex = 6;
            this.radioVerificationMuster.TabStop = true;
            this.radioVerificationMuster.Text = "Verification Muster";
            this.radioVerificationMuster.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(347, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Track";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTrack
            // 
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Location = new System.Drawing.Point(25, 49);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.Size = new System.Drawing.Size(743, 273);
            this.dgvTrack.TabIndex = 0;
            // 
            // tabPeopleCount
            // 
            this.tabPeopleCount.Controls.Add(this.label10);
            this.tabPeopleCount.Controls.Add(this.lbxRoomCount);
            this.tabPeopleCount.Controls.Add(this.label6);
            this.tabPeopleCount.Controls.Add(this.lboxPeopleList);
            this.tabPeopleCount.Controls.Add(this.label4);
            this.tabPeopleCount.Location = new System.Drawing.Point(4, 22);
            this.tabPeopleCount.Name = "tabPeopleCount";
            this.tabPeopleCount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPeopleCount.Size = new System.Drawing.Size(787, 413);
            this.tabPeopleCount.TabIndex = 2;
            this.tabPeopleCount.Text = "People Count";
            this.tabPeopleCount.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Format: Name, Last seen location";
            // 
            // lboxPeopleList
            // 
            this.lboxPeopleList.FormattingEnabled = true;
            this.lboxPeopleList.Location = new System.Drawing.Point(29, 89);
            this.lboxPeopleList.Name = "lboxPeopleList";
            this.lboxPeopleList.Size = new System.Drawing.Size(327, 108);
            this.lboxPeopleList.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Missing people list :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 49);
            this.label7.TabIndex = 13;
            this.label7.Text = "We Sea You";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(92, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(173, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 15;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFID.Location = new System.Drawing.Point(32, 5);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(39, 17);
            this.lblRFID.TabIndex = 16;
            this.lblRFID.Text = "RFID";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.dudSense);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.dudPower);
            this.panel5.Controls.Add(this.lblRFID);
            this.panel5.Controls.Add(this.btnStop);
            this.panel5.Controls.Add(this.btnStart);
            this.panel5.Location = new System.Drawing.Point(997, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 81);
            this.panel5.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "RxSensitivityInDbm";
            // 
            // dudSense
            // 
            this.dudSense.Items.Add("-65.0");
            this.dudSense.Location = new System.Drawing.Point(173, 58);
            this.dudSense.Name = "dudSense";
            this.dudSense.Size = new System.Drawing.Size(75, 20);
            this.dudSense.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(100, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "PowerInDbm";
            // 
            // dudPower
            // 
            this.dudPower.Items.Add("23.0");
            this.dudPower.Location = new System.Drawing.Point(173, 34);
            this.dudPower.Name = "dudPower";
            this.dudPower.Size = new System.Drawing.Size(75, 20);
            this.dudPower.TabIndex = 0;
            // 
            // lbxRoomCount
            // 
            this.lbxRoomCount.FormattingEnabled = true;
            this.lbxRoomCount.Location = new System.Drawing.Point(427, 89);
            this.lbxRoomCount.Name = "lbxRoomCount";
            this.lbxRoomCount.Size = new System.Drawing.Size(319, 108);
            this.lbxRoomCount.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(424, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Per room personnel count:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 576);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabTrack.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            this.tabPeopleCount.ResumeLayout(false);
            this.tabPeopleCount.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateWSB;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPeopleCount;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnStrtMntr;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvActivityMonitor;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabTrack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.TabPage tabPeopleCount;
        private System.Windows.Forms.ListBox lboxPeopleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioEmergency;
        private System.Windows.Forms.RadioButton radioRescueStation;
        private System.Windows.Forms.RadioButton radioVerificationMuster;
        private System.Windows.Forms.RadioButton radioSSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DomainUpDown dudSense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DomainUpDown dudPower;
        private System.Windows.Forms.ListBox lbxRoomCount;
        private System.Windows.Forms.Label label10;
    }
}

