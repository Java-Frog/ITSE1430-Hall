namespace MichaelHall.AdventureGame.WinHost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MainMenu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            actionToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            _lstCharacters = new ListBox();
            memoryCharacterDatabaseBindingSource = new BindingSource(components);
            MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoryCharacterDatabaseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, actionToolStripMenuItem, helpToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(784, 24);
            MainMenu.TabIndex = 0;
            MainMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            menuToolStripMenuItem.Size = new Size(37, 20);
            menuToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitToolStripMenuItem.Size = new Size(140, 22);
            exitToolStripMenuItem.Text = "&Quit";
            exitToolStripMenuItem.Click += OnFileExit;
            // 
            // actionToolStripMenuItem
            // 
            actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem, editToolStripMenuItem });
            actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            actionToolStripMenuItem.Size = new Size(70, 20);
            actionToolStripMenuItem.Text = "&Character";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "&New";
            addToolStripMenuItem.Click += OnAddCharacter;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += OnDeleteCharacter;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += OnEditCharacter;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F11;
            aboutToolStripMenuItem.Size = new Size(159, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += OnHelpAbout;
            // 
            // _lstCharacters
            // 
            _lstCharacters.Dock = DockStyle.Fill;
            _lstCharacters.FormattingEnabled = true;
            _lstCharacters.ItemHeight = 15;
            _lstCharacters.Location = new Point(0, 24);
            _lstCharacters.Name = "_lstCharacters";
            _lstCharacters.Size = new Size(784, 537);
            _lstCharacters.TabIndex = 1;
            // 
            // memoryCharacterDatabaseBindingSource
            // 
            memoryCharacterDatabaseBindingSource.DataSource = typeof(Memory.MemoryCharacterDatabase);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(_lstCharacters);
            Controls.Add(MainMenu);
            MainMenuStrip = MainMenu;
            MinimumSize = new Size(300, 200);
            Name = "MainForm";
            Text = "Michael Hall Adventure Game";
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)memoryCharacterDatabaseBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem actionToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox _lstCharacters;
        private BindingSource memoryCharacterDatabaseBindingSource;
    }
}