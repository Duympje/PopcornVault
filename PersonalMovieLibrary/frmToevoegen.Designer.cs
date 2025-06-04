namespace PersonalMovieLibrary
{
    partial class frmFilmToevoegen
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
            lblTitel = new Label();
            lblJaar = new Label();
            cboGenre = new ComboBox();
            label1 = new Label();
            lblRegisseur = new Label();
            nudBeoordeling = new NumericUpDown();
            lblBeoordeling = new Label();
            lblGegevens = new Label();
            lblReview = new Label();
            lblDuur = new Label();
            lblUrl = new Label();
            lblPrijs = new Label();
            lblLocatie = new Label();
            txtBeschrijving = new TextBox();
            txtDuur = new TextBox();
            txtTitel = new TextBox();
            txtRegisseur = new TextBox();
            txtUrl = new TextBox();
            txtPrijs = new TextBox();
            txtJaar = new TextBox();
            cboLocatie = new ComboBox();
            txtReview = new TextBox();
            picFoto = new PictureBox();
            btnAfbeeldingkiezen = new Button();
            btnToevoegen = new Button();
            btnAnnuleren = new Button();
            lblTekst1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudBeoordeling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(37, 68);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(44, 25);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Titel";
            // 
            // lblJaar
            // 
            lblJaar.AutoSize = true;
            lblJaar.Location = new Point(39, 116);
            lblJaar.Name = "lblJaar";
            lblJaar.Size = new Size(42, 25);
            lblJaar.TabIndex = 1;
            lblJaar.Text = "Jaar";
            // 
            // cboGenre
            // 
            cboGenre.FormattingEnabled = true;
            cboGenre.Location = new Point(174, 163);
            cboGenre.Name = "cboGenre";
            cboGenre.Size = new Size(150, 33);
            cboGenre.Sorted = true;
            cboGenre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 163);
            label1.Name = "label1";
            label1.Size = new Size(58, 25);
            label1.TabIndex = 3;
            label1.Text = "Genre";
            // 
            // lblRegisseur
            // 
            lblRegisseur.AutoSize = true;
            lblRegisseur.Location = new Point(39, 214);
            lblRegisseur.Name = "lblRegisseur";
            lblRegisseur.Size = new Size(87, 25);
            lblRegisseur.TabIndex = 4;
            lblRegisseur.Text = "Regisseur";
            // 
            // nudBeoordeling
            // 
            nudBeoordeling.Location = new Point(721, 71);
            nudBeoordeling.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudBeoordeling.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudBeoordeling.Name = "nudBeoordeling";
            nudBeoordeling.Size = new Size(91, 31);
            nudBeoordeling.TabIndex = 5;
            nudBeoordeling.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblBeoordeling
            // 
            lblBeoordeling.AutoSize = true;
            lblBeoordeling.Location = new Point(578, 71);
            lblBeoordeling.Name = "lblBeoordeling";
            lblBeoordeling.Size = new Size(108, 25);
            lblBeoordeling.TabIndex = 6;
            lblBeoordeling.Text = "Beoordeling";
            // 
            // lblGegevens
            // 
            lblGegevens.AutoSize = true;
            lblGegevens.Location = new Point(188, 22);
            lblGegevens.Name = "lblGegevens";
            lblGegevens.Size = new Size(121, 25);
            lblGegevens.TabIndex = 7;
            lblGegevens.Text = "Filmgegevens";
            // 
            // lblReview
            // 
            lblReview.AutoSize = true;
            lblReview.Location = new Point(673, 22);
            lblReview.Name = "lblReview";
            lblReview.Size = new Size(66, 25);
            lblReview.TabIndex = 8;
            lblReview.Text = "Review";
            // 
            // lblDuur
            // 
            lblDuur.AutoSize = true;
            lblDuur.Location = new Point(37, 271);
            lblDuur.Name = "lblDuur";
            lblDuur.Size = new Size(131, 25);
            lblDuur.TabIndex = 9;
            lblDuur.Text = "Duur (minuten)";
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(39, 329);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(95, 25);
            lblUrl.TabIndex = 10;
            lblUrl.Text = "IMDb-URL";
            // 
            // lblPrijs
            // 
            lblPrijs.AutoSize = true;
            lblPrijs.Location = new Point(39, 388);
            lblPrijs.Name = "lblPrijs";
            lblPrijs.Size = new Size(44, 25);
            lblPrijs.TabIndex = 11;
            lblPrijs.Text = "Prijs";
            // 
            // lblLocatie
            // 
            lblLocatie.AutoSize = true;
            lblLocatie.Location = new Point(39, 440);
            lblLocatie.Name = "lblLocatie";
            lblLocatie.Size = new Size(136, 25);
            lblLocatie.TabIndex = 12;
            lblLocatie.Text = "Locatie/Platfom";
            // 
            // txtBeschrijving
            // 
            txtBeschrijving.Location = new Point(39, 495);
            txtBeschrijving.Multiline = true;
            txtBeschrijving.Name = "txtBeschrijving";
            txtBeschrijving.PlaceholderText = "Beschrijving over de film.";
            txtBeschrijving.Size = new Size(343, 166);
            txtBeschrijving.TabIndex = 13;
            // 
            // txtDuur
            // 
            txtDuur.Location = new Point(174, 271);
            txtDuur.Name = "txtDuur";
            txtDuur.Size = new Size(150, 31);
            txtDuur.TabIndex = 14;
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(174, 65);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(150, 31);
            txtTitel.TabIndex = 15;
            // 
            // txtRegisseur
            // 
            txtRegisseur.Location = new Point(174, 211);
            txtRegisseur.Name = "txtRegisseur";
            txtRegisseur.Size = new Size(150, 31);
            txtRegisseur.TabIndex = 16;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(174, 326);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(150, 31);
            txtUrl.TabIndex = 17;
            // 
            // txtPrijs
            // 
            txtPrijs.Location = new Point(174, 388);
            txtPrijs.Name = "txtPrijs";
            txtPrijs.Size = new Size(150, 31);
            txtPrijs.TabIndex = 18;
            // 
            // txtJaar
            // 
            txtJaar.Location = new Point(174, 116);
            txtJaar.Name = "txtJaar";
            txtJaar.Size = new Size(150, 31);
            txtJaar.TabIndex = 19;
            // 
            // cboLocatie
            // 
            cboLocatie.FormattingEnabled = true;
            cboLocatie.Location = new Point(174, 437);
            cboLocatie.Name = "cboLocatie";
            cboLocatie.Size = new Size(150, 33);
            cboLocatie.Sorted = true;
            cboLocatie.TabIndex = 20;
            // 
            // txtReview
            // 
            txtReview.Location = new Point(578, 136);
            txtReview.Multiline = true;
            txtReview.Name = "txtReview";
            txtReview.PlaceholderText = "Persoonlijke mening over de film.";
            txtReview.Size = new Size(343, 166);
            txtReview.TabIndex = 21;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(578, 319);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(234, 302);
            picFoto.TabIndex = 22;
            picFoto.TabStop = false;
            // 
            // btnAfbeeldingkiezen
            // 
            btnAfbeeldingkiezen.Location = new Point(578, 627);
            btnAfbeeldingkiezen.Name = "btnAfbeeldingkiezen";
            btnAfbeeldingkiezen.Size = new Size(234, 34);
            btnAfbeeldingkiezen.TabIndex = 23;
            btnAfbeeldingkiezen.Text = "Afbeelding kiezen";
            btnAfbeeldingkiezen.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            btnToevoegen.Location = new Point(37, 697);
            btnToevoegen.Name = "btnToevoegen";
            btnToevoegen.Size = new Size(201, 85);
            btnToevoegen.TabIndex = 24;
            btnToevoegen.Text = "Film Toevoegen";
            btnToevoegen.UseVisualStyleBackColor = true;
            btnToevoegen.Click += btnToevoegen_Click;
            // 
            // btnAnnuleren
            // 
            btnAnnuleren.Location = new Point(268, 697);
            btnAnnuleren.Name = "btnAnnuleren";
            btnAnnuleren.Size = new Size(201, 85);
            btnAnnuleren.TabIndex = 25;
            btnAnnuleren.Text = "Annuleren";
            btnAnnuleren.UseVisualStyleBackColor = true;
            // 
            // lblTekst1
            // 
            lblTekst1.AutoSize = true;
            lblTekst1.Location = new Point(578, 673);
            lblTekst1.Name = "lblTekst1";
            lblTekst1.Size = new Size(350, 25);
            lblTekst1.TabIndex = 26;
            lblTekst1.Text = "Indien er geen afbeelding is laat je dit leeg.";
            // 
            // frmFilmToevoegen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 842);
            Controls.Add(lblTekst1);
            Controls.Add(btnAnnuleren);
            Controls.Add(btnToevoegen);
            Controls.Add(btnAfbeeldingkiezen);
            Controls.Add(picFoto);
            Controls.Add(txtReview);
            Controls.Add(cboLocatie);
            Controls.Add(txtJaar);
            Controls.Add(txtPrijs);
            Controls.Add(txtUrl);
            Controls.Add(txtRegisseur);
            Controls.Add(txtTitel);
            Controls.Add(txtDuur);
            Controls.Add(txtBeschrijving);
            Controls.Add(lblLocatie);
            Controls.Add(lblPrijs);
            Controls.Add(lblUrl);
            Controls.Add(lblDuur);
            Controls.Add(lblReview);
            Controls.Add(lblGegevens);
            Controls.Add(lblBeoordeling);
            Controls.Add(nudBeoordeling);
            Controls.Add(lblRegisseur);
            Controls.Add(label1);
            Controls.Add(cboGenre);
            Controls.Add(lblJaar);
            Controls.Add(lblTitel);
            Name = "frmFilmToevoegen";
            Text = "Film Toevoegen";
            Load += frmFilmToevoegen_Load;
            ((System.ComponentModel.ISupportInitialize)nudBeoordeling).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblJaar;
        private ComboBox cboGenre;
        private Label label1;
        private Label lblRegisseur;
        private NumericUpDown nudBeoordeling;
        private Label lblBeoordeling;
        private Label lblGegevens;
        private Label lblReview;
        private Label lblDuur;
        private Label lblUrl;
        private Label lblPrijs;
        private Label lblLocatie;
        private TextBox txtBeschrijving;
        private TextBox txtDuur;
        private TextBox txtTitel;
        private TextBox txtRegisseur;
        private TextBox txtUrl;
        private TextBox txtPrijs;
        private TextBox txtJaar;
        private ComboBox cboLocatie;
        private TextBox txtReview;
        private PictureBox picFoto;
        private Button btnAfbeeldingkiezen;
        private Button btnToevoegen;
        private Button btnAnnuleren;
        private Label lblTekst1;
    }
}