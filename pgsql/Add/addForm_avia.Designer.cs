namespace pgsql
{
    partial class addForm_avia
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
            model = new TextBox();
            tailNumber = new TextBox();
            capacity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // model
            // 
            model.Location = new Point(29, 59);
            model.Name = "model";
            model.Size = new Size(184, 23);
            model.TabIndex = 0;
            // 
            // tailNumber
            // 
            tailNumber.Location = new Point(29, 103);
            tailNumber.Name = "tailNumber";
            tailNumber.Size = new Size(184, 23);
            tailNumber.TabIndex = 1;
            // 
            // capacity
            // 
            capacity.Location = new Point(29, 147);
            capacity.Name = "capacity";
            capacity.Size = new Size(184, 23);
            capacity.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Модель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 85);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 5;
            label2.Text = "Номер самолёта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 129);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 7;
            label4.Text = "Вместимость";
            // 
            // button1
            // 
            button1.Location = new Point(48, 250);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 8;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addForm_avia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 303);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(capacity);
            Controls.Add(tailNumber);
            Controls.Add(model);
            Name = "addForm_avia";
            Text = "Добавить самолёт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox model;
        private TextBox tailNumber;
        private TextBox capacity;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button button1;
    }
}