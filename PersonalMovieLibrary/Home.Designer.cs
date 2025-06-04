namespace PersonalMovieLibrary
{
    partial class frmHome
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
            btnInstellingen = new Button();
            btnFilmToevoegen = new Button();
            btnFilmVerwijderen = new Button();
            btnFilmBewerekn = new Button();
            btnWatchlist = new Button();
            grpTopFilms = new GroupBox();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            btnDownload = new Button();
            grpTopFilms.SuspendLayout();
            SuspendLayout();
            // 
            // btnInstellingen
            // 
            btnInstellingen.Location = new Point(355, 39);
            btnInstellingen.Name = "btnInstellingen";
            btnInstellingen.Size = new Size(112, 34);
            btnInstellingen.TabIndex = 0;
            btnInstellingen.Text = "Instellingen";
            btnInstellingen.UseVisualStyleBackColor = true;
            // 
            // btnFilmToevoegen
            // 
            btnFilmToevoegen.Location = new Point(45, 39);
            btnFilmToevoegen.Name = "btnFilmToevoegen";
            btnFilmToevoegen.Size = new Size(172, 34);
            btnFilmToevoegen.TabIndex = 1;
            btnFilmToevoegen.Text = "Film Toevoegen";
            btnFilmToevoegen.UseVisualStyleBackColor = true;
            btnFilmToevoegen.Click += btnFilmToevoegen_Click;
            // 
            // btnFilmVerwijderen
            // 
            btnFilmVerwijderen.Location = new Point(45, 88);
            btnFilmVerwijderen.Name = "btnFilmVerwijderen";
            btnFilmVerwijderen.Size = new Size(172, 34);
            btnFilmVerwijderen.TabIndex = 2;
            btnFilmVerwijderen.Text = "Film Verwijderen";
            btnFilmVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btnFilmBewerekn
            // 
            btnFilmBewerekn.Location = new Point(45, 139);
            btnFilmBewerekn.Name = "btnFilmBewerekn";
            btnFilmBewerekn.Size = new Size(172, 34);
            btnFilmBewerekn.TabIndex = 3;
            btnFilmBewerekn.Text = "Film Bewereken";
            btnFilmBewerekn.UseVisualStyleBackColor = true;
            // 
            // btnWatchlist
            // 
            btnWatchlist.Location = new Point(355, 88);
            btnWatchlist.Name = "btnWatchlist";
            btnWatchlist.Size = new Size(112, 34);
            btnWatchlist.TabIndex = 4;
            btnWatchlist.Text = "Watchlist";
            btnWatchlist.UseVisualStyleBackColor = true;
            // 
            // grpTopFilms
            // 
            grpTopFilms.Controls.Add(lbl3);
            grpTopFilms.Controls.Add(lbl2);
            grpTopFilms.Controls.Add(lbl1);
            grpTopFilms.Location = new Point(488, 23);
            grpTopFilms.Name = "grpTopFilms";
            grpTopFilms.Size = new Size(300, 341);
            grpTopFilms.TabIndex = 5;
            grpTopFilms.TabStop = false;
            grpTopFilms.Text = "Best beoordeelde films";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(19, 250);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(26, 25);
            lbl3.TabIndex = 2;
            lbl3.Text = "3.";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(19, 125);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(26, 25);
            lbl2.TabIndex = 1;
            lbl2.Text = "2.";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(19, 36);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(26, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "1.";
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(45, 190);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(172, 34);
            btnDownload.TabIndex = 6;
            btnDownload.Text = "Download json file";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDownload);
            Controls.Add(grpTopFilms);
            Controls.Add(btnWatchlist);
            Controls.Add(btnFilmBewerekn);
            Controls.Add(btnFilmVerwijderen);
            Controls.Add(btnFilmToevoegen);
            Controls.Add(btnInstellingen);
            Name = "frmHome";
            Text = "Home";
            Load += frmHome_Load;
            grpTopFilms.ResumeLayout(false);
            grpTopFilms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInstellingen;
        private Button btnFilmToevoegen;
        private Button btnFilmVerwijderen;
        private Button btnFilmBewerekn;
        private Button btnWatchlist;
        private GroupBox grpTopFilms;
        private Label lbl1;
        private Label lbl3;
        private Label lbl2;
        private Button btnDownload;
    }
}
