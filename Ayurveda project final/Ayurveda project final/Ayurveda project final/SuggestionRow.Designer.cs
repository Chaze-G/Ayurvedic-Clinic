namespace Ayurveda_project_final
{
    partial class SuggestionRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTextBlock = new System.Windows.Forms.Panel();
            this.lblDescription1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chkSelect1 = new System.Windows.Forms.CheckBox();
            this.pnlTextBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextBlock
            // 
            this.pnlTextBlock.BackColor = System.Drawing.Color.White;
            this.pnlTextBlock.Controls.Add(this.lblDescription1);
            this.pnlTextBlock.Controls.Add(this.lblName);
            this.pnlTextBlock.Location = new System.Drawing.Point(758, 3);
            this.pnlTextBlock.Name = "pnlTextBlock";
            this.pnlTextBlock.Size = new System.Drawing.Size(342, 55);
            this.pnlTextBlock.TabIndex = 0;
            // 
            // lblDescription1
            // 
            this.lblDescription1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription1.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription1.Location = new System.Drawing.Point(7, 24);
            this.lblDescription1.Name = "lblDescription1";
            this.lblDescription1.Size = new System.Drawing.Size(262, 25);
            this.lblDescription1.TabIndex = 1;
            this.lblDescription1.Text = "Mosquito infections";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(262, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Maleria";
            // 
            // chkSelect1
            // 
            this.chkSelect1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSelect1.BackColor = System.Drawing.Color.White;
            this.chkSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSelect1.Location = new System.Drawing.Point(1050, 13);
            this.chkSelect1.Name = "chkSelect1";
            this.chkSelect1.Size = new System.Drawing.Size(28, 31);
            this.chkSelect1.TabIndex = 1;
            this.chkSelect1.UseVisualStyleBackColor = false;
            // 
            // SuggestionRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.chkSelect1);
            this.Controls.Add(this.pnlTextBlock);
            this.Name = "SuggestionRow";
            this.Size = new System.Drawing.Size(1867, 778);
            this.Load += new System.EventHandler(this.SuggestionRow_Load);
            this.pnlTextBlock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextBlock;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription1;
        private System.Windows.Forms.CheckBox chkSelect1;
    }
}
