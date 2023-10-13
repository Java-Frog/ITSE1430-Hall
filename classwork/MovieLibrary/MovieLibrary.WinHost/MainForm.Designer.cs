﻿namespace MovieLibrary.WinHost
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
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            components=new System.ComponentModel.Container();
            menuStrip1=new MenuStrip();
            contextMenuStrip1=new ContextMenuStrip(components);
            _mainMenu=new MenuStrip();
            fileToolStripMenuItem=new ToolStripMenuItem();
            exitToolStripMenuItem=new ToolStripMenuItem();
            moviesToolStripMenuItem=new ToolStripMenuItem();
            addToolStripMenuItem=new ToolStripMenuItem();
            editToolStripMenuItem=new ToolStripMenuItem();
            deleteToolStripMenuItem=new ToolStripMenuItem();
            helpToolStripMenuItem=new ToolStripMenuItem();
            aboutToolStripMenuItem=new ToolStripMenuItem();
            _lstMovies=new ListBox();
            _mainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(32, 32);
            menuStrip1.Location=new Point(0, 40);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(830, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize=new Size(32, 32);
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // _mainMenu
            // 
            _mainMenu.ImageScalingSize=new Size(32, 32);
            _mainMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, moviesToolStripMenuItem, helpToolStripMenuItem });
            _mainMenu.Location=new Point(0, 0);
            _mainMenu.Name="_mainMenu";
            _mainMenu.Size=new Size(830, 40);
            _mainMenu.TabIndex=2;
            _mainMenu.Text="menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name="fileToolStripMenuItem";
            fileToolStripMenuItem.Size=new Size(71, 36);
            fileToolStripMenuItem.Text="&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new Size(184, 44);
            exitToolStripMenuItem.Text="Exit";
            exitToolStripMenuItem.Click+=OnFileExit;
            // 
            // moviesToolStripMenuItem
            // 
            moviesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            moviesToolStripMenuItem.Name="moviesToolStripMenuItem";
            moviesToolStripMenuItem.Size=new Size(111, 36);
            moviesToolStripMenuItem.Text="&Movies";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name="addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys=Keys.Insert;
            addToolStripMenuItem.Size=new Size(276, 44);
            addToolStripMenuItem.Text="&Add";
            addToolStripMenuItem.Click+=OnAddMovie;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name="editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys=Keys.Alt|Keys.Insert;
            editToolStripMenuItem.Size=new Size(276, 44);
            editToolStripMenuItem.Text="&Edit";
            editToolStripMenuItem.Click+=OnEditMovie;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name="deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys=Keys.Delete;
            deleteToolStripMenuItem.Size=new Size(276, 44);
            deleteToolStripMenuItem.Text="&Delete";
            deleteToolStripMenuItem.Click+=OnDeleteMovie;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name="helpToolStripMenuItem";
            helpToolStripMenuItem.Size=new Size(84, 36);
            helpToolStripMenuItem.Text="&Help";
            helpToolStripMenuItem.Click+=OnHelpClick;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys=Keys.F1;
            aboutToolStripMenuItem.Size=new Size(251, 44);
            aboutToolStripMenuItem.Text="&About";
            aboutToolStripMenuItem.Click+=OnHelpAbout;
            // 
            // _lstMovies
            // 
            _lstMovies.FormattingEnabled=true;
            _lstMovies.ItemHeight=32;
            _lstMovies.Location=new Point(12, 67);
            _lstMovies.Name="_lstMovies";
            _lstMovies.Size=new Size(806, 548);
            _lstMovies.TabIndex=3;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.Control;
            ClientSize=new Size(830, 629);
            Controls.Add(_lstMovies);
            Controls.Add(menuStrip1);
            Controls.Add(_mainMenu);
            Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip=menuStrip1;
            Name="MainForm";
            RightToLeft=RightToLeft.No;
            Text="Movie Library";
            _mainMenu.ResumeLayout(false);
            _mainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip _mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox _lstMovies;
    }
}