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
    public partial class wSimplePC : Form
    {
        TimeMatrix[] matrix;

        public wSimplePC()
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
            int posCtr = panel1.Location.X+68;
            for (int i = 0; i < labels.Length; i++) {
                labels[i]= new Label();
                labels[i].Size = new Size(32, 16);
                labels[i].Text = i.ToString().Length < 2  ?  "0"+ i.ToString() : i.ToString();
                labels[i].Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                labels[i].Location = new Point(posCtr, panel2.Location.Y);
                posCtr += 33;
                panel1.Controls.Add(labels[i]);
            }

            Label[] weekDays = new Label[24];

            int it = 0;
            int margin = 35;
            foreach (TimeMatrix m in matrix)
            {
                m.Location = new Point(panel1.Location.X+10, margin);
                //weekDays[it] = new Label();
                //weekDays[it].Size = new Size(32, 32);
                //weekDays[it].Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                //weekDays[it].Location = new Point(20, margin + 7);
                /*
                if (it == 0)
                    weekDays[it].Text = "ПН";
                else if (it == 1)
                    weekDays[it].Text = "ВТ";
                else if (it == 2)
                    weekDays[it].Text = "СР";
                else if (it == 3)
                    weekDays[it].Text = "ЧТ";
                else if (it == 4)
                    weekDays[it].Text = "ПТ";
                else if (it == 5)
                    weekDays[it].Text = "CБ";
                else
                    weekDays[it].Text = "ВС";
                */
                //panel1.Controls.Add(weekDays[it]);
                panel1.Controls.Add(m);
                margin += 35;
                it++;
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
