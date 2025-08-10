namespace TriangleCalculator
{
    partial class ResultForm
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

        private void InitializeComponent()
        {
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimeterLabel.Location = new System.Drawing.Point(30, 30);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(83, 16);
            this.perimeterLabel.TabIndex = 0;
            this.perimeterLabel.Text = "Периметр: ";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaLabel.Location = new System.Drawing.Point(30, 70);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(71, 16);
            this.areaLabel.TabIndex = 1;
            this.areaLabel.Text = "Площадь: ";
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 121);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.perimeterLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Результаты расчета";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.Label areaLabel;
    }
}