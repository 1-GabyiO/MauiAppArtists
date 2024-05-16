using APIExamenMaui.Modules;

namespace APIExamenMaui
{
    public partial class MainPage : ContentPage
    {
        private string ApiUrl = "https://appcloudutnweb.azurewebsites.net/api/Artists";

        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdCreate_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artist>.Create(ApiUrl, new Artist
            {
                Id = 0,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Nationality= txtNationality.Text,
                BirthDate = txtBirthDay.Text
            });

            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
            }
        }

        private void cmdRead_Clicked(object sender, EventArgs e)
        {
            var resultado = ConsumeAPI.Crud<Artist>.Read_ById(ApiUrl, int.Parse(txtId.Text));
            if (resultado != null)
            {
                txtId.Text = resultado.Id.ToString();
                txtName.Text = resultado.Name;
                txtLastName.Text = resultado.LastName;
                txtNationality.Text = resultado.Nationality;
                txtBirthDay.Text = resultado.BirthDate; 
               
            }
        }

        private void cmdUpdate_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artist>.Update(ApiUrl, int.Parse(txtId.Text), new Artist
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                LastName = txtLastName.Text,
                Nationality= txtNationality.Text,
                BirthDate = txtBirthDay.Text
            });
        }

        private void cmdDelete_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artist>.Delete(ApiUrl, int.Parse(txtId.Text));
            txtLastName.Text = "";
            txtNationality.Text = "";
            txtBirthDay.Text = "";
            txtName.Text = "";
            txtId.Text = "";
        }

        private string ApiUrlArt = "https://appcloudutnweb.azurewebsites.net/api/Artworks";

        private void cmdDeleteArtw_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artwork>.Delete(ApiUrlArt, int.Parse(txtIdArt.Text));
            txtIdArt.Text = "";
            txtName.Text = "";
            txtPublicationYear.Text = "";
            txtTechnique.Text = "";
            txtDescription.Text = "";
        }

        private void cmdUpdateArtw_Clicked(object sender, EventArgs e)
        {
            ConsumeAPI.Crud<Artwork>.Update(ApiUrlArt, int.Parse(txtIdArt.Text), new Artwork
            {
                IdArt = int.Parse(txtIdArt.Text),
                Name = txtNameArtwork.Text,
                PublicationYear= txtPublicationYear.Text,
                Technique=txtPublicationYear.Text,
                Description=txtDescription.Text,
                Artistid = int.Parse(txtArtistid.Text)
            });
        }

        private void cmdReadArtw_Clicked(object sender, EventArgs e)
        {
            var prod = ConsumeAPI.Crud<Artwork>.Read_ById(ApiUrlArt, int.Parse(txtIdArt.Text));
            if (prod != null)
            {
                txtIdArt.Text = prod.IdArt.ToString();
                txtNameArtwork.Text = prod.Name;
                txtPublicationYear.Text = prod.PublicationYear;
                txtDescription.Text = prod.Description.ToString();
                txtTechnique.Text = prod.Technique.ToString();
                txtArtistid.Text = prod.Artistid.ToString();
            }
        }

        private void cmdCreateArtw_Clicked(object sender, EventArgs e)
        {
            var prod = ConsumeAPI.Crud<Artwork>.Create(ApiUrlArt, new Artwork
            {
                IdArt = 0,
                Name = txtNameArtwork.Text,
                PublicationYear = txtPublicationYear.Text,
                Technique = txtTechnique.Text,
                Description= txtDescription.Text,
                Artistid = int.Parse(txtArtistid.Text)
            });

            if (prod != null)
            {
                txtIdArt.Text = prod.IdArt.ToString();
            }
        }
    }
}

