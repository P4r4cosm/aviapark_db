namespace pgsql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button4 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            airplaneBox = new ComboBox();
            button6 = new Button();
            textBox1 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            textBox2 = new TextBox();
            button11 = new Button();
            textBox3 = new TextBox();
            button13 = new Button();
            textBox5 = new TextBox();
            button14 = new Button();
            textBox6 = new TextBox();
            button15 = new Button();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            button12 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(959, 541);
            dataGridView1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(986, 51);
            button4.Name = "button4";
            button4.Size = new Size(194, 54);
            button4.TabIndex = 5;
            button4.Text = "Вывести всю информацию о пассажиропотоке включая классы авиации";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(986, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Text = "Вывести таблицу";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 12);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 23);
            comboBox2.TabIndex = 10;
            comboBox2.Text = "Добавить запись в таблицу";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(217, 12);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 23);
            comboBox3.TabIndex = 11;
            comboBox3.Text = "Удалить запись в таблице";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(447, 12);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(214, 23);
            comboBox4.TabIndex = 12;
            comboBox4.Text = "Обновить запись в таблице";
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(1186, 51);
            button1.Name = "button1";
            button1.Size = new Size(195, 41);
            button1.TabIndex = 13;
            button1.Text = "Анализ загруженности рейсов";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1186, 98);
            button2.Name = "button2";
            button2.Size = new Size(195, 39);
            button2.TabIndex = 14;
            button2.Text = "Пассажиропоток по авиакомпаниям";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1187, 189);
            button3.Name = "button3";
            button3.Size = new Size(194, 39);
            button3.TabIndex = 15;
            button3.Text = "Среднее кол-во пассажиров на рейсах";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1186, 143);
            button5.Name = "button5";
            button5.Size = new Size(195, 40);
            button5.TabIndex = 16;
            button5.Text = "Кол-во рейсов у каждой авиакомпании";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // airplaneBox
            // 
            airplaneBox.FormattingEnabled = true;
            airplaneBox.Location = new Point(986, 143);
            airplaneBox.Name = "airplaneBox";
            airplaneBox.Size = new Size(194, 23);
            airplaneBox.TabIndex = 17;
            airplaneBox.Text = "Узнать все рейсы конкретного самолёта";
            airplaneBox.SelectedIndexChanged += airplaneBox_SelectedIndexChanged;
            // 
            // button6
            // 
            button6.Location = new Point(986, 172);
            button6.Name = "button6";
            button6.Size = new Size(194, 54);
            button6.TabIndex = 18;
            button6.Text = "Вывести рейсы с кол-вом пассажиров больше введённого";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(986, 232);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите кол-во пассажиров";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 19;
            // 
            // button7
            // 
            button7.Location = new Point(1186, 234);
            button7.Name = "button7";
            button7.Size = new Size(194, 41);
            button7.TabIndex = 20;
            button7.Text = "Рейсы с информацией о средней загрузке самолёта";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1186, 281);
            button8.Name = "button8";
            button8.Size = new Size(194, 47);
            button8.TabIndex = 21;
            button8.Text = "Загрузка самолётов выше средней";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(986, 261);
            button9.Name = "button9";
            button9.Size = new Size(194, 53);
            button9.TabIndex = 22;
            button9.Text = "Среднее количество пассажиров на рейс в каждый день недели";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(986, 320);
            button10.Name = "button10";
            button10.Size = new Size(194, 61);
            button10.TabIndex = 23;
            button10.Text = "Вывести компании у которых кол-во рейсов не меньше значения:";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(986, 387);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введите кол-во рейсов";
            textBox2.Size = new Size(194, 23);
            textBox2.TabIndex = 24;
            // 
            // button11
            // 
            button11.Location = new Point(1186, 334);
            button11.Name = "button11";
            button11.Size = new Size(194, 58);
            button11.TabIndex = 25;
            button11.Text = "Рейсы, для которых количество пассажиров больше, чем для любого рейса авиакомпании";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1186, 398);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите авиакомпанию";
            textBox3.Size = new Size(193, 23);
            textBox3.TabIndex = 26;
            // 
            // button13
            // 
            button13.Location = new Point(986, 416);
            button13.Name = "button13";
            button13.Size = new Size(194, 38);
            button13.TabIndex = 29;
            button13.Text = "Вывести все рейсы за день";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(986, 460);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "2024-05-30";
            textBox5.Size = new Size(194, 23);
            textBox5.TabIndex = 30;
            // 
            // button14
            // 
            button14.Location = new Point(986, 489);
            button14.Name = "button14";
            button14.Size = new Size(195, 28);
            button14.TabIndex = 31;
            button14.Text = "Рейсы прибывающие из города";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(986, 523);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Город";
            textBox6.Size = new Size(194, 23);
            textBox6.TabIndex = 32;
            // 
            // button15
            // 
            button15.Location = new Point(1186, 427);
            button15.Name = "button15";
            button15.Size = new Size(195, 23);
            button15.TabIndex = 33;
            button15.Text = "Рейсы вылетающие в город";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1186, 456);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Город";
            textBox7.Size = new Size(195, 23);
            textBox7.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1186, 549);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Введите авиакомпанию";
            textBox4.Size = new Size(195, 23);
            textBox4.TabIndex = 35;
            // 
            // button12
            // 
            button12.Location = new Point(1186, 485);
            button12.Name = "button12";
            button12.Size = new Size(195, 58);
            button12.TabIndex = 36;
            button12.Text = "Рейсы, у которых количество пассажиров меньше, чем для всех рейсов авиакомпании";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 615);
            Controls.Add(button12);
            Controls.Add(textBox4);
            Controls.Add(textBox7);
            Controls.Add(button15);
            Controls.Add(textBox6);
            Controls.Add(button14);
            Controls.Add(textBox5);
            Controls.Add(button13);
            Controls.Add(textBox3);
            Controls.Add(button11);
            Controls.Add(textBox2);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(airplaneBox);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "База данных";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private ComboBox airplaneBox;
        private Button button6;
        private TextBox textBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private TextBox textBox2;
        private Button button11;
        private TextBox textBox3;
        private Button button13;
        private TextBox textBox5;
        private Button button14;
        private TextBox textBox6;
        private Button button15;
        private TextBox textBox7;
        private TextBox textBox4;
        private Button button12;
    }
}
