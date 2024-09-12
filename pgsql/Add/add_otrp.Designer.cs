namespace pgsql.Add
{
    partial class add_otrp
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
            add_otrp_time = new TextBox();
            add_otrp_place = new TextBox();
            add_otrp_avia = new TextBox();
            label1 = new Label();
            City = new Label();
            number = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(75, 264);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // add_otrp_time
            // 
            add_otrp_time.Location = new Point(49, 47);
            add_otrp_time.Name = "add_otrp_time";
            add_otrp_time.Size = new Size(174, 23);
            add_otrp_time.TabIndex = 1;
            // 
            // add_otrp_place
            // 
            add_otrp_place.Location = new Point(49, 91);
            add_otrp_place.Name = "add_otrp_place";
            add_otrp_place.Size = new Size(174, 23);
            add_otrp_place.TabIndex = 2;
            // 
            // add_otrp_avia
            // 
            add_otrp_avia.Location = new Point(49, 179);
            add_otrp_avia.Name = "add_otrp_avia";
            add_otrp_avia.Size = new Size(174, 23);
            add_otrp_avia.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 29);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 5;
            label1.Text = "Время отправления";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(66, 73);
            City.Name = "City";
            City.Size = new Size(107, 15);
            City.TabIndex = 6;
            City.Text = "Пункт назначения";
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(66, 117);
            number.Name = "number";
            number.Size = new Size(100, 15);
            number.TabIndex = 7;
            number.Text = "Номер самолёта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 161);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Авиакомпания";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(49, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 23);
            comboBox1.TabIndex = 9;
            // 
            // add_otrp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 309);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(number);
            Controls.Add(City);
            Controls.Add(label1);
            Controls.Add(add_otrp_avia);
            Controls.Add(add_otrp_place);
            Controls.Add(add_otrp_time);
            Controls.Add(button1);
            Name = "add_otrp";
            Text = "Добавить отправляющийся рейс";
            Load += add_otrp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox add_otrp_time;
        private TextBox add_otrp_place;
        private TextBox add_otrp_avia;
        private Label label1;
        private Label City;
        private Label number;
        private Label label4;
        private ComboBox comboBox1;
    }
}