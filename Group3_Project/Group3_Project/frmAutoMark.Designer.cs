﻿
namespace Group3_Project
{
    partial class frmAutoMark
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
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnInsertTest = new System.Windows.Forms.Button();
            this.btnAutoMark = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnInsertClass = new System.Windows.Forms.Button();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtTest
            // 
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTest.Location = new System.Drawing.Point(127, 42);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(192, 23);
            this.txtTest.TabIndex = 1;
            // 
            // btnInsertTest
            // 
            this.btnInsertTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTest.Location = new System.Drawing.Point(325, 42);
            this.btnInsertTest.Name = "btnInsertTest";
            this.btnInsertTest.Size = new System.Drawing.Size(101, 23);
            this.btnInsertTest.TabIndex = 2;
            this.btnInsertTest.Text = "Chose Folder";
            this.btnInsertTest.UseVisualStyleBackColor = true;
            this.btnInsertTest.Click += new System.EventHandler(this.btnInsertTest_Click);
            // 
            // btnAutoMark
            // 
            this.btnAutoMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoMark.Location = new System.Drawing.Point(188, 147);
            this.btnAutoMark.Name = "btnAutoMark";
            this.btnAutoMark.Size = new System.Drawing.Size(75, 23);
            this.btnAutoMark.TabIndex = 3;
            this.btnAutoMark.Text = "Auto Mark";
            this.btnAutoMark.UseVisualStyleBackColor = true;
            this.btnAutoMark.Click += new System.EventHandler(this.btnAutoMark_Click);
            // 
            // btnManage
            // 
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(351, 132);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(75, 38);
            this.btnManage.TabIndex = 4;
            this.btnManage.Text = "Manage >>>";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnInsertClass
            // 
            this.btnInsertClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertClass.Location = new System.Drawing.Point(325, 82);
            this.btnInsertClass.Name = "btnInsertClass";
            this.btnInsertClass.Size = new System.Drawing.Size(101, 23);
            this.btnInsertClass.TabIndex = 6;
            this.btnInsertClass.Text = "Chose Folder";
            this.btnInsertClass.UseVisualStyleBackColor = true;
            this.btnInsertClass.Click += new System.EventHandler(this.btnInsertClass_Click);
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClass.Location = new System.Drawing.Point(127, 82);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(192, 23);
            this.txtClass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Folder Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Folder Test Case";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 147);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // frmAutoMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 197);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertClass);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnAutoMark);
            this.Controls.Add(this.btnInsertTest);
            this.Controls.Add(this.txtTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAutoMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoMark";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAutoMark_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnInsertTest;
        private System.Windows.Forms.Button btnAutoMark;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnInsertClass;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}