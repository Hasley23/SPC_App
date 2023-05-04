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
        public SimplePC()
        {
            InitializeComponent();
        }

        private void SimplePC_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
