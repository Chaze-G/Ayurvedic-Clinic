namespace Ayurvedic_Clinic.Frontend.Forms
{
    partial class doctor_prescription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dpnotestxt = new System.Windows.Forms.RichTextBox();
            this.dplmcnumbertxt = new System.Windows.Forms.TextBox();
            this.dpsendtopharmacybut = new System.Windows.Forms.Button();
            this.dpDatetxt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dpmedipacksbut = new System.Windows.Forms.Button();
            this.dppatienthistorybut = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.dvnametxt = new System.Windows.Forms.TextBox();
            this.dpagetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpallergiestxt = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.dpformorepatientdetailbut = new System.Windows.Forms.Button();
            this.dpsearchnicbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dpnotestxt
            // 
            this.dpnotestxt.BackColor = System.Drawing.Color.White;
            this.dpnotestxt.Location = new System.Drawing.Point(25, 230);
            this.dpnotestxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpnotestxt.Name = "dpnotestxt";
            this.dpnotestxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.dpnotestxt.Size = new System.Drawing.Size(557, 204);
            this.dpnotestxt.TabIndex = 24;
            this.dpnotestxt.Text = "Notes-";
            this.dpnotestxt.TextChanged += new System.EventHandler(this.dpnotestxt_TextChanged);
            // 
            // dplmcnumbertxt
            // 
            this.dplmcnumbertxt.Location = new System.Drawing.Point(132, 443);
            this.dplmcnumbertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dplmcnumbertxt.Name = "dplmcnumbertxt";
            this.dplmcnumbertxt.Size = new System.Drawing.Size(107, 22);
            this.dplmcnumbertxt.TabIndex = 23;
            // 
            // dpsendtopharmacybut
            // 
            this.dpsendtopharmacybut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.dpsendtopharmacybut.Location = new System.Drawing.Point(412, 443);
            this.dpsendtopharmacybut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpsendtopharmacybut.Name = "dpsendtopharmacybut";
            this.dpsendtopharmacybut.Size = new System.Drawing.Size(170, 41);
            this.dpsendtopharmacybut.TabIndex = 22;
            this.dpsendtopharmacybut.Text = "Send to Pharmacy";
            this.dpsendtopharmacybut.UseVisualStyleBackColor = false;
            this.dpsendtopharmacybut.Click += new System.EventHandler(this.dpsendtopharmacybut_Click);
            // 
            // dpDatetxt
            // 
            this.dpDatetxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDatetxt.Location = new System.Drawing.Point(664, 80);
            this.dpDatetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDatetxt.Name = "dpDatetxt";
            this.dpDatetxt.Size = new System.Drawing.Size(110, 22);
            this.dpDatetxt.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dr AMC Number";
            // 
            // dpmedipacksbut
            // 
            this.dpmedipacksbut.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dpmedipacksbut.Location = new System.Drawing.Point(588, 304);
            this.dpmedipacksbut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpmedipacksbut.Name = "dpmedipacksbut";
            this.dpmedipacksbut.Size = new System.Drawing.Size(141, 50);
            this.dpmedipacksbut.TabIndex = 25;
            this.dpmedipacksbut.Text = "MEDI PACKS";
            this.dpmedipacksbut.UseVisualStyleBackColor = false;
            this.dpmedipacksbut.Click += new System.EventHandler(this.dpmedipacksbut_Click);
            // 
            // dppatienthistorybut
            // 
            this.dppatienthistorybut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dppatienthistorybut.Location = new System.Drawing.Point(588, 254);
            this.dppatienthistorybut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dppatienthistorybut.Name = "dppatienthistorybut";
            this.dppatienthistorybut.Size = new System.Drawing.Size(141, 44);
            this.dppatienthistorybut.TabIndex = 26;
            this.dppatienthistorybut.Text = "Patient History";
            this.dppatienthistorybut.UseVisualStyleBackColor = false;
            this.dppatienthistorybut.Click += new System.EventHandler(this.dppatienthistorybut_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Location = new System.Drawing.Point(81, 126);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(44, 16);
            this.lblPatientName.TabIndex = 27;
            this.lblPatientName.Text = "Name";
            // 
            // dvnametxt
            // 
            this.dvnametxt.Location = new System.Drawing.Point(131, 126);
            this.dvnametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvnametxt.Name = "dvnametxt";
            this.dvnametxt.Size = new System.Drawing.Size(527, 22);
            this.dvnametxt.TabIndex = 28;
            // 
            // dpagetxt
            // 
            this.dpagetxt.Location = new System.Drawing.Point(717, 119);
            this.dpagetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpagetxt.Name = "dpagetxt";
            this.dpagetxt.Size = new System.Drawing.Size(57, 22);
            this.dpagetxt.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Age";
            // 
            // dpallergiestxt
            // 
            this.dpallergiestxt.Location = new System.Drawing.Point(131, 154);
            this.dpallergiestxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpallergiestxt.Multiline = true;
            this.dpallergiestxt.Name = "dpallergiestxt";
            this.dpallergiestxt.Size = new System.Drawing.Size(645, 46);
            this.dpallergiestxt.TabIndex = 31;
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(65, 166);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(60, 16);
            this.Address.TabIndex = 32;
            this.Address.Text = "Allergies";
            // 
            // dpformorepatientdetailbut
            // 
            this.dpformorepatientdetailbut.BackColor = System.Drawing.Color.Aquamarine;
            this.dpformorepatientdetailbut.Location = new System.Drawing.Point(561, 201);
            this.dpformorepatientdetailbut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpformorepatientdetailbut.Name = "dpformorepatientdetailbut";
            this.dpformorepatientdetailbut.Size = new System.Drawing.Size(215, 23);
            this.dpformorepatientdetailbut.TabIndex = 33;
            this.dpformorepatientdetailbut.Text = "For Patient\'s More Details";
            this.dpformorepatientdetailbut.UseVisualStyleBackColor = false;
            this.dpformorepatientdetailbut.Click += new System.EventHandler(this.dpformorepatientdetailbut_Click);
            // 
            // dpsearchnicbut
            // 
            this.dpsearchnicbut.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dpsearchnicbut.Location = new System.Drawing.Point(625, 12);
            this.dpsearchnicbut.Name = "dpsearchnicbut";
            this.dpsearchnicbut.Size = new System.Drawing.Size(149, 23);
            this.dpsearchnicbut.TabIndex = 34;
            this.dpsearchnicbut.Text = "<<Back to Search NIC";
            this.dpsearchnicbut.UseVisualStyleBackColor = false;
            this.dpsearchnicbut.Click += new System.EventHandler(this.dpsearchnicbut_Click);
            // 
            // doctor_prescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.Background_img;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 753);
            this.Controls.Add(this.dpsearchnicbut);
            this.Controls.Add(this.dpformorepatientdetailbut);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.dpallergiestxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpagetxt);
            this.Controls.Add(this.dvnametxt);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.dppatienthistorybut);
            this.Controls.Add(this.dpmedipacksbut);
            this.Controls.Add(this.dpnotestxt);
            this.Controls.Add(this.dplmcnumbertxt);
            this.Controls.Add(this.dpsendtopharmacybut);
            this.Controls.Add(this.dpDatetxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "doctor_prescription";
            this.Text = "doctor_prescription";
            this.Load += new System.EventHandler(this.doctor_prescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox dpnotestxt;
        private System.Windows.Forms.TextBox dplmcnumbertxt;
        private System.Windows.Forms.Button dpsendtopharmacybut;
        private System.Windows.Forms.DateTimePicker dpDatetxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button dpmedipacksbut;
        private System.Windows.Forms.Button dppatienthistorybut;
        private System.Windows.Forms.Label lblPatientName;        
        private System.Windows.Forms.TextBox dvnametxt;
        private System.Windows.Forms.TextBox dpagetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dpallergiestxt;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Button dpformorepatientdetailbut;
        private System.Windows.Forms.Button dpsearchnicbut;
    }
}