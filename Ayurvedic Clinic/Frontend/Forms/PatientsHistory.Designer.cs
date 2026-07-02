namespace Ayurvedic_Clinic.Frontend.Forms
{
    partial class PatientsHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phbackbut = new System.Windows.Forms.Button();
            this.phagetxt = new System.Windows.Forms.TextBox();
            this.phallergiestxt = new System.Windows.Forms.TextBox();
            this.phpatientnametxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Allergies :";
            // 
            // phbackbut
            // 
            this.phbackbut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(248)))), ((int)(((byte)(174)))));
            this.phbackbut.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phbackbut.ForeColor = System.Drawing.Color.DarkGreen;
            this.phbackbut.Location = new System.Drawing.Point(694, 12);
            this.phbackbut.Name = "phbackbut";
            this.phbackbut.Size = new System.Drawing.Size(95, 29);
            this.phbackbut.TabIndex = 10;
            this.phbackbut.Text = "<<BACK";
            this.phbackbut.UseVisualStyleBackColor = false;
            this.phbackbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // phagetxt
            // 
            this.phagetxt.Location = new System.Drawing.Point(678, 99);
            this.phagetxt.Name = "phagetxt";
            this.phagetxt.Size = new System.Drawing.Size(91, 22);
            this.phagetxt.TabIndex = 11;
            // 
            // phallergiestxt
            // 
            this.phallergiestxt.Location = new System.Drawing.Point(164, 127);
            this.phallergiestxt.Multiline = true;
            this.phallergiestxt.Name = "phallergiestxt";
            this.phallergiestxt.Size = new System.Drawing.Size(389, 43);
            this.phallergiestxt.TabIndex = 13;
            // 
            // phpatientnametxt
            // 
            this.phpatientnametxt.Location = new System.Drawing.Point(164, 99);
            this.phpatientnametxt.Name = "phpatientnametxt";
            this.phpatientnametxt.Size = new System.Drawing.Size(389, 22);
            this.phpatientnametxt.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(324, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 29);
            this.label11.TabIndex = 21;
            this.label11.Text = "Patients\' History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-28, -57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // PatientsHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.BackgroundImage = global::Ayurvedic_Clinic.Properties.Resources.WhatsApp_Image_2026_06_23_at_11_47_31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 687);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.phpatientnametxt);
            this.Controls.Add(this.phallergiestxt);
            this.Controls.Add(this.phagetxt);
            this.Controls.Add(this.phbackbut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "PatientsHistory";
            this.Text = "PatientsHistory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button phbackbut;
        private System.Windows.Forms.TextBox phagetxt;
        private System.Windows.Forms.TextBox phallergiestxt;
        private System.Windows.Forms.TextBox phpatientnametxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}