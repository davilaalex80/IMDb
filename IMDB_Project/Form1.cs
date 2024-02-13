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
            dgv_movies.Columns[0].Width = 100;
            dgv_movies.Columns[0].HeaderText = "Movie name";
            dgv_movies.Columns[1].Width = 210;
            dgv_movies.Columns[1].HeaderText = "Genre";
            dgv_movies.Columns[2].Width = 110;
            dgv_movies.Columns[2].HeaderText = "Year movie released";
            dgv_movies.Columns[3].Width = 110;
            dgv_movies.Columns[3].HeaderText = "Director";
            dgv_movies.Columns[4].Width = 110;
            dgv_movies.Columns[4].HeaderText = "Movie Length";
            dgv_movies.Columns[5].Visible = false;

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
                /*
                this.vCodigo_pr = Convert.ToInt32(dgv_movies.CurrentRow.Cells["codigo_pr"].Value);
                txtDescripcion_pr.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_pr"].Value);
                txtMarca_pr.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["marca_pr"].Value);
                cmbMedidas.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_me"].Value);
                cmbCategoria.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_ca"].Value);
                txtStockActual.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["stock_actual"].Value);
                */
            }
        }
        private void Load_Movies()
        {
            D_Movies Data = new D_Movies();
            //combox form2
            //cmb_movies.DataSource = Data.List_Movies();
        }
        private void Load_Reviews()
        {
            D_Reviews Data = new D_Reviews();

        }
        private void Form1_Load()
        {
            this.Load_Movies();
            this.Load_Reviews();
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
            this.Load_Movies();
        }
    }
}
