using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jthomson.Maze
{
    public partial class Form1 : Form
    {
        BufferedPanel displayPanel;
        Maze m;

        public Form1()
        {
            InitializeComponent();
            displayPanel = new BufferedPanel();
            displayPanel.Anchor = (
                    AnchorStyles.Top |
                    AnchorStyles.Bottom |
                    AnchorStyles.Left | 
                    AnchorStyles.Right
                );
            displayPanel.Location = new System.Drawing.Point(12, 84);
            displayPanel.Size = new System.Drawing.Size(504, 507);
            displayPanel.Paint += (sender, e) =>
                {
                    if (m != null)
                    {
                        m.Draw(e.Graphics, new Pen(Color.Black));
                    }
                };
            this.Controls.Add(displayPanel);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rows = trkRows.Value;
            int cols = trkCols.Value;
            m = new Maze(cols, rows);
            m.Generate();
            m.CellSize = 10;
            displayPanel.Invalidate();

        }
        
        private class BufferedPanel : Panel
        {
            public BufferedPanel(): base()
            {
                this.DoubleBuffered = true;
                this.ResizeRedraw = true;
            }
        }
    }
}
