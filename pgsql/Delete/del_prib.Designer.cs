namespace pgsql.Delete
{
    partial class del_prib
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
            label2 = new Label();
            del_prib_date = new TextBox();
            comboBox1 = new ComboBox();
            del_prib_place = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 244);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 0;
            button1.Text = "Удалить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Дата прибытия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Номер самолёта";
            // 
            // del_prib_date
            // 
            del_prib_date.Location = new Point(66, 58);
            del_prib_date.Name = "del_prib_date";
            del_prib_date.Size = new Size(176, 23);
            del_prib_date.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 23);
            comboBox1.TabIndex = 6;
            // 
            // del_prib_place
            // 
            del_prib_place.Location = new Point(66, 146);
            del_prib_place.Name = "del_prib_place";
            del_prib_place.Size = new Size(176, 23);
            del_prib_place.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 128);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 8;
            label3.Text = "Пункт отправления";
            // 
            // del_prib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 314);
            Controls.Add(label3);
            Controls.Add(del_prib_place);
            Controls.Add(comboBox1);
            Controls.Add(del_prib_date);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "del_prib";
            Text = "Удалить прибывающий рейс";
            Load += del_otpr_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox del_prib_date;
        private ComboBox comboBox1;
        private TextBox del_prib_place;
        private Label label3;
    }
}