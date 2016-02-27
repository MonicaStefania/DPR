namespace PublicTransportationApp
{
    partial class addForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trainRadioButton = new System.Windows.Forms.RadioButton();
            this.busRadioButton = new System.Windows.Forms.RadioButton();
            this.tramRadiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextbox = new System.Windows.Forms.TextBox();
            this.hourTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.delayTextbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tramRadiobutton);
            this.groupBox1.Controls.Add(this.busRadioButton);
            this.groupBox1.Controls.Add(this.trainRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select transport";
            // 
            // trainRadioButton
            // 
            this.trainRadioButton.AutoSize = true;
            this.trainRadioButton.Location = new System.Drawing.Point(20, 59);
            this.trainRadioButton.Name = "trainRadioButton";
            this.trainRadioButton.Size = new System.Drawing.Size(49, 17);
            this.trainRadioButton.TabIndex = 0;
            this.trainRadioButton.TabStop = true;
            this.trainRadioButton.Text = "Train";
            this.trainRadioButton.UseVisualStyleBackColor = true;
            // 
            // busRadioButton
            // 
            this.busRadioButton.AutoSize = true;
            this.busRadioButton.Location = new System.Drawing.Point(107, 59);
            this.busRadioButton.Name = "busRadioButton";
            this.busRadioButton.Size = new System.Drawing.Size(43, 17);
            this.busRadioButton.TabIndex = 1;
            this.busRadioButton.TabStop = true;
            this.busRadioButton.Text = "Bus";
            this.busRadioButton.UseVisualStyleBackColor = true;
            // 
            // tramRadiobutton
            // 
            this.tramRadiobutton.AutoSize = true;
            this.tramRadiobutton.Location = new System.Drawing.Point(186, 59);
            this.tramRadiobutton.Name = "tramRadiobutton";
            this.tramRadiobutton.Size = new System.Drawing.Size(49, 17);
            this.tramRadiobutton.TabIndex = 2;
            this.tramRadiobutton.TabStop = true;
            this.tramRadiobutton.Text = "Tram";
            this.tramRadiobutton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.delayTextbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.minTextbox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.hourTextbox);
            this.groupBox2.Controls.Add(this.toTextbox);
            this.groupBox2.Controls.Add(this.fromTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FROM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIME:";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(64, 25);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(86, 20);
            this.fromTextBox.TabIndex = 3;
            // 
            // toTextbox
            // 
            this.toTextbox.Location = new System.Drawing.Point(64, 51);
            this.toTextbox.Name = "toTextbox";
            this.toTextbox.Size = new System.Drawing.Size(86, 20);
            this.toTextbox.TabIndex = 4;
            // 
            // hourTextbox
            // 
            this.hourTextbox.Location = new System.Drawing.Point(60, 81);
            this.hourTextbox.Name = "hourTextbox";
            this.hourTextbox.Size = new System.Drawing.Size(27, 20);
            this.hourTextbox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "h";
            // 
            // minTextbox
            // 
            this.minTextbox.Location = new System.Drawing.Point(106, 81);
            this.minTextbox.Name = "minTextbox";
            this.minTextbox.Size = new System.Drawing.Size(27, 20);
            this.minTextbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "min";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::PublicTransportationApp.Properties.Resources.Iconsmind_Outline_Tram;
            this.pictureBox3.Location = new System.Drawing.Point(186, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 34);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::PublicTransportationApp.Properties.Resources.Graphicloads_Transport_Bus_2;
            this.pictureBox2.Location = new System.Drawing.Point(107, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 34);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PublicTransportationApp.Properties.Resources.Elegantthemes_Beautiful_Flat_One_Color_Train;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Delay:";
            // 
            // delayTextbox
            // 
            this.delayTextbox.Location = new System.Drawing.Point(208, 25);
            this.delayTextbox.Name = "delayTextbox";
            this.delayTextbox.Size = new System.Drawing.Size(27, 20);
            this.delayTextbox.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Image = global::PublicTransportationApp.Properties.Resources.Custom_Icon_Design_Mini_Accept;
            this.button3.Location = new System.Drawing.Point(186, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 36);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addForm";
            this.Text = "Add Transport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tramRadiobutton;
        private System.Windows.Forms.RadioButton busRadioButton;
        private System.Windows.Forms.RadioButton trainRadioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox minTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hourTextbox;
        private System.Windows.Forms.TextBox toTextbox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delayTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}