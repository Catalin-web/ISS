namespace Frontend.Views.Pages
{
    partial class BuyTicketPopup
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
            seatGridView = new DataGridView();
            reservateButton = new Button();
            label2 = new Label();
            addSeat = new Button();
            label1 = new Label();
            numberSelector = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)seatGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberSelector).BeginInit();
            SuspendLayout();
            // 
            // seatGridView
            // 
            seatGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seatGridView.Location = new Point(410, 60);
            seatGridView.Name = "seatGridView";
            seatGridView.RowHeadersWidth = 51;
            seatGridView.RowTemplate.Height = 29;
            seatGridView.Size = new Size(288, 158);
            seatGridView.TabIndex = 18;
            // 
            // reservateButton
            // 
            reservateButton.Location = new Point(47, 249);
            reservateButton.Name = "reservateButton";
            reservateButton.Size = new Size(651, 29);
            reservateButton.TabIndex = 17;
            reservateButton.Text = "BUY";
            reservateButton.UseVisualStyleBackColor = true;
            reservateButton.Click += buyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 37);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 16;
            label2.Text = "SEATS";
            // 
            // addSeat
            // 
            addSeat.Location = new Point(47, 154);
            addSeat.Name = "addSeat";
            addSeat.Size = new Size(255, 29);
            addSeat.TabIndex = 15;
            addSeat.Text = "Add a seat";
            addSeat.UseVisualStyleBackColor = true;
            addSeat.Click += addSeat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 96);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 14;
            label1.Text = "Seat Number:";
            // 
            // numberSelector
            // 
            numberSelector.Location = new Point(152, 94);
            numberSelector.Name = "numberSelector";
            numberSelector.Size = new Size(150, 27);
            numberSelector.TabIndex = 13;
            // 
            // BuyTicketPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 335);
            Controls.Add(seatGridView);
            Controls.Add(reservateButton);
            Controls.Add(label2);
            Controls.Add(addSeat);
            Controls.Add(label1);
            Controls.Add(numberSelector);
            Name = "BuyTicketPopup";
            Text = "BuyTicketPopup";
            ((System.ComponentModel.ISupportInitialize)seatGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberSelector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView seatGridView;
        private Button reservateButton;
        private Label label2;
        private Button addSeat;
        private Label label1;
        private NumericUpDown numberSelector;
    }
}