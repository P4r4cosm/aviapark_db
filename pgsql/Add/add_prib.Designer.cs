namespace pgsql.Add
{
    partial class add_prib
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
            Date = new TextBox();
            add_prib_avia = new TextBox();
            add_prib_place = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxAirplane = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(70, 263);
            button1.Name = "button1";
            button1.Size = new Size(148, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Date
            // 
            Date.Location = new Point(40, 58);
            Date.Name = "Date";
            Date.PlaceholderText = "\"2024-04-16 11:30:00\"";
            Date.Size = new Size(198, 23);
            Date.TabIndex = 1;
            // 
            // add_prib_avia
            // 
            add_prib_avia.Location = new Point(40, 146);
            add_prib_avia.Name = "add_prib_avia";
            add_prib_avia.Size = new Size(198, 23);
            add_prib_avia.TabIndex = 3;
            // 
            // add_prib_place
            // 
            add_prib_place.Location = new Point(40, 190);
            add_prib_place.Name = "add_prib_place";
            add_prib_place.Size = new Size(198, 23);
            add_prib_place.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 5;
            label1.Text = "Дата прибытия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 6;
            label2.Text = "Номер самолёта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 128);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Авиакомпания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 172);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 8;
            label4.Text = "Пункт отправления";
            // 
            // comboBoxAirplane
            // 
            comboBoxAirplane.FormattingEnabled = true;
            comboBoxAirplane.Location = new Point(40, 102);
            comboBoxAirplane.Name = "comboBoxAirplane";
            comboBoxAirplane.Size = new Size(198, 23);
            comboBoxAirplane.TabIndex = 9;
            // 
            // add_prib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 308);
            Controls.Add(comboBoxAirplane);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(add_prib_place);
            Controls.Add(add_prib_avia);
            Controls.Add(Date);
            Controls.Add(button1);
            Name = "add_prib";
            Text = "Добавить прибывающий";
            Load += add_prib_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Date;
        private TextBox add_prib_avia;
        private TextBox add_prib_place;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxAirplane;
    }
}