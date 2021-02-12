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

        public void tbTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private async void create_Click(object sender, EventArgs e)
        {
            var reponse = await APICall.Post(tbTitle.Text, tbArtist.Text);
            //ou je l'envoie ? envoie = APICall.formatJSON(reponse);
        }
    }
}
