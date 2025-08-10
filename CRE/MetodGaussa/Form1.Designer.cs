using System.Drawing;
using System;

namespace MetodGaussa
{
    partial class Form1
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
            this.numEquations = new System.Windows.Forms.NumericUpDown();
            this.numVariables = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblEquations = new System.Windows.Forms.Label();
            this.lblVariables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEquations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariables)).BeginInit();
            this.SuspendLayout();
            // 
            // numEquations
            // 
            this.numEquations.Location = new System.Drawing.Point(150, 10);
            this.numEquations.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numEquations.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numEquations.Name = "numEquations";
            this.numEquations.Size = new System.Drawing.Size(120, 20);
            this.numEquations.TabIndex = 2;
            this.numEquations.Value = new decimal(new int[] {2, 0, 0, 0});
            // 
            // numVariables
            // 
            this.numVariables.Location = new System.Drawing.Point(150, 50);
            this.numVariables.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numVariables.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numVariables.Name = "numVariables";
            this.numVariables.Size = new System.Drawing.Size(120, 20);
            this.numVariables.TabIndex = 3;
            this.numVariables.Value = new decimal(new int[] {2, 0, 0, 0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 90);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 30);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Создать матрицу";
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // panelMatrix
            // 
            this.panelMatrix.AutoScroll = true;
            this.panelMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrix.Location = new System.Drawing.Point(150, 90);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(649, 310);
            this.panelMatrix.TabIndex = 5;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(10, 130);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(120, 30);
            this.btnSolve.TabIndex = 6;
            this.btnSolve.Text = "Решить систему";
            this.btnSolve.Click += new System.EventHandler(this.BtnSolve_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(150, 406);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(649, 81);
            this.txtResult.TabIndex = 7;
            // 
            // lblEquations
            // 
            this.lblEquations.Location = new System.Drawing.Point(10, 10);
            this.lblEquations.Name = "lblEquations";
            this.lblEquations.Size = new System.Drawing.Size(134, 23);
            this.lblEquations.TabIndex = 0;
            this.lblEquations.Text = "Количество уравнений:";
            // 
            // lblVariables
            // 
            this.lblVariables.Location = new System.Drawing.Point(10, 50);
            this.lblVariables.Name = "lblVariables";
            this.lblVariables.Size = new System.Drawing.Size(140, 23);
            this.lblVariables.TabIndex = 1;
            this.lblVariables.Text = "Количество переменных:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.Controls.Add(this.lblEquations);
            this.Controls.Add(this.lblVariables);
            this.Controls.Add(this.numEquations);
            this.Controls.Add(this.numVariables);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение систем уравнений методом Гаусса";
            ((System.ComponentModel.ISupportInitialize)(this.numEquations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numEquations;
        private System.Windows.Forms.NumericUpDown numVariables;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblEquations;
        private System.Windows.Forms.Label lblVariables;
    }
}