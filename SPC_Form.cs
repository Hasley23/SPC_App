using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Parental_Control
{
    public partial class SimplePC : Form
    {
        TimeMatrix[] matrix;

        public SimplePC()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            matrix = new TimeMatrix[7];
            panel1.Location = new Point(panel1.Location.X, panel2.Location.Y * 2 + panel2.Size.Height);
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new TimeMatrix();
            }
            Label[] labels = new Label[24]; // Размер рейбла 32, 16
            
            /* Нужно иницивлизировать лейблы  
            foreach (Label l in labels) { 
                l = new Label();
            }
            */
            
            int margin = 35;
            foreach (TimeMatrix m in matrix)
            {
                m.Location = new Point(panel1.Location.X, margin);
                panel1.Controls.Add(m);
                margin += 35;
            }
        }

        private void SimplePC_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.Gray, ButtonBorderStyle.Solid);
            this.ActiveControl = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.DisplayRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }
    }
}
