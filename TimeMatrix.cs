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
    public partial class TimeMatrix : UserControl
    {
        public List<CheckBox> chbox_list;

        public TimeMatrix()
        {
            InitializeComponent();
            chbox_list = new List<CheckBox>();
            for (int i = 0; i < 24; i++) {
                chbox_list.Add(new CheckBox());
                chbox_list[i].Appearance = Appearance.Button;
                chbox_list[i].Size = new Size(32, 32);
                chbox_list[i].CheckStateChanged += checkBoxEvent;
            }
        }

        private void TimeMatrix_Load(object sender, EventArgs e)
        {
            int x = 55;
            for (int i = 0; i < 24; i++) {
                chbox_list[i].Location = new Point(x, 0);
                x += 33;
                this.Controls.Add(chbox_list[i]);
            }
        }

        private void checkBoxEvent(object sender, EventArgs e) {
            //this. = Color.Yellow;
        }
    }
}
