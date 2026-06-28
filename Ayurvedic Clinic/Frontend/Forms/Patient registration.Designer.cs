namespace Ayurvedic_Clinic.Frontend.Forms
{
    partial class Patient_registration
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
            System.Windows.Forms.ComboBox prgenderdropdown;
            this.prsavebut = new System.Windows.Forms.Button();
            this.prallergiestxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.praddresstxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prcnumbertxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pragetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.prbackbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prifchildbut = new System.Windows.Forms.Button();
            prgenderdropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prgenderdropdown
            // 
            prgenderdropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            prgenderdropdown.FormattingEnabled = true;
            prgenderdropdown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            prgenderdropdown.Location = new System.Drawing.Point(190, 270);
            prgenderdropdown.Name = "prgenderdropdown";
            prgenderdropdown.Size = new System.Drawing.Size(356, 21);
            prgenderdropdown.TabIndex = 28;
            prgenderdropdown.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            // 
            // prsavebut
            // 
            this.prsavebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.prsavebut.Location = new System.Drawing.Point(471, 426);
            this.prsavebut.Name = "prsavebut";
            this.prsavebut.Size = new System.Drawing.Size(75, 23);
            this.prsavebut.TabIndex = 29;
            this.prsavebut.Text = "Save";
            this.prsavebut.UseVisualStyleBackColor = false;
            this.prsavebut.Click += new System.EventHandler(this.prsavebut_Click);
            // 
            // prallergiestxt
            // 
            this.prallergiestxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.prallergiestxt.Location = new System.Drawing.Point(190, 373);
            this.prallergiestxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prallergiestxt.Name = "prallergiestxt";
            this.prallergiestxt.Size = new System.Drawing.Size(356, 20);
            this.prallergiestxt.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 373);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Allergies :";
            // 
            // praddresstxt
            // 
            this.praddresstxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.praddresstxt.Location = new System.Drawing.Point(190, 320);
            this.praddresstxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.praddresstxt.Name = "praddresstxt";
            this.praddresstxt.Size = new System.Drawing.Size(356, 20);
            this.praddresstxt.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 270);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender :";
            // 
            // prcnumbertxt
            // 
            this.prcnumbertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.prcnumbertxt.Location = new System.Drawing.Point(190, 216);
            this.prcnumbertxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prcnumbertxt.MaxLength = 10;
            this.prcnumbertxt.Name = "prcnumbertxt";
            this.prcnumbertxt.Size = new System.Drawing.Size(356, 20);
            this.prcnumbertxt.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contact Number:";
            // 
            // pragetxt
            // 
            this.pragetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.pragetxt.Location = new System.Drawing.Point(190, 168);
            this.pragetxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pragetxt.MaxLength = 3;
            this.pragetxt.Name = "pragetxt";
            this.pragetxt.Size = new System.Drawing.Size(356, 20);
            this.pragetxt.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Age:";
            // 
            // prnametxt
            // 
            this.prnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.prnametxt.Location = new System.Drawing.Point(190, 120);
            this.prnametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prnametxt.Name = "prnametxt";
            this.prnametxt.Size = new System.Drawing.Size(356, 20);
            this.prnametxt.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Patient Name:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(-2, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prbackbut
            // 
            this.prbackbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.prbackbut.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prbackbut.ForeColor = System.Drawing.Color.DarkGreen;
            this.prbackbut.Location = new System.Drawing.Point(587, 29);
            this.prbackbut.Margin = new System.Windows.Forms.Padding(2);
            this.prbackbut.Name = "prbackbut";
            this.prbackbut.Size = new System.Drawing.Size(71, 24);
            this.prbackbut.TabIndex = 32;
            this.prbackbut.Text = "<<BACK";
            this.prbackbut.UseVisualStyleBackColor = false;
            this.prbackbut.Click += new System.EventHandler(this.prbackbut_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 469);
            this.label1.TabIndex = 16;
            this.label1.Text = "SUWA SEWANA  - Patient Registration  Form\r\n\r\n\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // prifchildbut
            // 
            this.prifchildbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.prifchildbut.Location = new System.Drawing.Point(87, 72);
            this.prifchildbut.Name = "prifchildbut";
            this.prifchildbut.Size = new System.Drawing.Size(131, 23);
            this.prifchildbut.TabIndex = 33;
            this.prifchildbut.Text = "Click to Register a child";
            this.prifchildbut.UseVisualStyleBackColor = false;
            // 
            // Patient_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.Background_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(669, 553);
            this.Controls.Add(this.prifchildbut);
            this.Controls.Add(this.prbackbut);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.prsavebut);
            this.Controls.Add(prgenderdropdown);
            this.Controls.Add(this.prallergiestxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.praddresstxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prcnumbertxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pragetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Patient_registration";
            this.Text = "Patient_registration";
            this.Load += new System.EventHandler(this.Patient_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prsavebut;
        private System.Windows.Forms.TextBox prallergiestxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox praddresstxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prcnumbertxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pragetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button prbackbut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prifchildbut;
    }
}