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
    public partial class Form3 : Form
    {
        public Form3(int id_Review)
        {
            InitializeComponent();
            this.id_Review = id_Review;
        }

        int id_Review;

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
            this.Load_Users();
            this.Load_Movies();
        }

    }
}
