namespace BattleSim1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Archer = new System.Windows.Forms.Button();
            this.Button_Knight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HP_Archer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.HP_Knight = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Archer
            // 
            this.Button_Archer.Enabled = false;
            this.Button_Archer.Location = new System.Drawing.Point(549, 302);
            this.Button_Archer.Name = "Button_Archer";
            this.Button_Archer.Size = new System.Drawing.Size(70, 23);
            this.Button_Archer.TabIndex = 0;
            this.Button_Archer.Text = "Attack";
            this.Button_Archer.UseVisualStyleBackColor = true;
            this.Button_Archer.Click += new System.EventHandler(this.Button_Archer_Click);
            // 
            // Button_Knight
            // 
            this.Button_Knight.Location = new System.Drawing.Point(178, 302);
            this.Button_Knight.Name = "Button_Knight";
            this.Button_Knight.Size = new System.Drawing.Size(75, 23);
            this.Button_Knight.TabIndex = 1;
            this.Button_Knight.Text = "Attack";
            this.Button_Knight.UseVisualStyleBackColor = true;
            this.Button_Knight.Click += new System.EventHandler(this.Button_Knight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 216);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(91, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 216);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // HP_Archer
            // 
            this.HP_Archer.Location = new System.Drawing.Point(531, 341);
            this.HP_Archer.Name = "HP_Archer";
            this.HP_Archer.Size = new System.Drawing.Size(100, 23);
            this.HP_Archer.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(480, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(23, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "HP";
            // 
            // HP_Knight
            // 
            this.HP_Knight.Location = new System.Drawing.Point(162, 341);
            this.HP_Knight.Name = "HP_Knight";
            this.HP_Knight.Size = new System.Drawing.Size(100, 23);
            this.HP_Knight.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 341);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(27, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "HP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.HP_Knight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.HP_Archer);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_Knight);
            this.Controls.Add(this.Button_Archer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Archer;
        private System.Windows.Forms.Button Button_Knight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox HP_Archer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox HP_Knight;
        private System.Windows.Forms.TextBox textBox4;
    }
}

