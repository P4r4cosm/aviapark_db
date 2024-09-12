namespace pgsql.Delete
{
    partial class del_pass
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
            label1 = new Label();
            label3 = new Label();
            del_pass_date = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            del_pass_place = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(90, 308);
            button1.Name = "button1";
            button1.Size = new Size(167, 23);
            button1.TabIndex = 0;
            button1.Text = "Удалить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Тип рейса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 64);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Дата рейса";
            // 
            // del_pass_date
            // 
            del_pass_date.Location = new Point(72, 82);
            del_pass_date.Name = "del_pass_date";
            del_pass_date.Size = new Size(206, 23);
            del_pass_date.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 108);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 4;
            label4.Text = "Номер самолёта";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 126);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(72, 38);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(206, 23);
            comboBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 152);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 15;
            label2.Text = "Пункт (назначения/отправления)";
            // 
            // del_pass_place
            // 
            del_pass_place.Location = new Point(72, 170);
            del_pass_place.Name = "del_pass_place";
            del_pass_place.Size = new Size(206, 23);
            del_pass_place.TabIndex = 16;
            // 
            // del_pass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 410);
            Controls.Add(del_pass_place);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(del_pass_date);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "del_pass";
            Text = "Удалить из пассажиропотока";
            Load += del_pass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label3;
        private TextBox del_pass_date;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label2;
        private TextBox del_pass_place;
    }
}