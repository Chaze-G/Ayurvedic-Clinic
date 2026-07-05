namespace Ayurvedic_Clinic.Frontend.Forms
{
    partial class DoctorRegistor
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.drpasswordtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drnametxt = new System.Windows.Forms.TextBox();
            this.drgenderfemalecheckbox = new System.Windows.Forms.CheckBox();
            this.drregisterbut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.drgendermalecheckbox = new System.Windows.Forms.CheckBox();
            this.drslmctxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drcontatcttxt = new System.Windows.Forms.TextBox();
            this.drspecializedtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.drbackbut = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.drpasswordtxt);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.drnametxt);
            this.panelMain.Controls.Add(this.drgenderfemalecheckbox);
            this.panelMain.Controls.Add(this.drregisterbut);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.drgendermalecheckbox);
            this.panelMain.Controls.Add(this.drslmctxt);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.drcontatcttxt);
            this.panelMain.Controls.Add(this.drspecializedtxt);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Location = new System.Drawing.Point(92, 90);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(638, 489);
            this.panelMain.TabIndex = 19;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Password";
            // 
            // drpasswordtxt
            // 
            this.drpasswordtxt.Location = new System.Drawing.Point(184, 139);
            this.drpasswordtxt.Name = "drpasswordtxt";
            this.drpasswordtxt.Size = new System.Drawing.Size(194, 20);
            this.drpasswordtxt.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Ayurvedic_Clinic.Properties.Resources._new;
            this.pictureBox1.Location = new System.Drawing.Point(419, 153);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Doctor Name :";
            // 
            // drnametxt
            // 
            this.drnametxt.BackColor = System.Drawing.Color.White;
            this.drnametxt.Location = new System.Drawing.Point(184, 66);
            this.drnametxt.Name = "drnametxt";
            this.drnametxt.Size = new System.Drawing.Size(230, 20);
            this.drnametxt.TabIndex = 2;
            this.drnametxt.TextChanged += new System.EventHandler(this.drnametxt_TextChanged);
            // 
            // drgenderfemalecheckbox
            // 
            this.drgenderfemalecheckbox.AutoSize = true;
            this.drgenderfemalecheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgenderfemalecheckbox.Location = new System.Drawing.Point(242, 277);
            this.drgenderfemalecheckbox.Name = "drgenderfemalecheckbox";
            this.drgenderfemalecheckbox.Size = new System.Drawing.Size(68, 19);
            this.drgenderfemalecheckbox.TabIndex = 15;
            this.drgenderfemalecheckbox.Text = "Female";
            this.drgenderfemalecheckbox.UseVisualStyleBackColor = true;
            this.drgenderfemalecheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // drregisterbut
            // 
            this.drregisterbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(216)))), ((int)(((byte)(204)))));
            this.drregisterbut.FlatAppearance.BorderSize = 0;
            this.drregisterbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drregisterbut.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drregisterbut.Location = new System.Drawing.Point(177, 346);
            this.drregisterbut.Name = "drregisterbut";
            this.drregisterbut.Size = new System.Drawing.Size(133, 43);
            this.drregisterbut.TabIndex = 0;
            this.drregisterbut.Text = "Register";
            this.drregisterbut.UseVisualStyleBackColor = false;
            this.drregisterbut.Click += new System.EventHandler(this.drregisterbut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "AMC No :";
            // 
            // drgendermalecheckbox
            // 
            this.drgendermalecheckbox.AutoSize = true;
            this.drgendermalecheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drgendermalecheckbox.Location = new System.Drawing.Point(177, 277);
            this.drgendermalecheckbox.Name = "drgendermalecheckbox";
            this.drgendermalecheckbox.Size = new System.Drawing.Size(54, 19);
            this.drgendermalecheckbox.TabIndex = 14;
            this.drgendermalecheckbox.Text = "Male";
            this.drgendermalecheckbox.UseVisualStyleBackColor = true;
            // 
            // drslmctxt
            // 
            this.drslmctxt.Location = new System.Drawing.Point(184, 102);
            this.drslmctxt.Name = "drslmctxt";
            this.drslmctxt.Size = new System.Drawing.Size(134, 20);
            this.drslmctxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender :";
            // 
            // drcontatcttxt
            // 
            this.drcontatcttxt.Location = new System.Drawing.Point(184, 221);
            this.drcontatcttxt.Name = "drcontatcttxt";
            this.drcontatcttxt.Size = new System.Drawing.Size(134, 20);
            this.drcontatcttxt.TabIndex = 11;
            // 
            // drspecializedtxt
            // 
            this.drspecializedtxt.Location = new System.Drawing.Point(184, 179);
            this.drspecializedtxt.Name = "drspecializedtxt";
            this.drspecializedtxt.Size = new System.Drawing.Size(230, 20);
            this.drspecializedtxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specialized For :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Doctor Registrarion Form";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.Location = new System.Drawing.Point(158, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // drbackbut
            // 
            this.drbackbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.drbackbut.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbackbut.ForeColor = System.Drawing.Color.DarkGreen;
            this.drbackbut.Location = new System.Drawing.Point(567, 40);
            this.drbackbut.Margin = new System.Windows.Forms.Padding(2);
            this.drbackbut.Name = "drbackbut";
            this.drbackbut.Size = new System.Drawing.Size(71, 24);
            this.drbackbut.TabIndex = 21;
            this.drbackbut.Text = "<<BACK";
            this.drbackbut.UseVisualStyleBackColor = false;
            this.drbackbut.Click += new System.EventHandler(this.phbackbut_Click);
            // 
            // DoctorRegistor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.img_by_madusha;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(660, 540);
            this.Controls.Add(this.drbackbut);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.label1);
            this.Name = "DoctorRegistor";
            this.Text = "DoctorRegistor";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox drgenderfemalecheckbox;
        private System.Windows.Forms.Button drregisterbut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox drgendermalecheckbox;
        private System.Windows.Forms.TextBox drslmctxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox drcontatcttxt;
        private System.Windows.Forms.TextBox drspecializedtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button drbackbut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox drpasswordtxt;
        private System.Windows.Forms.TextBox drnametxt;
    }
}