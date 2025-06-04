using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalMovieLibrary
{
	public class Films
	{
		private string strTitel = string.Empty;
		public string Titel
		{
			get { return strTitel; }
			set { strTitel = value; }
		}

		private int intJaar;
		public int Jaar
		{
			get { return intJaar; }
			set { intJaar = value; }
		}

		private string strGenre = string.Empty;
		public string Genre
		{
			get { return strGenre; }
			set { strGenre = value; }
		}

		private string strRegisseur = string.Empty;
		public string Regisseur
		{
			get { return strRegisseur; }
			set { strRegisseur = value; }
		}

		private int intBeoordeling; // Beoordeling van 1 tot 10 uit een numirckicup-down
		public int Beoordeling
		{
			get { return intBeoordeling; }
			set { intBeoordeling = value; }
		}

		private string strReview = string.Empty;
		public string Review
		{
			get { return strReview; }
			set { strReview = value; }
		}

		private string strBeschrijving = string.Empty;
		public string Beschrijving
		{
			get { return strBeschrijving; }
			set { strBeschrijving = value; }
		}

		// TODO: Logica voor het toevoegen van afbeeldinge

		private int intDuur; // Duur in minuten
		public int Duur
		{
			get { return intDuur; }
			set { intDuur = value; }
		}

		private string strUrl = string.Empty; // URL van de film (bijv. IMDb)
		public string Url
		{
			get { return strUrl; }
			set { strUrl = value; }
		}

		private string Prijs = string.Empty; // Prijs van de film (indien van toepassing)
		public string PrijsFilm
		{
			get { return Prijs; }
			set { Prijs = value; }
        }

		private string strKijkLocatie = string.Empty; // Locatie waar de film bekeken kan worden (bijv. Netflix, Amazon Prime, Cinema etc.)
		public string Locatie
		{
			get { return strKijkLocatie; }
			set { strKijkLocatie = value; }
        }
    }
}
