﻿namespace aislaba1
{
    partial class DeleteWindow
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
            this.deleteform3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteform3
            // 
            this.deleteform3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deleteform3.Location = new System.Drawing.Point(0, 53);
            this.deleteform3.Name = "deleteform3";
            this.deleteform3.Size = new System.Drawing.Size(233, 23);
            this.deleteform3.TabIndex = 6;
            this.deleteform3.Text = "удалить";
            this.deleteform3.UseVisualStyleBackColor = true;
            this.deleteform3.Click += new System.EventHandler(this.deleteform3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idbox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "id";
            // 
            // idbox
            // 
            this.idbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idbox.Location = new System.Drawing.Point(3, 16);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(227, 20);
            this.idbox.TabIndex = 3;
            // 
            // DeleteWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 76);
            this.Controls.Add(this.deleteform3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteWindow";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteform3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idbox;
    }
}