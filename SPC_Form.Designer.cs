namespace Simple_Parental_Control
{
    partial class wSimplePC
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.setParentalControl = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hint_time = new System.Windows.Forms.Label();
            this.lMonday = new System.Windows.Forms.Label();
            this.lTuesday = new System.Windows.Forms.Label();
            this.lWednessday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lWednessday);
            this.panel1.Controls.Add(this.lTuesday);
            this.panel1.Controls.Add(this.lMonday);
            this.panel1.Controls.Add(this.hint_time);
            this.panel1.Location = new System.Drawing.Point(12, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 355);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // setParentalControl
            // 
            this.setParentalControl.Location = new System.Drawing.Point(1060, 120);
            this.setParentalControl.Name = "setParentalControl";
            this.setParentalControl.Size = new System.Drawing.Size(96, 40);
            this.setParentalControl.TabIndex = 1;
            this.setParentalControl.Text = "Apply";
            this.setParentalControl.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.setParentalControl);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 168);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // hint_time
            // 
            this.hint_time.AutoSize = true;
            this.hint_time.Location = new System.Drawing.Point(53, 15);
            this.hint_time.Name = "hint_time";
            this.hint_time.Size = new System.Drawing.Size(0, 16);
            this.hint_time.TabIndex = 0;
            // 
            // lMonday
            // 
            this.lMonday.AutoSize = true;
            this.lMonday.Location = new System.Drawing.Point(31, 55);
            this.lMonday.Name = "lMonday";
            this.lMonday.Size = new System.Drawing.Size(56, 16);
            this.lMonday.TabIndex = 1;
            this.lMonday.Text = "Monday";
            // 
            // lTuesday
            // 
            this.lTuesday.AutoSize = true;
            this.lTuesday.Location = new System.Drawing.Point(26, 97);
            this.lTuesday.Name = "lTuesday";
            this.lTuesday.Size = new System.Drawing.Size(61, 16);
            this.lTuesday.TabIndex = 2;
            this.lTuesday.Text = "Tuesday";
            // 
            // lWednessday
            // 
            this.lWednessday.AutoSize = true;
            this.lWednessday.Location = new System.Drawing.Point(6, 139);
            this.lWednessday.Name = "lWednessday";
            this.lWednessday.Size = new System.Drawing.Size(81, 16);
            this.lWednessday.TabIndex = 3;
            this.lWednessday.Text = "Wednesday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thursday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Friday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saturday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sunday";
            // 
            // wSimplePC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "wSimplePC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Parental Control (by UkeZebrano)";
            this.Load += new System.EventHandler(this.SimplePC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setParentalControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label hint_time;
        private System.Windows.Forms.Label lMonday;
        private System.Windows.Forms.Label lTuesday;
        private System.Windows.Forms.Label lWednessday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

