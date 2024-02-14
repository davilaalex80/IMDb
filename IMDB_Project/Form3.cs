using IMDB_Project.Data;
using IMDB_Project.Entities;
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
    public partial class Form3 : Form
    {
        public Form3(int id_Review, string user, string movie, string rating, string description)
        {
            InitializeComponent();
            this.id_Review = id_Review;
            this.user = user;
            this.movie = movie;
            this.rating = rating;
            this.description = description;

        }

        int id_Review;
        string user;
        string movie;
        string rating;
        string description;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Load_Users()
        {
            D_Users Data = new D_Users();
            cmbUser.DataSource = Data.List_Users();
            cmbUser.ValueMember = "id_User";
            cmbUser.DisplayMember = "Name";
        }

        private void Load_Movies()
        {
            string Empty = "";
            D_Movies Data = new D_Movies();
            cmbMovie.DataSource = Data.List_Movies(Empty);
            cmbMovie.ValueMember = "id_movie";
            cmbMovie.DisplayMember = "Name";

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblReview.Text = Convert.ToString(this.id_Review);
            //cmbUser.SelectedValue = this.user;
            Console.WriteLine(this.user);
            cmbUser.SelectedText = this.user;
            cmbMovie.Text = this.movie;
            txtRating.Text = this.rating;
            txtDescription.Text = this.description;

            this.Load_Users();
            this.Load_Movies();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == string.Empty || txtRating.Text == string.Empty || cmbUser.Text == string.Empty)
            {
                MessageBox.Show("Falta ingresar datos requeridos (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else //Save review
            {
                string Rpta = "";
                E_Reviews oReviews = new E_Reviews();
                Console.WriteLine(cmbUser.ValueMember);
                Console.WriteLine(cmbUser.SelectedValue);
                Console.WriteLine(cmbMovie.SelectedValue);
                oReviews.Id_Users = Convert.ToInt32(this.cmbUser.SelectedValue);
                oReviews.id_Movie = Convert.ToInt32(this.cmbMovie.SelectedValue);
                oReviews.Rating = Convert.ToInt32(this.txtRating.Text);
                oReviews.Description = this.txtDescription.Text;

                D_Reviews dReviews = new D_Reviews();
                Rpta = dReviews.UpdateRow(this.id_Review, Convert.ToInt32(this.cmbUser.SelectedValue), Convert.ToInt32(this.cmbMovie.SelectedValue), Convert.ToInt32(this.txtRating.Text), this.txtDescription.Text);
                if (Rpta == "OK")
                {
                    MessageBox.Show("Los datos han sido guardados correctamente",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
