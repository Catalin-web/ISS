namespace Frontend.Views.Pages
{
    partial class AddProjectionPage
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
            hourNumber = new NumericUpDown();
            minuteNumber = new NumericUpDown();
            dayNumber = new NumericUpDown();
            monthNumber = new NumericUpDown();
            yearNumber = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cinemaDataGrid = new DataGridView();
            label6 = new Label();
            movieDataGrid = new Label();
            moviesDataGrid = new DataGridView();
            loadCinemasButton = new Button();
            loadMoviesButton = new Button();
            addProjectionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)hourNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monthNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yearNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cinemaDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // hourNumber
            // 
            hourNumber.Location = new Point(87, 80);
            hourNumber.Name = "hourNumber";
            hourNumber.Size = new Size(150, 27);
            hourNumber.TabIndex = 0;
            // 
            // minuteNumber
            // 
            minuteNumber.Location = new Point(87, 47);
            minuteNumber.Name = "minuteNumber";
            minuteNumber.Size = new Size(150, 27);
            minuteNumber.TabIndex = 1;
            // 
            // dayNumber
            // 
            dayNumber.Location = new Point(87, 113);
            dayNumber.Name = "dayNumber";
            dayNumber.Size = new Size(150, 27);
            dayNumber.TabIndex = 2;
            // 
            // monthNumber
            // 
            monthNumber.Location = new Point(87, 146);
            monthNumber.Name = "monthNumber";
            monthNumber.Size = new Size(150, 27);
            monthNumber.TabIndex = 3;
            // 
            // yearNumber
            // 
            yearNumber.Location = new Point(87, 179);
            yearNumber.Name = "yearNumber";
            yearNumber.Size = new Size(150, 27);
            yearNumber.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 49);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 5;
            label1.Text = "Minute:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 82);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Hour:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 120);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 7;
            label3.Text = "Day:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 148);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 8;
            label4.Text = "Month:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 179);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 9;
            label5.Text = "Year:";
            // 
            // cinemaDataGrid
            // 
            cinemaDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cinemaDataGrid.Location = new Point(267, 47);
            cinemaDataGrid.Name = "cinemaDataGrid";
            cinemaDataGrid.RowHeadersWidth = 51;
            cinemaDataGrid.RowTemplate.Height = 29;
            cinemaDataGrid.Size = new Size(300, 389);
            cinemaDataGrid.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 24);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "CINEMAS";
            // 
            // movieDataGrid
            // 
            movieDataGrid.AutoSize = true;
            movieDataGrid.Location = new Point(738, 24);
            movieDataGrid.Name = "movieDataGrid";
            movieDataGrid.Size = new Size(62, 20);
            movieDataGrid.TabIndex = 12;
            movieDataGrid.Text = "MOVIES";
            // 
            // moviesDataGrid
            // 
            moviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            moviesDataGrid.Location = new Point(622, 47);
            moviesDataGrid.Name = "moviesDataGrid";
            moviesDataGrid.RowHeadersWidth = 51;
            moviesDataGrid.RowTemplate.Height = 29;
            moviesDataGrid.Size = new Size(300, 389);
            moviesDataGrid.TabIndex = 13;
            // 
            // loadCinemasButton
            // 
            loadCinemasButton.Location = new Point(26, 407);
            loadCinemasButton.Name = "loadCinemasButton";
            loadCinemasButton.Size = new Size(214, 29);
            loadCinemasButton.TabIndex = 14;
            loadCinemasButton.Text = "Load Cinemas";
            loadCinemasButton.UseVisualStyleBackColor = true;
            loadCinemasButton.Click += loadCinemasButton_Click;
            // 
            // loadMoviesButton
            // 
            loadMoviesButton.Location = new Point(26, 372);
            loadMoviesButton.Name = "loadMoviesButton";
            loadMoviesButton.Size = new Size(214, 29);
            loadMoviesButton.TabIndex = 15;
            loadMoviesButton.Text = "Load Movies";
            loadMoviesButton.UseVisualStyleBackColor = true;
            loadMoviesButton.Click += loadMoviesButton_Click;
            // 
            // addProjectionButton
            // 
            addProjectionButton.Location = new Point(23, 212);
            addProjectionButton.Name = "addProjectionButton";
            addProjectionButton.Size = new Size(214, 29);
            addProjectionButton.TabIndex = 16;
            addProjectionButton.Text = "Add Projection";
            addProjectionButton.UseVisualStyleBackColor = true;
            addProjectionButton.Click += addProjectionButton_Click;
            // 
            // AddProjectionPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 448);
            Controls.Add(addProjectionButton);
            Controls.Add(loadMoviesButton);
            Controls.Add(loadCinemasButton);
            Controls.Add(moviesDataGrid);
            Controls.Add(movieDataGrid);
            Controls.Add(label6);
            Controls.Add(cinemaDataGrid);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(yearNumber);
            Controls.Add(monthNumber);
            Controls.Add(dayNumber);
            Controls.Add(minuteNumber);
            Controls.Add(hourNumber);
            Name = "AddProjectionPage";
            Text = "AddProjectionPage";
            ((System.ComponentModel.ISupportInitialize)hourNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)monthNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)yearNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)cinemaDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)moviesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown hourNumber;
        private NumericUpDown minuteNumber;
        private NumericUpDown dayNumber;
        private NumericUpDown monthNumber;
        private NumericUpDown yearNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView cinemaDataGrid;
        private Label label6;
        private Label movieDataGrid;
        private DataGridView moviesDataGrid;
        private Button loadCinemasButton;
        private Button loadMoviesButton;
        private Button addProjectionButton;
    }
}