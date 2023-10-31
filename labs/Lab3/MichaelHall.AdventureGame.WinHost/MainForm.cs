namespace MichaelHall.AdventureGame.WinHost
{


    //TODO: Story 1 - Ensure Character Class is good to go
    //TODO: Story 2 - Set up accelerator keys for menu items
    //TODO: Story 3 - Character list to main form
    //TODO: Story 3 - Refresh method for main form when character list changes (Code sample in instructions)
    //TODO: Story 3 - Method to get selected character. SelectedItem property should assist 
    //TODO: Story 3 - ListBox ControlLinks to an external site. Book has instructions on this

    //TODO: Story 4 - All Combobox ControlLinks to an external site. Book for info
    //TODO Story 4 - Implement save button functions. Instructions for details
    //TODO Story 4 - Implement cancel button functions. Instructions for details
    //TODO Story 5 - Add Edit menu functionality. Instructions for details
    //TODO Story 5 - Change Character Sheet form name to "Edit Character" when accessed through menu edit
    //TODO Story 6 - Add character delete functionality
    //TODO Story 7 - ErrorProvider support to add/edit forms. See Instructions

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            var about = new AboutBox();
            about.ShowDialog(this);
        }
    }
}