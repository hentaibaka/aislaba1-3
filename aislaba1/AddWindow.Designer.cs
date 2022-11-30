namespace aislaba1
{
    partial class AddWindow
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
            this.addform2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.specialitybox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fiobox = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addform2
            // 
            this.addform2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addform2.Location = new System.Drawing.Point(0, 206);
            this.addform2.Name = "addform2";
            this.addform2.Size = new System.Drawing.Size(262, 23);
            this.addform2.TabIndex = 10;
            this.addform2.Text = "Добавить";
            this.addform2.UseVisualStyleBackColor = true;
            this.addform2.Click += new System.EventHandler(this.addform2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupbox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 44);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Группа";
            // 
            // groupbox
            // 
            this.groupbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupbox.Location = new System.Drawing.Point(3, 16);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(256, 20);
            this.groupbox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.specialitybox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 44);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Специальность";
            // 
            // specialitybox
            // 
            this.specialitybox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialitybox.Location = new System.Drawing.Point(3, 16);
            this.specialitybox.Name = "specialitybox";
            this.specialitybox.Size = new System.Drawing.Size(256, 20);
            this.specialitybox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fiobox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ФИО";
            // 
            // fiobox
            // 
            this.fiobox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiobox.Location = new System.Drawing.Point(3, 16);
            this.fiobox.Name = "fiobox";
            this.fiobox.Size = new System.Drawing.Size(256, 20);
            this.fiobox.TabIndex = 3;
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 229);
            this.Controls.Add(this.addform2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddWindow";
            this.Text = "Form2";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addform2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox groupbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox specialitybox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fiobox;
    }
}