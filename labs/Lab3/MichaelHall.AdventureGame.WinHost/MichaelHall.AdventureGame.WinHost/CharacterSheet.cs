using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichaelHall.AdventureGame.WinHost
{
    public partial class CharacterSheet : Form
    {
        /// <summary>
        /// Constructor for Character Sheet form.
        /// </summary>
        /// <param name="character"></param>
        public CharacterSheet(Character character)
        {
            InitializeComponent();

            Character = character; // Initialize the Character
            if (Character != null && Character.RaceOptions != null)
            {
                _cbRace.DataSource = Character.RaceOptions;
            }
            else
            {
                MessageBox.Show("Race Options failed to load.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (Character != null && Character.ProfessionOptions != null)
            {
                _cbProfession.DataSource = Character.ProfessionOptions;
            }
            else
            {
                MessageBox.Show("Profession Options failed to load.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Character Character { get; set; }

        /// <summary>
        /// Loads character data in when selecting edit instead of add
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Character != null)
            {
                Text = "Edit Character";

                _txtName.Text = Character.Name;
                _txtBiography.Text = Character.Biography;
                _txtStrength.Text = $"{Character.Strength}";
                _txtIntelligence.Text = $"{Character.Intelligence}";
                _txtCharisma.Text = $"{Character.Charisma}";
                _txtDexterity.Text = $"{Character.Dexterity}";
                _txtConstitution.Text = $"{Character.Constitution}";

                _cbRace.Text = Character.Race;
                _cbProfession.Text = Character.Profession;
            };

            ValidateChildren();
        }

        /// <summary>
        /// Saves data from character sheet after triggering validation 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSave(object sender, EventArgs e)
        {
            //Validate and abort if necessary
            if (!ValidateChildren())
            {
                return;
            };

            var button = sender as Button;

            var character = new Character();

            character.Name = _txtName.Text;
            character.Biography = _txtBiography.Text;
            character.Strength = GetInt32(_txtStrength, 50);
            character.Intelligence = GetInt32(_txtIntelligence, 50);
            character.Dexterity = GetInt32(_txtDexterity, 50);
            character.Constitution = GetInt32(_txtConstitution, 50);
            character.Charisma = GetInt32(_txtCharisma, 50);
            character.Race = _cbRace.Text;
            character.Profession = _cbProfession.Text;

            if (!character.TryValidate(out var error))
            {
                MessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.None;
                return;
            };

            Character = character;
            DialogResult = DialogResult.OK;
            Close();

        }

        /// <summary>
        /// Cancels character creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Formatting data for display
        /// </summary>
        /// <param name="control"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private int GetInt32(Control control, int defaultValue)
        {
            if (Int32.TryParse(control.Text, out var value))
                return value;

            return defaultValue;
        }

        #region Validation

        private void OnValidateName(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(_txtName.Text))
            {
                _errors.SetError(_txtName, "Name is required");
                e.Cancel = true;
            }
            else
            {
                _errors.SetError(_txtName, "");
            }
        }

        private void OnValidateStrength(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = GetInt32(_txtStrength, 50);
            if (value < 50)
            {
                _errors.SetError(_txtStrength, "Minimum Strength is 50");
            }
            else if (value > 100)
            {
                _errors.SetError(_txtStrength, "Maximum Strength is 100");
            }
            else
            {
                _errors.SetError(_txtStrength, "");
            }

        }

        private void OnValidateIntelligence(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = GetInt32(_txtIntelligence, 50);
            if (value < 50)
            {
                _errors.SetError(_txtIntelligence, "Minimum Strength is 50");
            }
            else if (value > 100)
            {
                _errors.SetError(_txtIntelligence, "Maximum Strength is 100");
            }
            else
            {
                _errors.SetError(_txtIntelligence, "");
            }

        }

        private void OnValidateConstitution(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = GetInt32(_txtConstitution, 50);
            if (value < 50)
            {
                _errors.SetError(_txtConstitution, "Minimum Strength is 50");
            }
            else if (value > 100)
            {
                _errors.SetError(_txtConstitution, "Maximum Strength is 100");
            }
            else
            {
                _errors.SetError(_txtConstitution, "");
            }

        }

        private void OnValidateDexterity(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = GetInt32(_txtDexterity, 50);
            if (value < 50)
            {
                _errors.SetError(_txtDexterity, "Minimum Strength is 50");
            }
            else if (value > 100)
            {
                _errors.SetError(_txtDexterity, "Maximum Strength is 100");
            }
            else
            {
                _errors.SetError(_txtDexterity, "");
            }

        }

        private void OnValidateCharisma(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = GetInt32(_txtCharisma, 50);
            if (value < 50)
            {
                _errors.SetError(_txtCharisma, "Minimum Strength is 50");
            }
            else if (value > 100)
            {
                _errors.SetError(_txtCharisma, "Maximum Strength is 100");
            }
            else
            {
                _errors.SetError(_txtCharisma, "");
            }

        }

        private void OnValidateRace(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(_cbRace.Text))
            {
                _errors.SetError(_cbRace, "Race is required");
                e.Cancel = true;
            }
            else
            {
                _errors.SetError(_cbRace, "");
            }
        }

        private void OnValidateProfession(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(_cbProfession.Text))
            {
                _errors.SetError(_cbProfession, "Race is required");
                e.Cancel = true;
            }
            else
            {
                _errors.SetError(_cbProfession, "");
            }
        }
        #endregion
    }

}
