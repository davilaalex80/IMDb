using IMDB_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int id_Movie = 0;
        int id_Review = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Buttons(bool lEstado)
        {
            btn_show_movies.Visible =   !lEstado;  
            btn_show_reviews.Visible =  !lEstado;
            btn_add_review.Visible =    !lEstado;
            btn_delete_review.Visible = !lEstado;
            btn_update_review.Visible = !lEstado;   
            dgv_movies.Enabled = lEstado;
            dgv_reviews.Enabled = lEstado;

        }

        //dgv_movies
        private void dgv_movies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Select_Movie();
        }
        private void dgv_reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //btn_add_review
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Buttons(false);
        }

        private void Format_movies()
        {
            dgv_movies.Columns[0].Width = 290;
            dgv_movies.Columns[0].HeaderText = "Movie name";
            dgv_movies.Columns[1].Width = 110;
            dgv_movies.Columns[1].HeaderText = "Genre";
            dgv_movies.Columns[2].Width = 110;
            dgv_movies.Columns[2].HeaderText = "Year movie released";
            dgv_movies.Columns[3].Width = 150;
            dgv_movies.Columns[3].HeaderText = "Director";
            dgv_movies.Columns[4].Width = 110;
            dgv_movies.Columns[4].HeaderText = "Movie length (min)";
            dgv_movies.Columns[5].Width = 25;
            dgv_movies.Columns[5].HeaderText = "ID";


        }
        private void Format_reviews()
        {
            dgv_reviews.Columns[0].Width = 190;
            dgv_reviews.Columns[0].HeaderText = "Movie name";
            dgv_reviews.Columns[1].Width = 50;
            dgv_reviews.Columns[1].HeaderText = "Rating";
            dgv_reviews.Columns[2].Width = 310;
            dgv_reviews.Columns[2].HeaderText = "Review";
            dgv_reviews.Columns[3].Width = 110;
            dgv_reviews.Columns[3].HeaderText = "Date";
            dgv_reviews.Columns[4].Width = 110;
            dgv_reviews.Columns[4].HeaderText = "User name";
            dgv_reviews.Columns[5].Width = 25;
            dgv_reviews.Columns[5].HeaderText = "ID";

        }
        
      
        private void Select_Movie()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_movies.CurrentRow.Cells["id_movie"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.id_Movie = Convert.ToInt32(dgv_movies.CurrentRow.Cells["id_movie"].Value);
                //Load_Reviews(this.id_Movie);
            }
        }

        private void Select_Review()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_reviews.CurrentRow.Cells["id_review"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                this.id_Review = Convert.ToInt32(dgv_reviews.CurrentRow.Cells["id_review"].Value);
            }
        }
        private void Load_Movies_table()
        {
            D_Movies Data = new D_Movies();
            dgv_movies.DataSource = Data.List_Movies_table();
            this.Format_movies();
        }
        private void Load_Reviews_table()
        {
            D_Reviews Data = new D_Reviews();
            dgv_reviews.DataSource = Data.List_Reviews_table();
            this.Format_reviews();
        }
        private void List_movies(string cTexto)
        {
            D_Movies datos = new D_Movies();
            dgv_movies.DataSource = datos.List_Movies(cTexto);
            this.Format_movies();
        }

        private void List_Reviews(int idMovie)
        {
            D_Reviews datos = new D_Reviews();
            dgv_movies.DataSource = datos.List_Reviews(idMovie);
            this.Format_reviews();
        }

        private void Form1_Load()
        {
            //this.Load_Movies();
            //this.Load_Reviews();
            //this.List_movies("%");
        }
        private void btn_search_movie_Click(object sender, EventArgs e)
        {
            this.List_movies(txt_search_movie.Text);
        }
        
        ///unnecessary, for now
        private void txt_search_movie_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_show_movies_Click(object sender, EventArgs e)
        {
            this.Load_Movies_table();
        }

        private void btn_delete_review_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            D_Reviews dReviews = new D_Reviews();
            Select_Review();
            Rpta = dReviews.DeleteRow(this.id_Review);
            if (Rpta == "OK")
            {
                MessageBox.Show("Se ha eliminado con exito el registro",
                                 "Aviso del Sistema",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
        }

        private void btn_show_reviews_Click(object sender, EventArgs e)
        {
            this.Load_Reviews_table();
        }

        private void btn_update_review_Click(object sender, EventArgs e)
        {
            Select_Review();
            Form3 form3 = new Form3(this.id_Review);
            form3.ShowDialog();
            this.Buttons(false);
        }
    }
}
