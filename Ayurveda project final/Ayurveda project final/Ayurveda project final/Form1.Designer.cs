namespace Ayurveda_project_final
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
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
            this.pn1Container = new System.Windows.Forms.Panel();
            this.btnAddToPrescription = new System.Windows.Forms.Button();
            this.flpSuggestions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pn1Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn1Container
            // 
            this.pn1Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pn1Container.Controls.Add(this.btnAddToPrescription);
            this.pn1Container.Controls.Add(this.flpSuggestions);
            this.pn1Container.Controls.Add(this.lblTitle);
            this.pn1Container.Location = new System.Drawing.Point(40, 20);
            this.pn1Container.Name = "pn1Container";
            this.pn1Container.Size = new System.Drawing.Size(1755, 672);
            this.pn1Container.TabIndex = 0;
            // 
            // btnAddToPrescription
            // 
            this.btnAddToPrescription.BackColor = System.Drawing.Color.White;
            this.btnAddToPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToPrescription.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToPrescription.Location = new System.Drawing.Point(809, 632);
            this.btnAddToPrescription.Name = "btnAddToPrescription";
            this.btnAddToPrescription.Size = new System.Drawing.Size(220, 40);
            this.btnAddToPrescription.TabIndex = 1;
            this.btnAddToPrescription.Text = "Add To Prescription";
            this.btnAddToPrescription.UseVisualStyleBackColor = false;
            this.btnAddToPrescription.Click += new System.EventHandler(this.btnAddToPrescription_Click);
            // 
            // flpSuggestions
            // 
            this.flpSuggestions.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flpSuggestions.AutoScroll = true;
            this.flpSuggestions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpSuggestions.Location = new System.Drawing.Point(20, 50);
            this.flpSuggestions.Name = "flpSuggestions";
            this.flpSuggestions.Size = new System.Drawing.Size(1711, 590);
            this.flpSuggestions.TabIndex = 1;
            this.flpSuggestions.WrapContents = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTitle.Location = new System.Drawing.Point(838, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Suggestions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1841, 704);
            this.Controls.Add(this.pn1Container);
            this.Name = "Form1";
            this.Text = "Prescription Suggestions";
            this.pn1Container.ResumeLayout(false);
            this.pn1Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn1Container;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpSuggestions;
        private System.Windows.Forms.Button btnAddToPrescription;
    }
}

