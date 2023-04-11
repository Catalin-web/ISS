namespace Aplicatie
{
    partial class ClientPage
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
            dataGridView2 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button4 = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(488, 37);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(35, 409);
            button2.Name = "button2";
            button2.Size = new Size(159, 29);
            button2.TabIndex = 2;
            button2.Text = "Rezerva bilet";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(488, 278);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 3;
            button1.Text = "Sterge Rezervare";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(597, 332);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(488, 339);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Nume Cinema";
            // 
            // button3
            // 
            button3.Location = new Point(488, 385);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Cauta";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 258);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 8;
            label2.Text = "Nume Cinema";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 251);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // button4
            // 
            button4.Location = new Point(35, 355);
            button4.Name = "button4";
            button4.Size = new Size(159, 29);
            button4.TabIndex = 9;
            button4.Text = "Cumpara bilet";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 302);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 11;
            label3.Text = "Numar bilete";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(144, 300);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // ClientPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "ClientPage";
            Text = "ClientPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Label label2;
        private TextBox textBox2;
        private Button button4;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}