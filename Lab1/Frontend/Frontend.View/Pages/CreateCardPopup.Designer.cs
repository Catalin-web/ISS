namespace Frontend.Views.Pages
{
    partial class CreateCardPopup
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
            numberText = new TextBox();
            seriesText = new TextBox();
            cvvText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addCardButton = new Button();
            SuspendLayout();
            // 
            // numberText
            // 
            numberText.Location = new Point(117, 33);
            numberText.Name = "numberText";
            numberText.Size = new Size(125, 27);
            numberText.TabIndex = 0;
            // 
            // seriesText
            // 
            seriesText.Location = new Point(117, 66);
            seriesText.Name = "seriesText";
            seriesText.Size = new Size(125, 27);
            seriesText.TabIndex = 1;
            // 
            // cvvText
            // 
            cvvText.Location = new Point(117, 99);
            cvvText.Name = "cvvText";
            cvvText.Size = new Size(125, 27);
            cvvText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 4;
            label2.Text = "Series:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 99);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 5;
            label3.Text = "Cvv:";
            // 
            // addCardButton
            // 
            addCardButton.Location = new Point(45, 167);
            addCardButton.Name = "addCardButton";
            addCardButton.Size = new Size(197, 29);
            addCardButton.TabIndex = 6;
            addCardButton.Text = "Add card";
            addCardButton.UseVisualStyleBackColor = true;
            addCardButton.Click += addCardButton_Click;
            // 
            // CreateCardPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 254);
            Controls.Add(addCardButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cvvText);
            Controls.Add(seriesText);
            Controls.Add(numberText);
            Name = "CreateCardPopup";
            Text = "CreateCardPopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberText;
        private TextBox seriesText;
        private TextBox cvvText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addCardButton;
    }
}