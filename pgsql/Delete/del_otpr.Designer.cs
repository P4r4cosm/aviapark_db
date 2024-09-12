namespace pgsql.Delete
{
    partial class del_otpr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            del_otrp_time = new TextBox();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            del_otrp_place = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(78, 269);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 0;
            button1.Text = "Удалить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // del_otrp_time
            // 
            del_otrp_time.Location = new Point(61, 46);
            del_otrp_time.Name = "del_otrp_time";
            del_otrp_time.Size = new Size(165, 23);
            del_otrp_time.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 5;
            label1.Text = "Время отправления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 72);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 7;
            label3.Text = "Номер самолёта";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(61, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 23);
            comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 116);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 12;
            label2.Text = "Пункт назначения";
            // 
            // del_otrp_place
            // 
            del_otrp_place.Location = new Point(61, 134);
            del_otrp_place.Name = "del_otrp_place";
            del_otrp_place.Size = new Size(165, 23);
            del_otrp_place.TabIndex = 13;
            // 
            // del_otpr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 304);
            Controls.Add(del_otrp_place);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(del_otrp_time);
            Controls.Add(button1);
            Name = "del_otpr";
            Text = "Удалить отправляющийся рейс";
            Load += del_otrp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox del_otrp_time;
        private TextBox del_otrp_num;
        private TextBox del_otrp_stat;
        private Label label1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox del_otrp_place;
    }
}