using MichaelHall.AdventureGame;
using MichaelHall.AdventureGame.Memory;

namespace MichaelHall.AdventureGame.WinHost
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            RefreshCharacters();
        }

        #region Event Handlers
        /// <summary>
        /// Spawns child form for creating new character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCharacter(object sender, EventArgs e)
        {
            var character = new Character();
            var dlg = new CharacterSheet(character);

            do
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                var error = _database.Add(dlg.Character);
                if (String.IsNullOrEmpty(error))
                    break;
                MessageBox.Show(this, error, "Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (true);

            RefreshCharacters();
        }

        /// <summary>
        /// spawns child form with data from selected character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditCharacter(object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;
            var dlg = new CharacterSheet(character);
            dlg.Character = character;

            do
            {
                if (dlg.ShowDialog(this) != DialogResult.OK)
                    return;

                var error = _database.Update(character.Id, dlg.Character);
                if (String.IsNullOrEmpty(error))
                    break;
                MessageBox.Show(this, error, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (true);
            RefreshCharacters();
        }

        /// <summary>
        /// Deletes selected character, prompts for user confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDeleteCharacter(object sender, EventArgs e)
        {
            var character = GetSelectedCharacter();
            if (character == null)
                return;

            var result = MessageBox.Show(this, $"Are you sure you want to delete {character.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _database.Delete(character.Id);
                RefreshCharacters();
            }
        }

        /// <summary>
        /// Closes program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFileExit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        /// <summary>
        /// Spawns about box form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHelpAbout(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }

        #endregion

        #region Private Members

        /// <summary>
        /// Passes selected data from _lstCharacters to the character sheet.
        /// </summary>
        /// <returns>selected character from main form list</returns>
        private Character GetSelectedCharacter()
        {
            return _lstCharacters.SelectedItem as Character;
        }

        /// <summary>
        /// Refreshes _listCharacters to show latest data
        /// </summary>
        private void RefreshCharacters()
        {
            var characters = _database.GetAll().ToList();
            _lstCharacters.DataSource = null;
            _lstCharacters.DataSource = characters;
        }

        /// <summary>
        /// Character list class instance
        /// </summary>
        private MemoryCharacterDatabase _database = new MemoryCharacterDatabase();

        /// <summary>
        /// Refreshes list of characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshCharacters(object sender, EventArgs e)
        {
            _lstCharacters.DataSource = null;

            var characters = _database.GetAll();
            _lstCharacters.DataSource = characters.ToList();
        }

        #endregion
    }
}