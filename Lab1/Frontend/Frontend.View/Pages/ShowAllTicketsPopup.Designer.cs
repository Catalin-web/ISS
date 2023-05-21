namespace Frontend.Views.Pages
{
    partial class ShowAllTicketsPopup
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
            ticketsGridView = new DataGridView();
            TICKETS = new Label();
            loadTableButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ticketsGridView).BeginInit();
            SuspendLayout();
            // 
            // ticketsGridView
            // 
            ticketsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ticketsGridView.Location = new Point(35, 32);
            ticketsGridView.Name = "ticketsGridView";
            ticketsGridView.RowHeadersWidth = 51;
            ticketsGridView.RowTemplate.Height = 29;
            ticketsGridView.Size = new Size(728, 339);
            ticketsGridView.TabIndex = 0;
            // 
            // TICKETS
            // 
            TICKETS.AutoSize = true;
            TICKETS.Location = new Point(366, 9);
            TICKETS.Name = "TICKETS";
            TICKETS.Size = new Size(63, 20);
            TICKETS.TabIndex = 1;
            TICKETS.Text = "TICKETS";
            // 
            // loadTableButton
            // 
            loadTableButton.Location = new Point(35, 386);
            loadTableButton.Name = "loadTableButton";
            loadTableButton.Size = new Size(728, 29);
            loadTableButton.TabIndex = 2;
            loadTableButton.Text = "Load Table";
            loadTableButton.UseVisualStyleBackColor = true;
            loadTableButton.Click += loadTableButton_Click;
            // 
            // ShowAllTicketsPopup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loadTableButton);
            Controls.Add(TICKETS);
            Controls.Add(ticketsGridView);
            Name = "ShowAllTicketsPopup";
            Text = "ShowAllTicketsPopup";
            ((System.ComponentModel.ISupportInitialize)ticketsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ticketsGridView;
        private Label TICKETS;
        private Button loadTableButton;
    }
}