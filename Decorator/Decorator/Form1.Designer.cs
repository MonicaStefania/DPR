namespace Decorator
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
            this.rbWarrior = new System.Windows.Forms.RadioButton();
            this.rbMage = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.lbAddedOptions = new System.Windows.Forms.ListBox();
            this.lbAvailableOptions = new System.Windows.Forms.ListBox();
            this.tbAddedOptions = new System.Windows.Forms.Label();
            this.lblAvailableOptions = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbWarrior
            // 
            this.rbWarrior.AutoSize = true;
            this.rbWarrior.Location = new System.Drawing.Point(42, 57);
            this.rbWarrior.Name = "rbWarrior";
            this.rbWarrior.Size = new System.Drawing.Size(59, 17);
            this.rbWarrior.TabIndex = 0;
            this.rbWarrior.TabStop = true;
            this.rbWarrior.Text = "Warrior";
            this.rbWarrior.UseVisualStyleBackColor = true;
            this.rbWarrior.CheckedChanged += new System.EventHandler(this.rbWarrior_CheckedChanged);
            // 
            // rbMage
            // 
            this.rbMage.AutoSize = true;
            this.rbMage.Location = new System.Drawing.Point(42, 80);
            this.rbMage.Name = "rbMage";
            this.rbMage.Size = new System.Drawing.Size(52, 17);
            this.rbMage.TabIndex = 1;
            this.rbMage.TabStop = true;
            this.rbMage.Text = "Mage";
            this.rbMage.UseVisualStyleBackColor = true;
            this.rbMage.CheckedChanged += new System.EventHandler(this.rbMage_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select character class";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(366, 397);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(366, 450);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(61, 13);
            this.lblIntelligence.TabIndex = 5;
            this.lblIntelligence.Text = "Intelligence";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(366, 426);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(47, 13);
            this.lblDamage.TabIndex = 6;
            this.lblDamage.Text = "Damage";
            // 
            // lbAddedOptions
            // 
            this.lbAddedOptions.FormattingEnabled = true;
            this.lbAddedOptions.Location = new System.Drawing.Point(465, 137);
            this.lbAddedOptions.Name = "lbAddedOptions";
            this.lbAddedOptions.Size = new System.Drawing.Size(142, 147);
            this.lbAddedOptions.TabIndex = 7;
            // 
            // lbAvailableOptions
            // 
            this.lbAvailableOptions.FormattingEnabled = true;
            this.lbAvailableOptions.Location = new System.Drawing.Point(658, 137);
            this.lbAvailableOptions.Name = "lbAvailableOptions";
            this.lbAvailableOptions.Size = new System.Drawing.Size(142, 147);
            this.lbAvailableOptions.TabIndex = 8;
            // 
            // tbAddedOptions
            // 
            this.tbAddedOptions.AutoSize = true;
            this.tbAddedOptions.Location = new System.Drawing.Point(462, 100);
            this.tbAddedOptions.Name = "tbAddedOptions";
            this.tbAddedOptions.Size = new System.Drawing.Size(75, 13);
            this.tbAddedOptions.TabIndex = 9;
            this.tbAddedOptions.Text = "Added options";
            // 
            // lblAvailableOptions
            // 
            this.lblAvailableOptions.AutoSize = true;
            this.lblAvailableOptions.Location = new System.Drawing.Point(655, 96);
            this.lblAvailableOptions.Name = "lblAvailableOptions";
            this.lblAvailableOptions.Size = new System.Drawing.Size(87, 13);
            this.lblAvailableOptions.TabIndex = 10;
            this.lblAvailableOptions.Text = "Available options";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(685, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(478, 304);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(109, 23);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Buy character";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(475, 348);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(35, 13);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 482);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAvailableOptions);
            this.Controls.Add(this.tbAddedOptions);
            this.Controls.Add(this.lbAvailableOptions);
            this.Controls.Add(this.lbAddedOptions);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblIntelligence);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbMage);
            this.Controls.Add(this.rbWarrior);
            this.Name = "Form1";
            this.Text = "Create gaming character";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbWarrior;
        private System.Windows.Forms.RadioButton rbMage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.ListBox lbAddedOptions;
        private System.Windows.Forms.ListBox lbAvailableOptions;
        private System.Windows.Forms.Label tbAddedOptions;
        private System.Windows.Forms.Label lblAvailableOptions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblInfo;
    }
}

