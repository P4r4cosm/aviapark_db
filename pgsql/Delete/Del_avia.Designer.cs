namespace pgsql.Delete
{
    partial class Del_avia
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
            label4 = new Label();
            del_avia_model = new TextBox();
            del_avia_cap = new TextBox();
            del_avia_num = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(88, 245);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Удалить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 35);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 79);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Номер самолёта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 123);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 4;
            label4.Text = "Вместимость";
            // 
            // del_avia_model
            // 
            del_avia_model.Location = new Point(58, 53);
            del_avia_model.Name = "del_avia_model";
            del_avia_model.Size = new Size(181, 23);
            del_avia_model.TabIndex = 5;
            // 
            // del_avia_cap
            // 
            del_avia_cap.Location = new Point(58, 141);
            del_avia_cap.Name = "del_avia_cap";
            del_avia_cap.Size = new Size(181, 23);
            del_avia_cap.TabIndex = 8;
            // 
            // del_avia_num
            // 
            del_avia_num.Location = new Point(58, 97);
            del_avia_num.Name = "del_avia_num";
            del_avia_num.Size = new Size(181, 23);
            del_avia_num.TabIndex = 6;
            // 
            // Del_avia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 308);
            Controls.Add(del_avia_cap);
            Controls.Add(del_avia_num);
            Controls.Add(del_avia_model);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Del_avia";
            Text = "Удалить самолёт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox del_avia_model;
        private TextBox del_avia_cap;
        private TextBox del_avia_num;
    }
}