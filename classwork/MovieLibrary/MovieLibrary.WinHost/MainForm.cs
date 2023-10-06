namespace MovieLibrary.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();
        }
        private Movie _movie;

        private void exitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Exit Not Implemented");
        }

        private void helpToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Help Not Implemented");
        }

        private void OnAddMovie ( object sender, EventArgs e )
        {
            MessageBox.Show("Add Not Implemented");
        }

        private void editToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Edit Not Implemented");
        }

        private void deleteToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            MessageBox.Show("Delete Not Implemented");
        }

        private void aboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }
    }
}