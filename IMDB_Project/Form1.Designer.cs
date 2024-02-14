namespace IMDB_Project
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_update_review = new System.Windows.Forms.Button();
            this.btn_delete_review = new System.Windows.Forms.Button();
            this.btn_add_review = new System.Windows.Forms.Button();
            this.btn_show_reviews = new System.Windows.Forms.Button();
            this.btn_show_movies = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_movies = new System.Windows.Forms.DataGridView();
            this.dgv_reviews = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.txt_search_movie = new System.Windows.Forms.TextBox();
            this.btn_search_movie = new System.Windows.Forms.Button();
            this.cmb_movies_test = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_update_review);
            this.panel1.Controls.Add(this.btn_delete_review);
            this.panel1.Controls.Add(this.btn_add_review);
            this.panel1.Controls.Add(this.btn_show_reviews);
            this.panel1.Controls.Add(this.btn_show_movies);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 131);
            this.panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Salmon;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Location = new System.Drawing.Point(1053, 60);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 59);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // btn_update_review
            // 
            this.btn_update_review.BackColor = System.Drawing.Color.Salmon;
            this.btn_update_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_update_review.Location = new System.Drawing.Point(845, 60);
            this.btn_update_review.Name = "btn_update_review";
            this.btn_update_review.Size = new System.Drawing.Size(204, 59);
            this.btn_update_review.TabIndex = 6;
            this.btn_update_review.Text = "Update Review";
            this.btn_update_review.UseVisualStyleBackColor = false;
            this.btn_update_review.Click += new System.EventHandler(this.btn_update_review_Click);
            // 
            // btn_delete_review
            // 
            this.btn_delete_review.BackColor = System.Drawing.Color.Salmon;
            this.btn_delete_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete_review.Location = new System.Drawing.Point(635, 59);
            this.btn_delete_review.Name = "btn_delete_review";
            this.btn_delete_review.Size = new System.Drawing.Size(204, 59);
            this.btn_delete_review.TabIndex = 5;
            this.btn_delete_review.Text = "Delete Review";
            this.btn_delete_review.UseVisualStyleBackColor = false;
            this.btn_delete_review.Click += new System.EventHandler(this.btn_delete_review_Click);
            // 
            // btn_add_review
            // 
            this.btn_add_review.BackColor = System.Drawing.Color.Salmon;
            this.btn_add_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_review.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_add_review.Location = new System.Drawing.Point(425, 59);
            this.btn_add_review.Name = "btn_add_review";
            this.btn_add_review.Size = new System.Drawing.Size(204, 59);
            this.btn_add_review.TabIndex = 4;
            this.btn_add_review.Text = "Add Review";
            this.btn_add_review.UseVisualStyleBackColor = false;
            this.btn_add_review.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_show_reviews
            // 
            this.btn_show_reviews.BackColor = System.Drawing.Color.Salmon;
            this.btn_show_reviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_reviews.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_reviews.Location = new System.Drawing.Point(215, 59);
            this.btn_show_reviews.Name = "btn_show_reviews";
            this.btn_show_reviews.Size = new System.Drawing.Size(204, 59);
            this.btn_show_reviews.TabIndex = 3;
            this.btn_show_reviews.Text = "Show Reviews";
            this.btn_show_reviews.UseVisualStyleBackColor = false;
            this.btn_show_reviews.Click += new System.EventHandler(this.btn_show_reviews_Click);
            // 
            // btn_show_movies
            // 
            this.btn_show_movies.BackColor = System.Drawing.Color.Salmon;
            this.btn_show_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_movies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_show_movies.Location = new System.Drawing.Point(5, 58);
            this.btn_show_movies.Name = "btn_show_movies";
            this.btn_show_movies.Size = new System.Drawing.Size(204, 59);
            this.btn_show_movies.TabIndex = 2;
            this.btn_show_movies.Text = "Show Movies";
            this.btn_show_movies.UseVisualStyleBackColor = false;
            this.btn_show_movies.Click += new System.EventHandler(this.btn_show_movies_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(518, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMDb";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_movies
            // 
            this.dgv_movies.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_movies.Location = new System.Drawing.Point(4, 184);
            this.dgv_movies.Name = "dgv_movies";
            this.dgv_movies.RowHeadersWidth = 51;
            this.dgv_movies.RowTemplate.Height = 24;
            this.dgv_movies.Size = new System.Drawing.Size(1153, 240);
            this.dgv_movies.TabIndex = 1;
            this.dgv_movies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_movies_CellContentClick);
            // 
            // dgv_reviews
            // 
            this.dgv_reviews.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dgv_reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reviews.Location = new System.Drawing.Point(4, 430);
            this.dgv_reviews.Name = "dgv_reviews";
            this.dgv_reviews.RowHeadersWidth = 51;
            this.dgv_reviews.RowTemplate.Height = 24;
            this.dgv_reviews.Size = new System.Drawing.Size(1153, 235);
            this.dgv_reviews.TabIndex = 2;
            this.dgv_reviews.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reviews_CellContentClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // txt_search_movie
            // 
            this.txt_search_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search_movie.Location = new System.Drawing.Point(949, 143);
            this.txt_search_movie.Name = "txt_search_movie";
            this.txt_search_movie.Size = new System.Drawing.Size(201, 34);
            this.txt_search_movie.TabIndex = 8;
            this.txt_search_movie.TextChanged += new System.EventHandler(this.txt_search_movie_TextChanged);
            // 
            // btn_search_movie
            // 
            this.btn_search_movie.BackColor = System.Drawing.Color.Salmon;
            this.btn_search_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_movie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search_movie.Location = new System.Drawing.Point(959, 142);
            this.btn_search_movie.Name = "btn_search_movie";
            this.btn_search_movie.Size = new System.Drawing.Size(193, 36);
            this.btn_search_movie.TabIndex = 9;
            this.btn_search_movie.Text = "Search movie";
            this.btn_search_movie.UseVisualStyleBackColor = false;
            this.btn_search_movie.Click += new System.EventHandler(this.btn_search_movie_Click);
            // 
            // cmb_movies_test
            // 
            this.cmb_movies_test.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_movies_test.FormattingEnabled = true;
            this.cmb_movies_test.Location = new System.Drawing.Point(4, 140);
            this.cmb_movies_test.Name = "cmb_movies_test";
            this.cmb_movies_test.Size = new System.Drawing.Size(720, 38);
            this.cmb_movies_test.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1162, 669);
            this.Controls.Add(this.cmb_movies_test);
            this.Controls.Add(this.btn_search_movie);
            this.Controls.Add(this.txt_search_movie);
            this.Controls.Add(this.dgv_reviews);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_movies);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_movies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show_movies;
        private System.Windows.Forms.DataGridView dgv_movies;
        private System.Windows.Forms.Button btn_add_review;
        private System.Windows.Forms.Button btn_show_reviews;
        private System.Windows.Forms.DataGridView dgv_reviews;
        private System.Windows.Forms.Button btn_delete_review;
        private System.Windows.Forms.Button btn_update_review;
        private System.Windows.Forms.Button btn_login;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txt_search_movie;
        private System.Windows.Forms.Button btn_search_movie;
        private System.Windows.Forms.ComboBox cmb_movies_test;
    }
}

