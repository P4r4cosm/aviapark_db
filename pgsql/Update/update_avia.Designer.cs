namespace pgsql.Update
{
    partial class update_avia
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
            dataGridView1 = new DataGridView();
            update_avia_model = new TextBox();
            update_avia_cap = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            update_avia_num = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(685, 446);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 398);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // update_avia_model
            // 
            update_avia_model.Location = new Point(668, 85);
            update_avia_model.Name = "update_avia_model";
            update_avia_model.Size = new Size(174, 23);
            update_avia_model.TabIndex = 2;
            // 
            // update_avia_cap
            // 
            update_avia_cap.Location = new Point(668, 173);
            update_avia_cap.Name = "update_avia_cap";
            update_avia_cap.Size = new Size(174, 23);
            update_avia_cap.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 67);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(685, 111);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(685, 155);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "Вместимость";
            // 
            // update_avia_num
            // 
            update_avia_num.Location = new Point(668, 129);
            update_avia_num.Name = "update_avia_num";
            update_avia_num.Size = new Size(174, 23);
            update_avia_num.TabIndex = 3;
            // 
            // update_avia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 514);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(update_avia_cap);
            Controls.Add(update_avia_num);
            Controls.Add(update_avia_model);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "update_avia";
            Text = "Изменить самолёт";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox update_avia_model;
        private TextBox update_avia_cap;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox update_avia_num;
    }
}