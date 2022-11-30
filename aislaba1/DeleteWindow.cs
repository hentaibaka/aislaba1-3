using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aislaba1
{
    public partial class DeleteWindow : Form
    {
        MainWindow mainWindow;
        public DeleteWindow()
        {
            InitializeComponent();
        }
        public DeleteWindow(MainWindow f)
        {
            InitializeComponent();

            mainWindow = f;

            mainWindow.Enabled = false;
        }

        private void deleteform3_Click(object sender, EventArgs e)
        {
            if (mainWindow == null) return;

            try
            {
                mainWindow.logic.DeleteStudent(Int32.Parse(idbox.Text.Trim(' ')));

                mainWindow.UpdateStudents();

                mainWindow.Enabled = true;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("неправильное значение");
            }
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainWindow != null) mainWindow.Enabled = true;
        }
    }
}

