namespace Ayurvedic_Clinic.Frontend.Forms
{
    partial class Pharmacist_registration
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
            this.phregisterbut = new System.Windows.Forms.Button();
            this.phregisterdropdown = new System.Windows.Forms.ComboBox();
            this.phrcontactnotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phrlicencenotxt = new System.Windows.Forms.TextBox();
            this.phregnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phreglicencetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phregisterbut
            // 
            this.phregisterbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(216)))), ((int)(((byte)(204)))));
            this.phregisterbut.ForeColor = System.Drawing.Color.Black;
            this.phregisterbut.Location = new System.Drawing.Point(216, 384);
            this.phregisterbut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phregisterbut.Name = "phregisterbut";
            this.phregisterbut.Size = new System.Drawing.Size(132, 44);
            this.phregisterbut.TabIndex = 20;
            this.phregisterbut.Text = "Register";
            this.phregisterbut.UseVisualStyleBackColor = false;
            this.phregisterbut.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // phregisterdropdown
            // 
            this.phregisterdropdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.phregisterdropdown.FormattingEnabled = true;
            this.phregisterdropdown.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.phregisterdropdown.Location = new System.Drawing.Point(145, 325);
            this.phregisterdropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phregisterdropdown.Name = "phregisterdropdown";
            this.phregisterdropdown.Size = new System.Drawing.Size(298, 21);
            this.phregisterdropdown.TabIndex = 19;
            this.phregisterdropdown.SelectedIndexChanged += new System.EventHandler(this.phregisterdropdown_SelectedIndexChanged);
            // 
            // phrcontactnotxt
            // 
            this.phrcontactnotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.phrcontactnotxt.Location = new System.Drawing.Point(145, 281);
            this.phrcontactnotxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phrcontactnotxt.MaxLength = 10;
            this.phrcontactnotxt.Name = "phrcontactnotxt";
            this.phrcontactnotxt.Size = new System.Drawing.Size(298, 20);
            this.phrcontactnotxt.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // phrlicencenotxt
            // 
            this.phrlicencenotxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.phrlicencenotxt.Location = new System.Drawing.Point(145, 243);
            this.phrlicencenotxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phrlicencenotxt.Name = "phrlicencenotxt";
            this.phrlicencenotxt.Size = new System.Drawing.Size(298, 20);
            this.phrlicencenotxt.TabIndex = 14;
            // 
            // phregnametxt
            // 
            this.phregnametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.phregnametxt.Location = new System.Drawing.Point(145, 165);
            this.phregnametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phregnametxt.Name = "phregnametxt";
            this.phregnametxt.Size = new System.Drawing.Size(298, 20);
            this.phregnametxt.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pharmacist Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(141, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pharmacist Registration Form";
            // 
            // phreglicencetxt
            // 
            this.phreglicencetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.phreglicencetxt.Location = new System.Drawing.Point(145, 205);
            this.phreglicencetxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phreglicencetxt.Name = "phreglicencetxt";
            this.phreglicencetxt.Size = new System.Drawing.Size(298, 20);
            this.phreglicencetxt.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Licence No:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Pharmacist_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.Background_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 594);
            this.Controls.Add(this.phreglicencetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phregisterbut);
            this.Controls.Add(this.phregisterdropdown);
            this.Controls.Add(this.phrcontactnotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phrlicencenotxt);
            this.Controls.Add(this.phregnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pharmacist_registration";
            this.Text = "Pharmacist_registration";
            this.Load += new System.EventHandler(this.Pharmacist_registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button phregisterbut;
        private System.Windows.Forms.ComboBox phregisterdropdown;
        private System.Windows.Forms.TextBox phrcontactnotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phrlicencenotxt;
        private System.Windows.Forms.TextBox phregnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phreglicencetxt;
        private System.Windows.Forms.Label label6;
    }
}