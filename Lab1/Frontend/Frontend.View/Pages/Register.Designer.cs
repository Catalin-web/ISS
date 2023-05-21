namespace Frontend.Views.Pages
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            emailText = new TextBox();
            passwordText = new TextBox();
            registerButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 72);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 146);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 183);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 4;
            label5.Text = "Password:";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(115, 69);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(125, 27);
            firstNameText.TabIndex = 5;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(115, 110);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(125, 27);
            lastNameText.TabIndex = 6;
            // 
            // emailText
            // 
            emailText.Location = new Point(115, 146);
            emailText.Name = "emailText";
            emailText.Size = new Size(125, 27);
            emailText.TabIndex = 7;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(115, 180);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(125, 27);
            passwordText.TabIndex = 8;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(48, 263);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(192, 29);
            registerButton.TabIndex = 9;
            registerButton.Text = "Create Account";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_ClickAsync;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 323);
            Controls.Add(registerButton);
            Controls.Add(passwordText);
            Controls.Add(emailText);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox emailText;
        private TextBox passwordText;
        private Button registerButton;
    }
}