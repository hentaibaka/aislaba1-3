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
    public partial class AddWindow : Form
    {
        MainWindow mainWindow;
        public AddWindow()
        {
            InitializeComponent();
        }
        public AddWindow(MainWindow f)
        {
            InitializeComponent();

            mainWindow = f;

            mainWindow.Enabled = false;
        }

        private void addform2_Click(object sender, EventArgs e)
        {
            if (mainWindow == null) return;

            if (fiobox.Text.Trim(' ') != "" && specialitybox.Text.Trim(' ') != "" && groupbox.Text.Trim(' ') != "")
            {
                mainWindow.logic.AddStudent(fiobox.Text.Trim(' '), specialitybox.Text.Trim(' '), groupbox.Text.Trim(' '));

                mainWindow.UpdateStudents();

                mainWindow.Enabled = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Пустые значения!");
            }            
        } 
    }
}
