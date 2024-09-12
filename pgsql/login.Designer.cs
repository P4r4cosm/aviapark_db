namespace pgsql
{
    partial class login
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
            Подключиться = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            login_address = new TextBox();
            login_port = new TextBox();
            login_base = new TextBox();
            login_name = new TextBox();
            login_password = new TextBox();
            SuspendLayout();
            // 
            // Подключиться
            // 
            Подключиться.Location = new Point(72, 381);
            Подключиться.Name = "Подключиться";
            Подключиться.Size = new Size(181, 23);
            Подключиться.TabIndex = 0;
            Подключиться.Text = "Подключиться";
            Подключиться.UseVisualStyleBackColor = true;
            Подключиться.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 51);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Адрес";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 95);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Порт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 139);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 3;
            label3.Text = "База данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 183);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 4;
            label4.Text = "Логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 227);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Пароль";
            // 
            // login_address
            // 
            login_address.Location = new Point(72, 69);
            login_address.Name = "login_address";
            login_address.PlaceholderText = "localhost";
            login_address.Size = new Size(181, 23);
            login_address.TabIndex = 7;
            login_address.Text = "localhost";
            // 
            // login_port
            // 
            login_port.Location = new Point(72, 113);
            login_port.Name = "login_port";
            login_port.PlaceholderText = "5432";
            login_port.Size = new Size(181, 23);
            login_port.TabIndex = 8;
            login_port.Text = "5432";
            // 
            // login_base
            // 
            login_base.Location = new Point(72, 157);
            login_base.Name = "login_base";
            login_base.PlaceholderText = "airport_bd";
            login_base.Size = new Size(181, 23);
            login_base.TabIndex = 9;
            login_base.Text = "airport_bd";
            // 
            // login_name
            // 
            login_name.Location = new Point(72, 201);
            login_name.Name = "login_name";
            login_name.PlaceholderText = "admin";
            login_name.Size = new Size(181, 23);
            login_name.TabIndex = 10;
            login_name.Text = "admin";
            // 
            // login_password
            // 
            login_password.Location = new Point(72, 245);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.PlaceholderText = "admin";
            login_password.Size = new Size(181, 23);
            login_password.TabIndex = 11;
            login_password.Text = "admin";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 450);
            Controls.Add(login_password);
            Controls.Add(login_name);
            Controls.Add(login_base);
            Controls.Add(login_port);
            Controls.Add(login_address);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Подключиться);
            Name = "login";
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Подключиться;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox login_address;
        private TextBox login_port;
        private TextBox login_base;
        private TextBox login_name;
        private TextBox login_password;
    }
}