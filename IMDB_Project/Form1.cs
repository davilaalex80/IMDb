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

        //dgv_movies
        private void dgv_movies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Select_Movie();
        }
        private void dgv_reviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //creo que es btn_add_review
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        private void List_movies(string cTexto)
        {
            D_Reviews datos = new D_Reviews();
            dgv_movies.DataSource = datos.List_Movies(cTexto);
        }

        private void List_reviews(int idMovie)
        {
            D_Reviews datos = new D_Reviews();
            dgv_movies.DataSource = datos.List_Reviews(idMovie);
        }

        private void Select_Movie()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_movies.CurrentRow.Cells["codigo_pr"].Value)))
            {
                MessageBox.Show("No se tiene información para Visualizar",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                //this.vCodigo_pr = Convert.ToInt32(dgv_movies.CurrentRow.Cells["codigo_pr"].Value);
                //txtDescripcion_pr.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_pr"].Value);
                //txtMarca_pr.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["marca_pr"].Value);
                //cmbMedidas.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_me"].Value);
                //cmbCategoria.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["descripcion_ca"].Value);
                //txtStockActual.Text = Convert.ToString(dgv_movies.CurrentRow.Cells["stock_actual"].Value);
            }
        }
        
    }
}
