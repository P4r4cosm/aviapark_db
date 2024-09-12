namespace pgsql.Update
{
    partial class update_prib
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            update_prib_num = new TextBox();
            update_prib_time = new TextBox();
            update_prib_avia = new TextBox();
            update_prib_place = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(697, 535);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Location = new Point(807, 416);
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
            label1.Location = new Point(787, 56);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Номер самолёта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(787, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 3;
            label2.Text = "Время прибытия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(787, 144);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Авиакомпания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(787, 188);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 5;
            label4.Text = "Пункт отправления";
            // 
            // update_prib_num
            // 
            update_prib_num.Location = new Point(766, 74);
            update_prib_num.Name = "update_prib_num";
            update_prib_num.Size = new Size(172, 23);
            update_prib_num.TabIndex = 6;
            // 
            // update_prib_time
            // 
            update_prib_time.Location = new Point(766, 118);
            update_prib_time.Name = "update_prib_time";
            update_prib_time.Size = new Size(172, 23);
            update_prib_time.TabIndex = 7;
            // 
            // update_prib_avia
            // 
            update_prib_avia.Location = new Point(766, 162);
            update_prib_avia.Name = "update_prib_avia";
            update_prib_avia.Size = new Size(172, 23);
            update_prib_avia.TabIndex = 8;
            // 
            // update_prib_place
            // 
            update_prib_place.Location = new Point(766, 206);
            update_prib_place.Name = "update_prib_place";
            update_prib_place.Size = new Size(172, 23);
            update_prib_place.TabIndex = 9;
            // 
            // update_prib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 597);
            Controls.Add(update_prib_place);
            Controls.Add(update_prib_avia);
            Controls.Add(update_prib_time);
            Controls.Add(update_prib_num);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "update_prib";
            Text = "Изменить прибывающий рейс";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox update_prib_num;
        private TextBox update_prib_time;
        private TextBox update_prib_avia;
        private TextBox update_prib_place;
    }
}