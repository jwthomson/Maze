using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            int rows = trkRows.Value;
            int cols = trkCols.Value;
            Maze m = new Maze(cols, rows);
            m.Generate();
            m.CellSize = 10;
            pctDisplay.CreateGraphics().Clear(pctDisplay.BackColor);
            m.Draw(pctDisplay.CreateGraphics(), new Pen(Color.Black));
        }
    }
}
