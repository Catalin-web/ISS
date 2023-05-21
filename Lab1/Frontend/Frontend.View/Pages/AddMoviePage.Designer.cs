namespace Frontend.Views.Pages
{
    partial class AddMoviePage
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
            nameText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            durationNumber = new NumericUpDown();
            addMovieButton = new Button();
            ((System.ComponentModel.ISupportInitialize)durationNumber).BeginInit();
            SuspendLayout();
            // 
            // nameText
            // 
            nameText.Location = new Point(102, 23);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 27);
            nameText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Duration:";
            // 
            // durationNumber
            // 
            durationNumber.Location = new Point(102, 68);
            durationNumber.Name = "durationNumber";
            durationNumber.Size = new Size(125, 27);
            durationNumber.TabIndex = 3;
            // 
            // addMovieButton
            // 
            addMovieButton.Location = new Point(26, 116);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(201, 29);
            addMovieButton.TabIndex = 4;
            addMovieButton.Text = "Add movie";
            addMovieButton.UseVisualStyleBackColor = true;
            addMovieButton.Click += addMovieButton_Click;
            // 
            // AddMoviePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 174);
            Controls.Add(addMovieButton);
            Controls.Add(durationNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameText);
            Name = "AddMoviePage";
            Text = "AddMoviePage";
            ((System.ComponentModel.ISupportInitialize)durationNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameText;
        private Label label1;
        private Label label2;
        private NumericUpDown durationNumber;
        private Button addMovieButton;
    }
}