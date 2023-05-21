namespace Frontend.Views.Pages
{
    partial class DeleteReservationPage
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
            reservationDataGrid = new DataGridView();
            loadReservationButton = new Button();
            deleteSelectedReservationButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)reservationDataGrid).BeginInit();
            SuspendLayout();
            // 
            // reservationDataGrid
            // 
            reservationDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reservationDataGrid.Location = new Point(42, 40);
            reservationDataGrid.Name = "reservationDataGrid";
            reservationDataGrid.RowHeadersWidth = 51;
            reservationDataGrid.RowTemplate.Height = 29;
            reservationDataGrid.Size = new Size(710, 377);
            reservationDataGrid.TabIndex = 0;
            // 
            // loadReservationButton
            // 
            loadReservationButton.Location = new Point(42, 423);
            loadReservationButton.Name = "loadReservationButton";
            loadReservationButton.Size = new Size(710, 29);
            loadReservationButton.TabIndex = 1;
            loadReservationButton.Text = "Load All Reservations";
            loadReservationButton.UseVisualStyleBackColor = true;
            loadReservationButton.Click += loadReservationButton_Click;
            // 
            // deleteSelectedReservationButton
            // 
            deleteSelectedReservationButton.Location = new Point(42, 458);
            deleteSelectedReservationButton.Name = "deleteSelectedReservationButton";
            deleteSelectedReservationButton.Size = new Size(710, 29);
            deleteSelectedReservationButton.TabIndex = 2;
            deleteSelectedReservationButton.Text = "Delete selected Reservation";
            deleteSelectedReservationButton.UseVisualStyleBackColor = true;
            deleteSelectedReservationButton.Click += deleteSelectedReservationButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 17);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 3;
            label1.Text = "ALL RESERVATIONS";
            // 
            // DeleteReservationPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 504);
            Controls.Add(label1);
            Controls.Add(deleteSelectedReservationButton);
            Controls.Add(loadReservationButton);
            Controls.Add(reservationDataGrid);
            Name = "DeleteReservationPage";
            Text = "DeleteReservationPage";
            ((System.ComponentModel.ISupportInitialize)reservationDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView reservationDataGrid;
        private Button loadReservationButton;
        private Button deleteSelectedReservationButton;
        private Label label1;
    }
}