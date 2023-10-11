namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        private Movie _movie = new Movie() { Title = "Jaws" };

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpClick ( object sender, EventArgs e )
        {
        }

        private void OnAddMovie ( object sender, EventArgs e )
        {
            var dlg = new MovieForm();
            dlg.ShowDialog();
        }

        private void OnEditMovie ( object sender, EventArgs e )
        {
            MessageBox.Show("Edit Not Implemented");
        }

        private void OnDeleteMovie ( object sender, EventArgs e )
        {
            var movie = GetSelectedMovie();
            if (movie == null)
                return;

            if (!Confirm("Delete",$"Are you sure you want to delete '{movie.Title}'?"))
                return;
            //TODO Delete movie
            _movie = null;
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }
        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();
            about.ShowDialog(); //Shows a form to the user

        }

        private Movie GetSelectedMovie()
        {
            return _movie;
        }
        private bool Confirm(string title, string message)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }

}