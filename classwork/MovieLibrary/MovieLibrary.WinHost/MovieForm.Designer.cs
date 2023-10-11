namespace MovieLibrary.WinHost
{
    partial class MovieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            _txtTitle=new TextBox();
            _btnSave=new Button();
            _btnCancel=new Button();
            _cbRating=new ComboBox();
            _txtDescription=new TextBox();
            _txtReleaseYear=new TextBox();
            _txtRunLength=new TextBox();
            _chkIsBlackAndWhite=new CheckBox();
            _txtGenre=new TextBox();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            SuspendLayout();
            // 
            // _txtTitle
            // 
            _txtTitle.Location=new Point(195, 14);
            _txtTitle.Name="_txtTitle";
            _txtTitle.Size=new Size(200, 39);
            _txtTitle.TabIndex=0;
            // 
            // _btnSave
            // 
            _btnSave.Location=new Point(638, 381);
            _btnSave.Name="_btnSave";
            _btnSave.Size=new Size(150, 46);
            _btnSave.TabIndex=1;
            _btnSave.Text="Save";
            _btnSave.UseVisualStyleBackColor=true;
            _btnSave.Click+=OnSave;
            // 
            // _btnCancel
            // 
            _btnCancel.Location=new Point(404, 381);
            _btnCancel.Name="_btnCancel";
            _btnCancel.Size=new Size(150, 46);
            _btnCancel.TabIndex=2;
            _btnCancel.Text="Cancel";
            _btnCancel.UseVisualStyleBackColor=true;
            _btnCancel.Click+=OnCancel;
            // 
            // _cbRating
            // 
            _cbRating.FormattingEnabled=true;
            _cbRating.Items.AddRange(new object[] { "G", "PG", "PG-13", "R" });
            _cbRating.Location=new Point(520, 66);
            _cbRating.Name="_cbRating";
            _cbRating.Size=new Size(242, 40);
            _cbRating.TabIndex=3;
            // 
            // _txtDescription
            // 
            _txtDescription.Location=new Point(195, 147);
            _txtDescription.Name="_txtDescription";
            _txtDescription.Size=new Size(200, 39);
            _txtDescription.TabIndex=4;
            // 
            // _txtReleaseYear
            // 
            _txtReleaseYear.Location=new Point(195, 82);
            _txtReleaseYear.Name="_txtReleaseYear";
            _txtReleaseYear.Size=new Size(200, 39);
            _txtReleaseYear.TabIndex=5;
            // 
            // _txtRunLength
            // 
            _txtRunLength.Location=new Point(195, 213);
            _txtRunLength.Name="_txtRunLength";
            _txtRunLength.Size=new Size(200, 39);
            _txtRunLength.TabIndex=6;
            // 
            // _chkIsBlackAndWhite
            // 
            _chkIsBlackAndWhite.AutoSize=true;
            _chkIsBlackAndWhite.Location=new Point(521, 220);
            _chkIsBlackAndWhite.Name="_chkIsBlackAndWhite";
            _chkIsBlackAndWhite.Size=new Size(252, 36);
            _chkIsBlackAndWhite.TabIndex=7;
            _chkIsBlackAndWhite.Text="Is Black and White?";
            _chkIsBlackAndWhite.UseVisualStyleBackColor=true;
            // 
            // _txtGenre
            // 
            _txtGenre.Location=new Point(195, 279);
            _txtGenre.Name="_txtGenre";
            _txtGenre.Size=new Size(200, 39);
            _txtGenre.TabIndex=8;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(25, 21);
            label1.Name="label1";
            label1.Size=new Size(72, 32);
            label1.TabIndex=9;
            label1.Text="Title :";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(25, 89);
            label2.Name="label2";
            label2.Size=new Size(164, 32);
            label2.TabIndex=10;
            label2.Text="Release Year : ";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(27, 154);
            label3.Name="label3";
            label3.Size=new Size(135, 32);
            label3.TabIndex=11;
            label3.Text="Description";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(25, 220);
            label4.Name="label4";
            label4.Size=new Size(137, 32);
            label4.TabIndex=12;
            label4.Text="Run Length";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(27, 286);
            label5.Name="label5";
            label5.Size=new Size(78, 32);
            label5.TabIndex=13;
            label5.Text="Genre";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(596, 21);
            label6.Name="label6";
            label6.Size=new Size(82, 32);
            label6.TabIndex=14;
            label6.Text="Rating";
            // 
            // MovieForm
            // 
            AutoScaleDimensions=new SizeF(13F, 32F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_txtGenre);
            Controls.Add(_chkIsBlackAndWhite);
            Controls.Add(_txtRunLength);
            Controls.Add(_txtReleaseYear);
            Controls.Add(_txtDescription);
            Controls.Add(_cbRating);
            Controls.Add(_btnCancel);
            Controls.Add(_btnSave);
            Controls.Add(_txtTitle);
            Name="MovieForm";
            Text="Add Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _txtTitle;
        private Button _btnSave;
        private Button _btnCancel;
        private ComboBox _cbRating;
        private TextBox _txtDescription;
        private TextBox _txtReleaseYear;
        private TextBox _txtRunLength;
        private CheckBox _chkIsBlackAndWhite;
        private TextBox _txtGenre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}