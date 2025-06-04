using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalMovieLibrary
{
    public partial class frmFilmToevoegen : Form
    {
        public frmFilmToevoegen()
        {
            InitializeComponent();
        }

        private void frmFilmToevoegen_Load(object sender, EventArgs e)
        {
            //Comboboxen vullen
            cboGenre.Items.Add("Actie");
            cboGenre.Items.Add("Avontuur");
            cboGenre.Items.Add("Komedie");
            cboGenre.Items.Add("Drama");
            cboGenre.Items.Add("Horror");
            cboGenre.Items.Add("Sciencefiction (Sci-Fi)");
            cboGenre.Items.Add("Thriller");
            cboGenre.Items.Add("Romantiek");
            cboGenre.Items.Add("Animatie");
            cboGenre.Items.Add("Fantasy");
            cboGenre.Items.Add("Misdaad");
            cboGenre.Items.Add("Mysterie");
            cboGenre.Items.Add("Familie");
            cboGenre.Items.Add("Oorlog");
            cboGenre.Items.Add("Documentaire");
            cboGenre.Items.Add("Western");
            cboGenre.Items.Add("Musical");

            cboLocatie.Items.Add("Cinema");
            cboLocatie.Items.Add("Netflix");
            cboLocatie.Items.Add("Disney+");
            cboLocatie.Items.Add("Amazon Prime Video");
            cboLocatie.Items.Add("HBO Max");
            cboLocatie.Items.Add("Apple TV+");
            cboLocatie.Items.Add("YouTube");
            cboLocatie.Items.Add("DVD/Blu-ray");
            cboLocatie.Items.Add("Google TV");
            cboLocatie.Items.Add("Plex");

            //Titel grote instellen
            lblGegevens.Font = new Font(lblGegevens.Font.FontFamily, 12, FontStyle.Bold);
            lblReview.Font = new Font(lblReview.Font.FontFamily, 12, FontStyle.Bold);
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            var id = Guid.NewGuid();

            //Artikel (object) aanmaken
            FilmDictionary.FilmDic.Add(id, new Films
            {
                //Gegevens
                Titel = txtTitel.Text,
                Jaar = Convert.ToInt32(txtJaar.Text),
                Genre = cboGenre.SelectedItem.ToString(),
                Regisseur = txtRegisseur.Text,
                Duur = Convert.ToInt32(txtDuur.Text),
                Url = txtUrl.Text,
                PrijsFilm = txtPrijs.Text,
                Locatie = cboLocatie.SelectedItem.ToString(),
                Beschrijving = txtBeschrijving.Text,

                //Review
                Beoordeling = (int)nudBeoordeling.Value,
                Review = txtReview.Text,
                // TODO: Logica voor het toevoegen van afbeeldingen
            });

            //Wegschrijven naar bestand (json)
            FilmDictionary.SaveFilmsToFile();



        }
    }

}
