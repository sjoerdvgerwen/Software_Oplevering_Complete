using System.Windows.Forms;

namespace CookieClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonBakker = new System.Windows.Forms.Button();
            this.buttonOven = new System.Windows.Forms.Button();
            this.buttonDeegroller = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kpsTb = new System.Windows.Forms.TextBox();
            this.koekjesTb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Kps";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(410, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Koekjes";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonBakker
            // 
            this.buttonBakker.Enabled = false;
            this.buttonBakker.Location = new System.Drawing.Point(19, 17);
            this.buttonBakker.Name = "buttonBakker";
            this.buttonBakker.Size = new System.Drawing.Size(208, 44);
            this.buttonBakker.TabIndex = 3;
            this.buttonBakker.Text = "Bakker (100) : 0";
            this.buttonBakker.UseVisualStyleBackColor = true;
            this.buttonBakker.Click += new System.EventHandler(this.buttonBakker_Click);
            // 
            // buttonOven
            // 
            this.buttonOven.Enabled = false;
            this.buttonOven.Location = new System.Drawing.Point(19, 82);
            this.buttonOven.Name = "buttonOven";
            this.buttonOven.Size = new System.Drawing.Size(208, 45);
            this.buttonOven.TabIndex = 4;
            this.buttonOven.Text = "Oven (2000) : 0";
            this.buttonOven.UseVisualStyleBackColor = true;
            this.buttonOven.Click += new System.EventHandler(this.buttonOven_Click);
            // 
            // buttonDeegroller
            // 
            this.buttonDeegroller.Enabled = false;
            this.buttonDeegroller.Location = new System.Drawing.Point(19, 144);
            this.buttonDeegroller.Name = "buttonDeegroller";
            this.buttonDeegroller.Size = new System.Drawing.Size(208, 48);
            this.buttonDeegroller.TabIndex = 5;
            this.buttonDeegroller.Text = "Deegroller (3500) : 0";
            this.buttonDeegroller.UseVisualStyleBackColor = true;
            this.buttonDeegroller.Click += new System.EventHandler(this.buttonDeegroller_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(650, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "+ 10 Kps";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(650, 218);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "+ 50 Kps";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(650, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "+ 10 per klik";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeegroller);
            this.groupBox1.Controls.Add(this.buttonOven);
            this.groupBox1.Controls.Add(this.buttonBakker);
            this.groupBox1.Location = new System.Drawing.Point(391, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 224);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upgrades";
            // 
            // kpsTb
            // 
            this.kpsTb.Location = new System.Drawing.Point(466, 41);
            this.kpsTb.Name = "kpsTb";
            this.kpsTb.Size = new System.Drawing.Size(100, 23);
            this.kpsTb.TabIndex = 10;
            // 
            // koekjesTb
            // 
            this.koekjesTb.Location = new System.Drawing.Point(480, 71);
            this.koekjesTb.Name = "koekjesTb";
            this.koekjesTb.Size = new System.Drawing.Size(100, 23);
            this.koekjesTb.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.koekjesTb);
            this.Controls.Add(this.kpsTb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonBakker;
        private System.Windows.Forms.Button buttonOven;
        private System.Windows.Forms.Button buttonDeegroller;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kpsTb;
        private System.Windows.Forms.TextBox koekjesTb;
        private System.Windows.Forms.Timer timer1;
        private Timer timer2;
    }
}

