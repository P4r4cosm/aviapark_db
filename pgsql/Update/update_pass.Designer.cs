namespace pgsql.Update
{
    partial class update_pass
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            update_pass_type = new TextBox();
            label2 = new Label();
            update_pass_count = new TextBox();
            update_pass_num = new TextBox();
            label3 = new Label();
            label4 = new Label();
            update_pass_time = new TextBox();
            label5 = new Label();
            update_pass_place = new TextBox();
            label6 = new Label();
            update_pass_avia = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(672, 474);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(788, 471);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(766, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Тип рейса";
            // 
            // update_pass_type
            // 
            update_pass_type.Location = new Point(749, 65);
            update_pass_type.Name = "update_pass_type";
            update_pass_type.Size = new Size(147, 23);
            update_pass_type.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(766, 91);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Кол-во пассажиров";
            // 
            // update_pass_count
            // 
            update_pass_count.Location = new Point(749, 109);
            update_pass_count.Name = "update_pass_count";
            update_pass_count.Size = new Size(147, 23);
            update_pass_count.TabIndex = 5;
            // 
            // update_pass_num
            // 
            update_pass_num.Location = new Point(749, 153);
            update_pass_num.Name = "update_pass_num";
            update_pass_num.Size = new Size(147, 23);
            update_pass_num.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(766, 135);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 7;
            label3.Text = "Номер самолёта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(766, 179);
            label4.Name = "label4";
            label4.Size = new Size(176, 15);
            label4.TabIndex = 8;
            label4.Text = "Время прибытия/отправления";
            // 
            // update_pass_time
            // 
            update_pass_time.Location = new Point(749, 197);
            update_pass_time.Name = "update_pass_time";
            update_pass_time.Size = new Size(147, 23);
            update_pass_time.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(766, 223);
            label5.Name = "label5";
            label5.Size = new Size(183, 15);
            label5.TabIndex = 10;
            label5.Text = "Пункт отправления/назначения";
            // 
            // update_pass_place
            // 
            update_pass_place.Location = new Point(749, 241);
            update_pass_place.Name = "update_pass_place";
            update_pass_place.Size = new Size(147, 23);
            update_pass_place.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(766, 267);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 12;
            label6.Text = "Авиакомпания";
            // 
            // update_pass_avia
            // 
            update_pass_avia.Location = new Point(749, 285);
            update_pass_avia.Name = "update_pass_avia";
            update_pass_avia.Size = new Size(147, 23);
            update_pass_avia.TabIndex = 13;
            // 
            // update_pass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 569);
            Controls.Add(update_pass_avia);
            Controls.Add(label6);
            Controls.Add(update_pass_place);
            Controls.Add(label5);
            Controls.Add(update_pass_time);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(update_pass_num);
            Controls.Add(update_pass_count);
            Controls.Add(label2);
            Controls.Add(update_pass_type);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "update_pass";
            Text = "Изменить рейс в пассажиропотоке";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private TextBox update_pass_type;
        private Label label2;
        private TextBox update_pass_count;
        private TextBox update_pass_num;
        private Label label3;
        private Label label4;
        private TextBox update_pass_time;
        private Label label5;
        private TextBox update_pass_place;
        private Label label6;
        private TextBox update_pass_avia;
    }
}