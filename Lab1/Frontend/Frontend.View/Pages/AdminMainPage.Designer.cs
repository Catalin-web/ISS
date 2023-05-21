namespace Frontend.Views.Pages
{
    partial class AdminMainPage
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
            addCinemaButton = new Button();
            addMovieButton = new Button();
            addProjectionButton = new Button();
            deleteReservationsButton = new Button();
            SuspendLayout();
            // 
            // addCinemaButton
            // 
            addCinemaButton.Location = new Point(12, 12);
            addCinemaButton.Name = "addCinemaButton";
            addCinemaButton.Size = new Size(188, 29);
            addCinemaButton.TabIndex = 0;
            addCinemaButton.Text = "Add a cinema";
            addCinemaButton.UseVisualStyleBackColor = true;
            addCinemaButton.Click += addCinemaButton_Click;
            // 
            // addMovieButton
            // 
            addMovieButton.Location = new Point(12, 47);
            addMovieButton.Name = "addMovieButton";
            addMovieButton.Size = new Size(188, 29);
            addMovieButton.TabIndex = 1;
            addMovieButton.Text = "Add a movie";
            addMovieButton.UseVisualStyleBackColor = true;
            addMovieButton.Click += addMovieButton_Click;
            // 
            // addProjectionButton
            // 
            addProjectionButton.Location = new Point(12, 82);
            addProjectionButton.Name = "addProjectionButton";
            addProjectionButton.Size = new Size(188, 29);
            addProjectionButton.TabIndex = 2;
            addProjectionButton.Text = "Add a projection";
            addProjectionButton.UseVisualStyleBackColor = true;
            addProjectionButton.Click += addProjectionButton_Click;
            // 
            // deleteReservationsButton
            // 
            deleteReservationsButton.Location = new Point(12, 117);
            deleteReservationsButton.Name = "deleteReservationsButton";
            deleteReservationsButton.Size = new Size(188, 29);
            deleteReservationsButton.TabIndex = 3;
            deleteReservationsButton.Text = "Delete Reservations";
            deleteReservationsButton.UseVisualStyleBackColor = true;
            deleteReservationsButton.Click += deleteReservationsButton_Click;
            // 
            // AdminMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 163);
            Controls.Add(deleteReservationsButton);
            Controls.Add(addProjectionButton);
            Controls.Add(addMovieButton);
            Controls.Add(addCinemaButton);
            Name = "AdminMainPage";
            Text = "AdminMainPage";
            ResumeLayout(false);
        }

        #endregion

        private Button addCinemaButton;
        private Button addMovieButton;
        private Button addProjectionButton;
        private Button deleteReservationsButton;
    }
}