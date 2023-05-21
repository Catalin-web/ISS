namespace Frontend.Views.Pages
{
    partial class ShowAllReservationsPopup
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
            loadTableButton = new Button();
            TICKETS = new Label();
            ticketsGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ticketsGridView).BeginInit();
            SuspendLayout();
            // 
            // loadTableButton
            // 
            loadTableButton.Location = new Point(36, 399);
            loadTableButton.Name = "loadTableButton";
            loadTableButton.Size = new Size(728, 29);
            loadTableButton.TabIndex = 5;
            loadTableButton.Text = "Load Table";
            loadTableButton.UseVisualStyleBackColor = true;
            loadTableButton.Click += loadTableButton_Click;
            // 
            // TICKETS
            // 
            TICKETS.AutoSize = true;
            TICKETS.Location = new Point(367, 22);
            TICKETS.Name = "TICKETS";
            TICKETS.Size = new Size(110, 20);
            TICKETS.TabIndex = 4;
            TICKETS.Text = "RESERVATIONS";
            // 
            // ticketsGridView
            // 
            ticketsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketsGridView.Location = new Point(36, 45);
            ticketsGridView.Name = "ticketsGridView";
            ticketsGridView.RowHeadersWidth = 51;
            ticketsGridView.RowTemplate.Height = 29;
            ticketsGridView.Size = new Size(728, 339);
            ticketsGridView.TabIndex = 3;
            // 
            // ShowAllReservationsPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 459);
            Controls.Add(loadTableButton);
            Controls.Add(TICKETS);
            Controls.Add(ticketsGridView);
            Name = "ShowAllReservationsPopup";
            Text = "ShowAllReservationsPopup";
            ((System.ComponentModel.ISupportInitialize)ticketsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadTableButton;
        private Label TICKETS;
        private DataGridView ticketsGridView;
    }
}