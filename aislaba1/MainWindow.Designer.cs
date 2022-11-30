namespace aislaba1
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.students = new System.Windows.Forms.DataGridView();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.delete = new System.Windows.Forms.Button();
            this.glist = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.students)).BeginInit();
            this.SuspendLayout();
            // 
            // students
            // 
            this.students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.students.Dock = System.Windows.Forms.DockStyle.Left;
            this.students.Location = new System.Drawing.Point(0, 0);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(384, 450);
            this.students.TabIndex = 0;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Left;
            this.zedGraph.Location = new System.Drawing.Point(384, 0);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(479, 450);
            this.zedGraph.TabIndex = 6;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(894, 54);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(111, 36);
            this.delete.TabIndex = 9;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // glist
            // 
            this.glist.Location = new System.Drawing.Point(894, 96);
            this.glist.Name = "glist";
            this.glist.Size = new System.Drawing.Size(111, 36);
            this.glist.TabIndex = 8;
            this.glist.Text = "Гистограмма";
            this.glist.UseVisualStyleBackColor = true;
            this.glist.Click += new System.EventHandler(this.glist_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(894, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(111, 36);
            this.Add.TabIndex = 7;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.glist);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.students);
            this.Name = "MainWindow";
            this.Text = "DecanatPro";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView students;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button glist;
        private System.Windows.Forms.Button Add;
    }
}

