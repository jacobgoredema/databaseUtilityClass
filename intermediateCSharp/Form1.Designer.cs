﻿namespace intermediateCSharp
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
            this.btnGetSalary = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGetEmployeeSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetSalary
            // 
            this.btnGetSalary.Location = new System.Drawing.Point(197, 226);
            this.btnGetSalary.Name = "btnGetSalary";
            this.btnGetSalary.Size = new System.Drawing.Size(75, 23);
            this.btnGetSalary.TabIndex = 0;
            this.btnGetSalary.Text = "Get Salary";
            this.btnGetSalary.UseVisualStyleBackColor = true;
            this.btnGetSalary.Click += new System.EventHandler(this.btnGetSalary_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(108, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnGetEmployeeSalary
            // 
            this.btnGetEmployeeSalary.Location = new System.Drawing.Point(70, 226);
            this.btnGetEmployeeSalary.Name = "btnGetEmployeeSalary";
            this.btnGetEmployeeSalary.Size = new System.Drawing.Size(121, 23);
            this.btnGetEmployeeSalary.TabIndex = 3;
            this.btnGetEmployeeSalary.Text = "Get Employee Salary";
            this.btnGetEmployeeSalary.UseVisualStyleBackColor = true;
            this.btnGetEmployeeSalary.Click += new System.EventHandler(this.btnGetEmployeeSalary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGetEmployeeSalary);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetSalary);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGetEmployeeSalary;
    }
}

