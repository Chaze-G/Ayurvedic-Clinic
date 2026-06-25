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
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLicenceNo = new System.Windows.Forms.TextBox();
            this.txtPharmacistName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(216)))), ((int)(((byte)(204)))));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(216, 434);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(132, 44);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(145, 364);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(298, 21);
            this.cmbGender.TabIndex = 19;
            // 
            // txtContactNo
            // 
            this.txtContactNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtContactNo.Location = new System.Drawing.Point(145, 293);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContactNo.MaxLength = 10;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(298, 20);
            this.txtContactNo.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 366);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Gender :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Licence No:";
            // 
            // txtLicenceNo
            // 
            this.txtLicenceNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtLicenceNo.Location = new System.Drawing.Point(145, 226);
            this.txtLicenceNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLicenceNo.Name = "txtLicenceNo";
            this.txtLicenceNo.Size = new System.Drawing.Size(298, 20);
            this.txtLicenceNo.TabIndex = 14;
            // 
            // txtPharmacistName
            // 
            this.txtPharmacistName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPharmacistName.Location = new System.Drawing.Point(145, 165);
            this.txtPharmacistName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPharmacistName.Name = "txtPharmacistName";
            this.txtPharmacistName.Size = new System.Drawing.Size(298, 20);
            this.txtPharmacistName.TabIndex = 13;
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
            // Pharmacist_registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.Background_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 594);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLicenceNo);
            this.Controls.Add(this.txtPharmacistName);
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

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLicenceNo;
        private System.Windows.Forms.TextBox txtPharmacistName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}