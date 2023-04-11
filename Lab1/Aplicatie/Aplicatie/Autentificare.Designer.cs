namespace Aplicatie
{
    partial class Autentificare
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
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(349, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Autentificare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(488, 118);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 8;
            label2.Text = "Parola";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 118);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 7;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(544, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 184);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Nume";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 181);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 13;
            label4.Text = "Prenume";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(544, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // Autentificare
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Autentificare";
            Text = "Autentificare";
            Load += Autentificare_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}