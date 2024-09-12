namespace pgsql.Add
{
    partial class add_pass
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
            add_pass_time = new TextBox();
            add_pass_count = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            add_pass_place = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // add_pass_time
            // 
            add_pass_time.Location = new Point(81, 74);
            add_pass_time.Name = "add_pass_time";
            add_pass_time.Size = new Size(182, 23);
            add_pass_time.TabIndex = 2;
            // 
            // add_pass_count
            // 
            add_pass_count.Location = new Point(81, 162);
            add_pass_count.Name = "add_pass_count";
            add_pass_count.Size = new Size(182, 23);
            add_pass_count.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(81, 344);
            button1.Name = "button1";
            button1.Size = new Size(182, 23);
            button1.TabIndex = 6;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 12);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "Тип рейса";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 56);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 9;
            label3.Text = "Дата рейса";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 100);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Номер самолёта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 144);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 12;
            label6.Text = "Число пассажиров";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 23);
            comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(81, 118);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 23);
            comboBox2.TabIndex = 14;
            // 
            // add_pass_place
            // 
            add_pass_place.Location = new Point(81, 209);
            add_pass_place.Name = "add_pass_place";
            add_pass_place.Size = new Size(182, 23);
            add_pass_place.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 191);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 16;
            label2.Text = "Пункт (отправления/назначения)";
            // 
            // add_pass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 379);
            Controls.Add(label2);
            Controls.Add(add_pass_place);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(add_pass_count);
            Controls.Add(add_pass_time);
            Name = "add_pass";
            Text = "Добавить в пассажиропоток";
            Load += add_pass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox add_pass_time;
        private TextBox add_pass_count;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox add_pass_place;
        private Label label2;
    }
}