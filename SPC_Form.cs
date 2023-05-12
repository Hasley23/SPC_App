using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;

namespace Simple_Parental_Control
{
    public partial class wSimplePC : Form
    {
        private TimeMatrix[] matrix;
        private ProcessStartInfo processStartInfo = new ProcessStartInfo();

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
            int posCtr = panel1.Location.X + 68;
            for (int i = 0; i < labels.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Size = new Size(32, 16);
                labels[i].Text = i.ToString().Length < 2 ? "0" + i.ToString() : i.ToString();
                labels[i].Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
                labels[i].Location = new Point(posCtr, panel2.Location.Y);
                posCtr += 33;
                panel1.Controls.Add(labels[i]);
            }

            int it = 0;
            int margin = 35;
            foreach (TimeMatrix m in matrix)
            {
                m.Location = new Point(panel1.Location.X + 10, margin);
                panel1.Controls.Add(m);
                margin += 35;
                it++;
            }
        }

        private void SimplePC_Load(object sender, EventArgs e)
        {
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
            {
                comboBoxUsers.Items.Add(envVar["Name"]);
            }
            comboBoxUsers.SelectedIndex = 0;
            processStartInfo = new ProcessStartInfo();
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

        private void setParentalControl_Click(object sender, EventArgs e)
        {

            string choosedUser = comboBoxUsers.Items[comboBoxUsers.SelectedIndex].ToString();

            setHiddenCommand(choosedUser);
        }

        private void setHiddenCommand(string user)
        {
            bool next = false;
            foreach (TimeMatrix tm in matrix)
                foreach (CheckBox ch in tm.chbox_list)
                    if (ch.Checked)
                        next = true;

            if (!next) {
                MessageBox.Show("Wrong input!");
                return;
            }

            processStartInfo.FileName = "cmd.exe";
            // change to hidden
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;

            // command constructor below
            bool Monday = false;
            bool Tuesday = false;
            bool Wednesday = false;
            bool Thursday = false;
            bool Friday = false;
            bool Saturday = false;
            bool Sunday = false;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].chbox_list.Count; j++)
                {
                    if (matrix[i].chbox_list[j].Checked) { 
                        switch (i) { 
                            case 0: Monday = true; break;
                            case 1: Tuesday = true; break;
                            case 2: Wednesday = true; break;
                            case 3: Thursday = true; break;
                            case 4: Friday = true; break;
                            case 5: Saturday = true; break;
                            case 6: Sunday = true; break;
                        }
                    }
                }
            }

            string command = @"/k net user " + user + " /time:";
            string time = "";
            if (Monday)
            {
                command += "M";
                foreach (CheckBox ch in matrix[0].chbox_list)
                {
                    if (ch.Checked)
                    {
                        time += matrix[0].chbox_list.IndexOf(ch).ToString() + ":00-";
                    }
                }
                time = time.Remove(time.Length-1);
                command += "," + time + ";";
            }
            time = "";
            if (Tuesday)
            {
                command += "T";
                foreach (CheckBox ch in matrix[0].chbox_list)
                {
                    if (ch.Checked)
                    {
                        time += matrix[1].chbox_list.IndexOf(ch).ToString() + ":00-";
                    }
                }
                time = time.Remove(time.Length - 1);
                command += "," + time + ";";
            }
            if (Wednesday) 
            { 
                command += "W";
                command += ",time;";
            }
            if (Thursday) 
            {
                command += "Th";
                command += ",time;";
            }
            if (Friday)
            {
                command += "F";
                command += ",time;";
            }
            if (Saturday)
            {
                command += "S";
                command += ",time;";
            }
            if (Sunday) 
            { 
                command += "Su";
                command += ",time;";
            }

            //MessageBox.Show(command);

            //cmd exec
            processStartInfo.Arguments = command;
            Process.Start(processStartInfo);
        }

        private void resetParentalControl_Click(object sender, EventArgs e)
        {
            string choosedUser = comboBoxUsers.Items[comboBoxUsers.SelectedIndex].ToString();
            
            resetHiddenCommand(choosedUser);
        }

        private void resetHiddenCommand(string user)
        {
            processStartInfo.FileName = "cmd.exe";
            // change to hidden
            processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
            processStartInfo.Arguments = @"/k net user " + user + " /time:all";
            Process.Start(processStartInfo);
            MessageBox.Show("Resetting time for " + user + " was successful!");
        }
    }
}
