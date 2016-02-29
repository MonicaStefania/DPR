namespace PublicTransportationApp
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtrainDelay = new System.Windows.Forms.ListBox();
            this.lbtrainTime = new System.Windows.Forms.ListBox();
            this.lbtrainDestination = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbbusDelay = new System.Windows.Forms.ListBox();
            this.lbbusTime = new System.Windows.Forms.ListBox();
            this.lbbusDestination = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbtramDelay = new System.Windows.Forms.ListBox();
            this.lbtramTime = new System.Windows.Forms.ListBox();
            this.lbtramDestination = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddDelay = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.delayTextbox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.cbTram = new System.Windows.Forms.CheckBox();
            this.cbBus = new System.Windows.Forms.CheckBox();
            this.cbTrain = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.BtnStopTimer = new System.Windows.Forms.Button();
            this.lblInfoTimer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbtrainDelay);
            this.groupBox1.Controls.Add(this.lbtrainTime);
            this.groupBox1.Controls.Add(this.lbtrainDestination);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRAINS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delay:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destination:";
            // 
            // lbtrainDelay
            // 
            this.lbtrainDelay.FormattingEnabled = true;
            this.lbtrainDelay.Location = new System.Drawing.Point(293, 38);
            this.lbtrainDelay.Name = "lbtrainDelay";
            this.lbtrainDelay.Size = new System.Drawing.Size(34, 95);
            this.lbtrainDelay.TabIndex = 2;
            // 
            // lbtrainTime
            // 
            this.lbtrainTime.FormattingEnabled = true;
            this.lbtrainTime.Location = new System.Drawing.Point(207, 38);
            this.lbtrainTime.Name = "lbtrainTime";
            this.lbtrainTime.Size = new System.Drawing.Size(48, 95);
            this.lbtrainTime.TabIndex = 1;
            // 
            // lbtrainDestination
            // 
            this.lbtrainDestination.FormattingEnabled = true;
            this.lbtrainDestination.Location = new System.Drawing.Point(16, 38);
            this.lbtrainDestination.Name = "lbtrainDestination";
            this.lbtrainDestination.Size = new System.Drawing.Size(165, 95);
            this.lbtrainDestination.TabIndex = 0;
            this.lbtrainDestination.SelectedIndexChanged += new System.EventHandler(this.trainDestinationlbox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbbusDelay);
            this.groupBox2.Controls.Add(this.lbbusTime);
            this.groupBox2.Controls.Add(this.lbbusDestination);
            this.groupBox2.Location = new System.Drawing.Point(32, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 150);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BUSES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Delay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Destination:";
            // 
            // lbbusDelay
            // 
            this.lbbusDelay.FormattingEnabled = true;
            this.lbbusDelay.Location = new System.Drawing.Point(293, 38);
            this.lbbusDelay.Name = "lbbusDelay";
            this.lbbusDelay.Size = new System.Drawing.Size(34, 95);
            this.lbbusDelay.TabIndex = 2;
            // 
            // lbbusTime
            // 
            this.lbbusTime.FormattingEnabled = true;
            this.lbbusTime.Location = new System.Drawing.Point(207, 38);
            this.lbbusTime.Name = "lbbusTime";
            this.lbbusTime.Size = new System.Drawing.Size(48, 95);
            this.lbbusTime.TabIndex = 1;
            // 
            // lbbusDestination
            // 
            this.lbbusDestination.FormattingEnabled = true;
            this.lbbusDestination.Location = new System.Drawing.Point(16, 38);
            this.lbbusDestination.Name = "lbbusDestination";
            this.lbbusDestination.Size = new System.Drawing.Size(165, 95);
            this.lbbusDestination.TabIndex = 0;
            this.lbbusDestination.SelectedIndexChanged += new System.EventHandler(this.busDestinationlbox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lbtramDelay);
            this.groupBox3.Controls.Add(this.lbtramTime);
            this.groupBox3.Controls.Add(this.lbtramDestination);
            this.groupBox3.Location = new System.Drawing.Point(32, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 150);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TRAM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Delay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Destination:";
            // 
            // lbtramDelay
            // 
            this.lbtramDelay.FormattingEnabled = true;
            this.lbtramDelay.Location = new System.Drawing.Point(293, 32);
            this.lbtramDelay.Name = "lbtramDelay";
            this.lbtramDelay.Size = new System.Drawing.Size(34, 95);
            this.lbtramDelay.TabIndex = 2;
            // 
            // lbtramTime
            // 
            this.lbtramTime.FormattingEnabled = true;
            this.lbtramTime.Location = new System.Drawing.Point(207, 32);
            this.lbtramTime.Name = "lbtramTime";
            this.lbtramTime.Size = new System.Drawing.Size(48, 95);
            this.lbtramTime.TabIndex = 1;
            // 
            // lbtramDestination
            // 
            this.lbtramDestination.FormattingEnabled = true;
            this.lbtramDestination.Location = new System.Drawing.Point(16, 38);
            this.lbtramDestination.Name = "lbtramDestination";
            this.lbtramDestination.Size = new System.Drawing.Size(165, 95);
            this.lbtramDestination.TabIndex = 0;
            this.lbtramDestination.SelectedIndexChanged += new System.EventHandler(this.tramDestinationlbox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Click here to add trains, ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Location = new System.Drawing.Point(549, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add transport";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "bus or tram.";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PublicTransportationApp.Properties.Resources.Custom_Icon_Design_Mono_General_1_Add;
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddDelay);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.delayTextbox);
            this.groupBox5.Location = new System.Drawing.Point(549, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 72);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add delay";
            // 
            // btnAddDelay
            // 
            this.btnAddDelay.Image = global::PublicTransportationApp.Properties.Resources.Custom_Icon_Design_Mini_Accept;
            this.btnAddDelay.Location = new System.Drawing.Point(116, 19);
            this.btnAddDelay.Name = "btnAddDelay";
            this.btnAddDelay.Size = new System.Drawing.Size(49, 36);
            this.btnAddDelay.TabIndex = 9;
            this.btnAddDelay.UseVisualStyleBackColor = true;
            this.btnAddDelay.Click += new System.EventHandler(this.btnAddDelay_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "min";
            // 
            // delayTextbox
            // 
            this.delayTextbox.Location = new System.Drawing.Point(15, 19);
            this.delayTextbox.Name = "delayTextbox";
            this.delayTextbox.Size = new System.Drawing.Size(43, 20);
            this.delayTextbox.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btnRemove);
            this.groupBox6.Location = new System.Drawing.Point(549, 125);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 72);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remove transport";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "to remove transport.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Select and click here";
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::PublicTransportationApp.Properties.Resources.Custom_Icon_Design_Mono_General_1_Delete;
            this.btnRemove.Location = new System.Drawing.Point(9, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(49, 42);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::PublicTransportationApp.Properties.Resources.Iconsmind_Outline_Tram;
            this.pictureBox3.Location = new System.Drawing.Point(18, 99);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::PublicTransportationApp.Properties.Resources.Graphicloads_Transport_Bus_2;
            this.pictureBox2.Location = new System.Drawing.Point(18, 59);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PublicTransportationApp.Properties.Resources.Elegantthemes_Beautiful_Flat_One_Color_Train;
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnSubscribe);
            this.groupBox7.Controls.Add(this.cbTram);
            this.groupBox7.Controls.Add(this.cbBus);
            this.groupBox7.Controls.Add(this.cbTrain);
            this.groupBox7.Controls.Add(this.pictureBox1);
            this.groupBox7.Controls.Add(this.pictureBox3);
            this.groupBox7.Controls.Add(this.pictureBox2);
            this.groupBox7.Location = new System.Drawing.Point(549, 322);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 149);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Show:";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(125, 70);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(75, 23);
            this.btnSubscribe.TabIndex = 4;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // cbTram
            // 
            this.cbTram.AutoSize = true;
            this.cbTram.Location = new System.Drawing.Point(67, 116);
            this.cbTram.Name = "cbTram";
            this.cbTram.Size = new System.Drawing.Size(50, 17);
            this.cbTram.TabIndex = 17;
            this.cbTram.Text = "Tram";
            this.cbTram.UseVisualStyleBackColor = true;
            // 
            // cbBus
            // 
            this.cbBus.AutoSize = true;
            this.cbBus.Location = new System.Drawing.Point(64, 76);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(44, 17);
            this.cbBus.TabIndex = 16;
            this.cbBus.Text = "Bus";
            this.cbBus.UseVisualStyleBackColor = true;
            // 
            // cbTrain
            // 
            this.cbTrain.AutoSize = true;
            this.cbTrain.Location = new System.Drawing.Point(64, 31);
            this.cbTrain.Name = "cbTrain";
            this.cbTrain.Size = new System.Drawing.Size(50, 17);
            this.cbTrain.TabIndex = 15;
            this.cbTrain.Text = "Train";
            this.cbTrain.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(781, 47);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartTimer.TabIndex = 16;
            this.btnStartTimer.Text = "Start timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // BtnStopTimer
            // 
            this.BtnStopTimer.Location = new System.Drawing.Point(781, 149);
            this.BtnStopTimer.Name = "BtnStopTimer";
            this.BtnStopTimer.Size = new System.Drawing.Size(75, 23);
            this.BtnStopTimer.TabIndex = 17;
            this.BtnStopTimer.Text = "Stop timer";
            this.BtnStopTimer.UseVisualStyleBackColor = true;
            this.BtnStopTimer.Click += new System.EventHandler(this.BtnStopTimer_Click);
            // 
            // lblInfoTimer
            // 
            this.lblInfoTimer.AutoSize = true;
            this.lblInfoTimer.Location = new System.Drawing.Point(768, 94);
            this.lblInfoTimer.Name = "lblInfoTimer";
            this.lblInfoTimer.Size = new System.Drawing.Size(0, 13);
            this.lblInfoTimer.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 500);
            this.Controls.Add(this.lblInfoTimer);
            this.Controls.Add(this.BtnStopTimer);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "PublicTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbtrainDelay;
        private System.Windows.Forms.ListBox lbtrainTime;
        private System.Windows.Forms.ListBox lbtrainDestination;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbbusDelay;
        private System.Windows.Forms.ListBox lbbusTime;
        private System.Windows.Forms.ListBox lbbusDestination;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbtramDelay;
        private System.Windows.Forms.ListBox lbtramTime;
        private System.Windows.Forms.ListBox lbtramDestination;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox delayTextbox;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddDelay;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.CheckBox cbTram;
        private System.Windows.Forms.CheckBox cbBus;
        private System.Windows.Forms.CheckBox cbTrain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button BtnStopTimer;
        private System.Windows.Forms.Label lblInfoTimer;
    }
}

