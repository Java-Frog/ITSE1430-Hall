namespace MichaelHall.AdventureGame.WinHost
{
    partial class CharacterSheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _cbRace = new ComboBox();
            _cbProfession = new ComboBox();
            _btnSave = new Button();
            _btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            _txtBiography = new TextBox();
            _txtName = new TextBox();
            _txtStrength = new TextBox();
            _txtCharisma = new TextBox();
            _txtConstitution = new TextBox();
            _txtDexterity = new TextBox();
            _txtIntelligence = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // _cbRace
            // 
            _cbRace.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbRace.FormattingEnabled = true;
            _cbRace.Location = new Point(241, 52);
            _cbRace.Name = "_cbRace";
            _cbRace.Size = new Size(121, 23);
            _cbRace.TabIndex = 7;
            // 
            // _cbProfession
            // 
            _cbProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            _cbProfession.FormattingEnabled = true;
            _cbProfession.Location = new Point(241, 81);
            _cbProfession.Name = "_cbProfession";
            _cbProfession.Size = new Size(121, 23);
            _cbProfession.TabIndex = 8;
            // 
            // _btnSave
            // 
            _btnSave.Location = new Point(24, 276);
            _btnSave.Name = "_btnSave";
            _btnSave.Size = new Size(75, 23);
            _btnSave.TabIndex = 10;
            _btnSave.Text = "Save";
            _btnSave.UseVisualStyleBackColor = true;
            _btnSave.Click += OnSave;
            // 
            // _btnCancel
            // 
            _btnCancel.Location = new Point(137, 276);
            _btnCancel.Name = "_btnCancel";
            _btnCancel.Size = new Size(75, 23);
            _btnCancel.TabIndex = 11;
            _btnCancel.Text = "Cancel";
            _btnCancel.UseVisualStyleBackColor = true;
            _btnCancel.Click += OnCancel;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Strength";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 5;
            label2.Text = "Constitution";
            // 
            // _txtBiography
            // 
            _txtBiography.Location = new Point(379, 31);
            _txtBiography.Multiline = true;
            _txtBiography.Name = "_txtBiography";
            _txtBiography.Size = new Size(393, 268);
            _txtBiography.TabIndex = 9;
            // 
            // _txtName
            // 
            _txtName.Location = new Point(241, 23);
            _txtName.Name = "_txtName";
            _txtName.Size = new Size(100, 23);
            _txtName.TabIndex = 6;
            // 
            // _txtStrength
            // 
            _txtStrength.Location = new Point(91, 23);
            _txtStrength.Name = "_txtStrength";
            _txtStrength.Size = new Size(26, 23);
            _txtStrength.TabIndex = 1;
            _txtStrength.Text = "50";
            // 
            // _txtCharisma
            // 
            _txtCharisma.Location = new Point(91, 191);
            _txtCharisma.Name = "_txtCharisma";
            _txtCharisma.Size = new Size(26, 23);
            _txtCharisma.TabIndex = 5;
            _txtCharisma.Text = "50";
            // 
            // _txtConstitution
            // 
            _txtConstitution.Location = new Point(91, 64);
            _txtConstitution.Name = "_txtConstitution";
            _txtConstitution.Size = new Size(26, 23);
            _txtConstitution.TabIndex = 2;
            _txtConstitution.Text = "50";
            // 
            // _txtDexterity
            // 
            _txtDexterity.Location = new Point(91, 107);
            _txtDexterity.Name = "_txtDexterity";
            _txtDexterity.Size = new Size(26, 23);
            _txtDexterity.TabIndex = 3;
            _txtDexterity.Text = "50";
            // 
            // _txtIntelligence
            // 
            _txtIntelligence.Location = new Point(91, 148);
            _txtIntelligence.Name = "_txtIntelligence";
            _txtIntelligence.Size = new Size(26, 23);
            _txtIntelligence.TabIndex = 4;
            _txtIntelligence.Text = "50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 110);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 13;
            label3.Text = "Dexterity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 151);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 14;
            label4.Text = "Intelligence";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 194);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 15;
            label5.Text = "Charisma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 26);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 16;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(379, 13);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 17;
            label7.Text = "Biography";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 55);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 18;
            label8.Text = "Race";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 89);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 19;
            label9.Text = "Profession";
            // 
            // CharacterSheet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 311);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(_txtIntelligence);
            Controls.Add(_txtDexterity);
            Controls.Add(_txtConstitution);
            Controls.Add(_txtCharisma);
            Controls.Add(_txtStrength);
            Controls.Add(_txtName);
            Controls.Add(_txtBiography);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_btnCancel);
            Controls.Add(_btnSave);
            Controls.Add(_cbProfession);
            Controls.Add(_cbRace);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(800, 350);
            MinimizeBox = false;
            MinimumSize = new Size(800, 350);
            Name = "CharacterSheet";
            Text = "Add Character";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider _errors;
        private ComboBox _cbRace;
        private ComboBox _cbProfession;
        private Button _btnSave;
        private Button _btnCancel;
        private Label label1;
        private Label label2;
        private TextBox _txtBiography;
        private TextBox _txtName;
        private TextBox _txtStrength;
        private TextBox _txtCharisma;
        private TextBox _txtConstitution;
        private TextBox _txtDexterity;
        private TextBox _txtIntelligence;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}