namespace PersonalMovieLibrary
{
    public partial class frmHome : Form
    {
        public static Dictionary<Guid, Films> FilmDic = new Dictionary<Guid, Films>();

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            // Initialization logic can remain here if needed.
        }

        private void btnFilmToevoegen_Click(object sender, EventArgs e)
        {
            frmFilmToevoegen frmFilmToevoegen = new frmFilmToevoegen();
            frmFilmToevoegen.ShowDialog();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            
        }
    }
}
