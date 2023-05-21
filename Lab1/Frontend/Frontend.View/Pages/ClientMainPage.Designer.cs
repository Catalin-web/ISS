namespace Frontend.Views.Pages
{
    partial class ClientMainPage
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
            addCardButton = new Button();
            cinemaGridView = new DataGridView();
            movieGridView = new DataGridView();
            projectionGridView = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            searchCinema = new Button();
            searchMovies = new Button();
            searchProjections = new Button();
            cardGridView = new DataGridView();
            label4 = new Label();
            searchCards = new Button();
            showReservationButton = new Button();
            showAllTicketsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cinemaGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectionGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardGridView).BeginInit();
            SuspendLayout();
            // 
            // addCardButton
            // 
            addCardButton.Location = new Point(921, 45);
            addCardButton.Name = "addCardButton";
            addCardButton.Size = new Size(106, 29);
            addCardButton.TabIndex = 0;
            addCardButton.Text = "Add a card";
            addCardButton.UseVisualStyleBackColor = true;
            addCardButton.Click += addCardButton_Click;
            // 
            // cinemaGridView
            // 
            cinemaGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cinemaGridView.Location = new Point(27, 45);
            cinemaGridView.Name = "cinemaGridView";
            cinemaGridView.RowHeadersWidth = 51;
            cinemaGridView.RowTemplate.Height = 29;
            cinemaGridView.Size = new Size(300, 188);
            cinemaGridView.TabIndex = 1;
            // 
            // movieGridView
            // 
            movieGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movieGridView.Location = new Point(27, 278);
            movieGridView.Name = "movieGridView";
            movieGridView.RowHeadersWidth = 51;
            movieGridView.RowTemplate.Height = 29;
            movieGridView.Size = new Size(300, 188);
            movieGridView.TabIndex = 2;
            // 
            // projectionGridView
            // 
            projectionGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectionGridView.Location = new Point(386, 45);
            projectionGridView.Name = "projectionGridView";
            projectionGridView.RowHeadersWidth = 51;
            projectionGridView.RowTemplate.Height = 29;
            projectionGridView.Size = new Size(311, 421);
            projectionGridView.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(921, 118);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 4;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += bookButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(921, 189);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 5;
            button2.Text = "Buy";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buyButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "CINEMAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 255);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 7;
            label2.Text = "MOVIES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(490, 22);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 8;
            label3.Text = "PROJECTIONS";
            // 
            // searchCinema
            // 
            searchCinema.Location = new Point(747, 359);
            searchCinema.Name = "searchCinema";
            searchCinema.Size = new Size(163, 29);
            searchCinema.TabIndex = 9;
            searchCinema.Text = "Search Cinemas";
            searchCinema.UseVisualStyleBackColor = true;
            searchCinema.Click += searchCinema_Click;
            // 
            // searchMovies
            // 
            searchMovies.Location = new Point(747, 394);
            searchMovies.Name = "searchMovies";
            searchMovies.Size = new Size(163, 29);
            searchMovies.TabIndex = 10;
            searchMovies.Text = "Search Movies";
            searchMovies.UseVisualStyleBackColor = true;
            searchMovies.Click += searchMovies_Click;
            // 
            // searchProjections
            // 
            searchProjections.Location = new Point(747, 429);
            searchProjections.Name = "searchProjections";
            searchProjections.Size = new Size(163, 29);
            searchProjections.TabIndex = 11;
            searchProjections.Text = "Search Projections";
            searchProjections.UseVisualStyleBackColor = true;
            searchProjections.Click += searchProjections_Click;
            // 
            // cardGridView
            // 
            cardGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardGridView.Location = new Point(747, 45);
            cardGridView.Name = "cardGridView";
            cardGridView.RowHeadersWidth = 51;
            cardGridView.RowTemplate.Height = 29;
            cardGridView.Size = new Size(163, 173);
            cardGridView.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(799, 22);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "CARDS";
            // 
            // searchCards
            // 
            searchCards.Location = new Point(747, 224);
            searchCards.Name = "searchCards";
            searchCards.Size = new Size(163, 29);
            searchCards.TabIndex = 14;
            searchCards.Text = "Load my cards";
            searchCards.UseVisualStyleBackColor = true;
            searchCards.Click += searchCards_Click;
            // 
            // showReservationButton
            // 
            showReservationButton.Location = new Point(747, 289);
            showReservationButton.Name = "showReservationButton";
            showReservationButton.Size = new Size(163, 29);
            showReservationButton.TabIndex = 15;
            showReservationButton.Text = "Show all reservations";
            showReservationButton.UseVisualStyleBackColor = true;
            showReservationButton.Click += showReservationButton_Click;
            // 
            // showAllTicketsButton
            // 
            showAllTicketsButton.Location = new Point(747, 324);
            showAllTicketsButton.Name = "showAllTicketsButton";
            showAllTicketsButton.Size = new Size(163, 29);
            showAllTicketsButton.TabIndex = 16;
            showAllTicketsButton.Text = "Show all tickets";
            showAllTicketsButton.UseVisualStyleBackColor = true;
            showAllTicketsButton.Click += showAllTicketsButton_Click;
            // 
            // ClientMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 504);
            Controls.Add(showAllTicketsButton);
            Controls.Add(showReservationButton);
            Controls.Add(searchCards);
            Controls.Add(label4);
            Controls.Add(cardGridView);
            Controls.Add(searchProjections);
            Controls.Add(searchMovies);
            Controls.Add(searchCinema);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(projectionGridView);
            Controls.Add(movieGridView);
            Controls.Add(cinemaGridView);
            Controls.Add(addCardButton);
            Name = "ClientMainPage";
            Text = "ClientMainPage";
            ((System.ComponentModel.ISupportInitialize)cinemaGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectionGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCardButton;
        private DataGridView cinemaGridView;
        private DataGridView movieGridView;
        private DataGridView projectionGridView;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button searchCinema;
        private Button searchMovies;
        private Button searchProjections;
        private DataGridView cardGridView;
        private Label label4;
        private Button searchCards;
        private Button showReservationButton;
        private Button showAllTicketsButton;
    }
}