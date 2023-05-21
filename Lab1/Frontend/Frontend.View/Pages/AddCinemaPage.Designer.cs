namespace Frontend.Views.Pages
{
    partial class AddCinemaPage
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
            locationText = new TextBox();
            totalNumberOfSeatsNumber = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addCinemaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)totalNumberOfSeatsNumber).BeginInit();
            SuspendLayout();
            // 
            // nameText
            // 
            nameText.Location = new Point(195, 24);
            nameText.Name = "nameText";
            nameText.Size = new Size(125, 27);
            nameText.TabIndex = 0;
            // 
            // locationText
            // 
            locationText.Location = new Point(195, 90);
            locationText.Name = "locationText";
            locationText.Size = new Size(125, 27);
            locationText.TabIndex = 1;
            // 
            // totalNumberOfSeatsNumber
            // 
            totalNumberOfSeatsNumber.Location = new Point(195, 57);
            totalNumberOfSeatsNumber.Name = "totalNumberOfSeatsNumber";
            totalNumberOfSeatsNumber.Size = new Size(125, 27);
            totalNumberOfSeatsNumber.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 59);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 4;
            label2.Text = "Total Number Of Seats:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // addCinemaButton
            // 
            addCinemaButton.Location = new Point(27, 134);
            addCinemaButton.Name = "addCinemaButton";
            addCinemaButton.Size = new Size(293, 29);
            addCinemaButton.TabIndex = 6;
            addCinemaButton.Text = "Add cinema";
            addCinemaButton.UseVisualStyleBackColor = true;
            addCinemaButton.Click += addCinemaButton_Click;
            // 
            // AddCinemaPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 198);
            Controls.Add(addCinemaButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(totalNumberOfSeatsNumber);
            Controls.Add(locationText);
            Controls.Add(nameText);
            Name = "AddCinemaPage";
            Text = "AddCinemaPage";
            ((System.ComponentModel.ISupportInitialize)totalNumberOfSeatsNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameText;
        private TextBox locationText;
        private NumericUpDown totalNumberOfSeatsNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addCinemaButton;
    }
}