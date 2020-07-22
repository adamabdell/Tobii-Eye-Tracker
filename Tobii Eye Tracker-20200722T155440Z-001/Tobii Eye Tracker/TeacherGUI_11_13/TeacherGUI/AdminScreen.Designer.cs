﻿namespace TeacherGUI
{
    partial class AdminScreen
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
            this.TeacherName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitClass = new System.Windows.Forms.Button();
            this.SubmitProfessor = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TeacherName
            // 
            this.TeacherName.Location = new System.Drawing.Point(99, 32);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(85, 20);
            this.TeacherName.TabIndex = 0;
            this.TeacherName.Text = "First Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Class Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Professor";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Class Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Class";
            // 
            // SubmitClass
            // 
            this.SubmitClass.Location = new System.Drawing.Point(311, 79);
            this.SubmitClass.Name = "SubmitClass";
            this.SubmitClass.Size = new System.Drawing.Size(75, 23);
            this.SubmitClass.TabIndex = 6;
            this.SubmitClass.Text = "Submit";
            this.SubmitClass.UseVisualStyleBackColor = true;
            this.SubmitClass.Click += new System.EventHandler(this.SubmitClass_Click);
            // 
            // SubmitProfessor
            // 
            this.SubmitProfessor.Location = new System.Drawing.Point(311, 34);
            this.SubmitProfessor.Name = "SubmitProfessor";
            this.SubmitProfessor.Size = new System.Drawing.Size(75, 23);
            this.SubmitProfessor.TabIndex = 7;
            this.SubmitProfessor.Text = "Submit";
            this.SubmitProfessor.UseVisualStyleBackColor = true;
            this.SubmitProfessor.Click += new System.EventHandler(this.SubmitProfessor_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(16, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 282);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "De",
            "Allan",
            "Zhang",
            "Master Chief"});
            this.comboBox1.Location = new System.Drawing.Point(12, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Professor";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 399);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SubmitProfessor);
            this.Controls.Add(this.SubmitClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TeacherName);
            this.Name = "AdminScreen";
            this.Text = "AdminScreen";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeacherName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitClass;
        private System.Windows.Forms.Button SubmitProfessor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}