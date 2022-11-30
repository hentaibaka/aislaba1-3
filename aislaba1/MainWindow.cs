using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLib;
using Ninject;
using ZedGraph;

namespace aislaba1
{
    public partial class MainWindow : Form
    {
        public Logic logic;
        public BindingList<StudentsRow> StudentsList;
        public MainWindow()
        {
            InitializeComponent();

            IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
            logic = ninjectKernel.Get<Logic>();

            StudentsList = new BindingList<StudentsRow>();
        }
        public void UpdateStudents()
        {
            string[,] s = logic.GetStudents();

            StudentsList.Clear();

            for (int i = 0; i < s.GetLength(0); i++)
            {
                StudentsList.Add(new StudentsRow(s[i, 0], s[i, 1], s[i, 2], s[i, 3]));
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            students.ReadOnly = true;

            students.DataSource = StudentsList;

            UpdateStudents();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddWindow AddForm = new AddWindow(this);
            AddForm.Show();
        }

        private void glist_Click(object sender, EventArgs e)
        {
            GraphPane pane = zedGraph.GraphPane;

            pane.CurveList.Clear();

            string[,] s = logic.GetStat();

            int itemscount = s.GetLength(0);

            string[] names = new string[itemscount];
            double[] values = new double[itemscount];

            for (int i = 0; i < itemscount; i++)
            {
                names[i] = s[i, 0];
                values[i] = Int32.Parse(s[i, 1]);
            }

            BarItem curve = pane.AddBar("Студенты", null, values, Color.Blue);

            pane.XAxis.Type = AxisType.Text;
            pane.XAxis.Scale.TextLabels = names;

            pane.YAxis.Scale.MajorStep = 1;
            pane.YAxis.Scale.MinorStep = 1;

            zedGraph.AxisChange();

            zedGraph.Invalidate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteWindow delForm = new DeleteWindow(this);
            delForm.Show();
        }
    }
}
