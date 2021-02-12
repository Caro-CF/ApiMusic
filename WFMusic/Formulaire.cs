using System;
using System.Windows.Forms;

namespace WFMusic
{
    public partial class Formulaire : UserControl
    {

        public Formulaire()
        {
            InitializeComponent();
            tbTitle.Text = "titre"; 
            tbArtist.Text = "Artist"; 
            tbReleaseDate.Text = "11022021"; 
            tbGenre.Text = "genre"; 
            tbPrice.Text = "price"; 
            tbRating.Text = "R";
            cbValidate.Checked = true;
        }

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArtist_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
