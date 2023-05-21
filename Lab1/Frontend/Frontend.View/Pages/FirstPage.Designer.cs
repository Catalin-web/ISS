namespace Frontend.Views.Pages
{
    partial class FirstPage
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
            register = new Button();
            login = new Button();
            SuspendLayout();
            // 
            // register
            // 
            register.Location = new Point(26, 12);
            register.Name = "register";
            register.Size = new Size(94, 29);
            register.TabIndex = 0;
            register.Text = "Login";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // login
            // 
            login.Location = new Point(26, 57);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 1;
            login.Text = "Register";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // FirstPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(148, 115);
            Controls.Add(login);
            Controls.Add(register);
            Name = "FirstPage";
            Text = "FirstPage";
            ResumeLayout(false);
        }

        #endregion

        private Button register;
        private Button login;
    }
}