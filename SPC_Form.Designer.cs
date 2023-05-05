namespace Simple_Parental_Control
{
    partial class SimplePC
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.hint_time);
            this.panel1.Location = new System.Drawing.Point(14, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 355);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // setParentalControl
            // 
            this.setParentalControl.Location = new System.Drawing.Point(1060, 120);
            this.setParentalControl.Name = "setParentalControl";
            this.setParentalControl.Size = new System.Drawing.Size(90, 40);
            this.setParentalControl.TabIndex = 1;
            this.setParentalControl.Text = "Apply";
            this.setParentalControl.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.setParentalControl);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 168);
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
            // SimplePC
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
            this.Name = "SimplePC";
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
    }
}

