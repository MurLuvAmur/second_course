namespace TriangleCalculator
{
    partial class InputForm
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
            this.sideATextBox = new System.Windows.Forms.TextBox();
            this.sideBTextBox = new System.Windows.Forms.TextBox();
            this.sideCTextBox = new System.Windows.Forms.TextBox();
            this.perimeterCheckBox = new System.Windows.Forms.CheckBox();
            this.areaCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sideATextBox
            // 
            this.sideATextBox.Location = new System.Drawing.Point(120, 20);
            this.sideATextBox.Name = "sideATextBox";
            this.sideATextBox.Size = new System.Drawing.Size(100, 20);
            this.sideATextBox.TabIndex = 0;
            // 
            // sideBTextBox
            // 
            this.sideBTextBox.Location = new System.Drawing.Point(120, 50);
            this.sideBTextBox.Name = "sideBTextBox";
            this.sideBTextBox.Size = new System.Drawing.Size(100, 20);
            this.sideBTextBox.TabIndex = 1;
            // 
            // sideCTextBox
            // 
            this.sideCTextBox.Location = new System.Drawing.Point(120, 80);
            this.sideCTextBox.Name = "sideCTextBox";
            this.sideCTextBox.Size = new System.Drawing.Size(100, 20);
            this.sideCTextBox.TabIndex = 2;
            // 
            // perimeterCheckBox
            // 
            this.perimeterCheckBox.AutoSize = true;
            this.perimeterCheckBox.Location = new System.Drawing.Point(30, 120);
            this.perimeterCheckBox.Name = "perimeterCheckBox";
            this.perimeterCheckBox.Size = new System.Drawing.Size(75, 17);
            this.perimeterCheckBox.TabIndex = 3;
            this.perimeterCheckBox.Text = "Периметр";
            this.perimeterCheckBox.UseVisualStyleBackColor = true;
            // 
            // areaCheckBox
            // 
            this.areaCheckBox.AutoSize = true;
            this.areaCheckBox.Location = new System.Drawing.Point(30, 145);
            this.areaCheckBox.Name = "areaCheckBox";
            this.areaCheckBox.Size = new System.Drawing.Size(70, 17);
            this.areaCheckBox.TabIndex = 4;
            this.areaCheckBox.Text = "Площадь";
            this.areaCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(145, 180);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Сторона A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сторона B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сторона C:";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.areaCheckBox);
            this.Controls.Add(this.perimeterCheckBox);
            this.Controls.Add(this.sideCTextBox);
            this.Controls.Add(this.sideBTextBox);
            this.Controls.Add(this.sideATextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ввод параметров";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox sideATextBox;
        private System.Windows.Forms.TextBox sideBTextBox;
        private System.Windows.Forms.TextBox sideCTextBox;
        private System.Windows.Forms.CheckBox perimeterCheckBox;
        private System.Windows.Forms.CheckBox areaCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}