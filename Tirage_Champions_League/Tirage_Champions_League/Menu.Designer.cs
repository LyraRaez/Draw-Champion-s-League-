namespace Tirage_Champions_League
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.GBX_Chapeau = new System.Windows.Forms.GroupBox();
            this.B_Rand = new System.Windows.Forms.Button();
            this.TBX_NomChapeau = new System.Windows.Forms.TextBox();
            this.B_AddChapeau = new System.Windows.Forms.Button();
            this.LBl_LibelleChapeau = new System.Windows.Forms.Label();
            this.LBX_Chapeau = new System.Windows.Forms.ListBox();
            this.LBL_ImgEquipe = new System.Windows.Forms.Label();
            this.GBX_Equipe = new System.Windows.Forms.GroupBox();
            this.TBX_ImageSave = new System.Windows.Forms.TextBox();
            this.LBL_ImageSave = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.TBX_ChaSelect = new System.Windows.Forms.TextBox();
            this.TBX_PaysSelect = new System.Windows.Forms.TextBox();
            this.B_Update = new System.Windows.Forms.Button();
            this.B_Delete = new System.Windows.Forms.Button();
            this.NUD_IDEquipe = new System.Windows.Forms.NumericUpDown();
            this.TBX_ChapeauSelect = new System.Windows.Forms.TextBox();
            this.TBX_NomPaysSelect = new System.Windows.Forms.TextBox();
            this.TBX_CoeffUEFA = new System.Windows.Forms.TextBox();
            this.LBL_CoeffUEFA = new System.Windows.Forms.Label();
            this.LBL_ChapeauSelection = new System.Windows.Forms.Label();
            this.PBX_Ecusson = new System.Windows.Forms.PictureBox();
            this.LBL_IDPays = new System.Windows.Forms.Label();
            this.B_AddEquipe = new System.Windows.Forms.Button();
            this.TBX_NomEquipe = new System.Windows.Forms.TextBox();
            this.TBX_LieuImage = new System.Windows.Forms.TextBox();
            this.B_RushImage = new System.Windows.Forms.Button();
            this.LBL_NomEquipe = new System.Windows.Forms.Label();
            this.LBX_Equipe = new System.Windows.Forms.ListBox();
            this.GBX_Pays = new System.Windows.Forms.GroupBox();
            this.B_AfficherPays = new System.Windows.Forms.Button();
            this.B_AddPays = new System.Windows.Forms.Button();
            this.TBX_NomPays = new System.Windows.Forms.TextBox();
            this.LBL_NomPays = new System.Windows.Forms.Label();
            this.LBX_Pays = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.B_Tirage = new System.Windows.Forms.Button();
            this.GBX_Chapeau.SuspendLayout();
            this.GBX_Equipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_IDEquipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Ecusson)).BeginInit();
            this.GBX_Pays.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBX_Chapeau
            // 
            this.GBX_Chapeau.BackColor = System.Drawing.Color.Transparent;
            this.GBX_Chapeau.Controls.Add(this.B_Rand);
            this.GBX_Chapeau.Controls.Add(this.TBX_NomChapeau);
            this.GBX_Chapeau.Controls.Add(this.B_AddChapeau);
            this.GBX_Chapeau.Controls.Add(this.LBl_LibelleChapeau);
            this.GBX_Chapeau.Controls.Add(this.LBX_Chapeau);
            this.GBX_Chapeau.ForeColor = System.Drawing.Color.White;
            this.GBX_Chapeau.Location = new System.Drawing.Point(433, 195);
            this.GBX_Chapeau.Name = "GBX_Chapeau";
            this.GBX_Chapeau.Size = new System.Drawing.Size(314, 173);
            this.GBX_Chapeau.TabIndex = 0;
            this.GBX_Chapeau.TabStop = false;
            this.GBX_Chapeau.Text = "Chapeau";
            // 
            // B_Rand
            // 
            this.B_Rand.ForeColor = System.Drawing.Color.Black;
            this.B_Rand.Location = new System.Drawing.Point(226, 14);
            this.B_Rand.Name = "B_Rand";
            this.B_Rand.Size = new System.Drawing.Size(75, 23);
            this.B_Rand.TabIndex = 4;
            this.B_Rand.Text = "Actualiser";
            this.B_Rand.UseVisualStyleBackColor = true;
            this.B_Rand.Click += new System.EventHandler(this.B_Rand_Click);
            // 
            // TBX_NomChapeau
            // 
            this.TBX_NomChapeau.Location = new System.Drawing.Point(101, 118);
            this.TBX_NomChapeau.Name = "TBX_NomChapeau";
            this.TBX_NomChapeau.Size = new System.Drawing.Size(100, 20);
            this.TBX_NomChapeau.TabIndex = 3;
            // 
            // B_AddChapeau
            // 
            this.B_AddChapeau.ForeColor = System.Drawing.Color.Black;
            this.B_AddChapeau.Location = new System.Drawing.Point(126, 144);
            this.B_AddChapeau.Name = "B_AddChapeau";
            this.B_AddChapeau.Size = new System.Drawing.Size(75, 23);
            this.B_AddChapeau.TabIndex = 2;
            this.B_AddChapeau.Text = "Ajouter";
            this.B_AddChapeau.UseVisualStyleBackColor = true;
            this.B_AddChapeau.Click += new System.EventHandler(this.B_AddChapeau_Click);
            // 
            // LBl_LibelleChapeau
            // 
            this.LBl_LibelleChapeau.AutoSize = true;
            this.LBl_LibelleChapeau.ForeColor = System.Drawing.Color.Black;
            this.LBl_LibelleChapeau.Location = new System.Drawing.Point(6, 121);
            this.LBl_LibelleChapeau.Name = "LBl_LibelleChapeau";
            this.LBl_LibelleChapeau.Size = new System.Drawing.Size(89, 13);
            this.LBl_LibelleChapeau.TabIndex = 1;
            this.LBl_LibelleChapeau.Text = "Nom du chapeau";
            // 
            // LBX_Chapeau
            // 
            this.LBX_Chapeau.FormattingEnabled = true;
            this.LBX_Chapeau.Location = new System.Drawing.Point(6, 14);
            this.LBX_Chapeau.Name = "LBX_Chapeau";
            this.LBX_Chapeau.Size = new System.Drawing.Size(214, 95);
            this.LBX_Chapeau.TabIndex = 0;
            this.LBX_Chapeau.DoubleClick += new System.EventHandler(this.LBX_Chapeau_DoubleClick);
            // 
            // LBL_ImgEquipe
            // 
            this.LBL_ImgEquipe.AutoSize = true;
            this.LBL_ImgEquipe.Location = new System.Drawing.Point(6, 179);
            this.LBL_ImgEquipe.Name = "LBL_ImgEquipe";
            this.LBL_ImgEquipe.Size = new System.Drawing.Size(36, 13);
            this.LBL_ImgEquipe.TabIndex = 1;
            this.LBL_ImgEquipe.Text = "Image";
            // 
            // GBX_Equipe
            // 
            this.GBX_Equipe.BackColor = System.Drawing.Color.Transparent;
            this.GBX_Equipe.Controls.Add(this.TBX_ImageSave);
            this.GBX_Equipe.Controls.Add(this.LBL_ImageSave);
            this.GBX_Equipe.Controls.Add(this.Update);
            this.GBX_Equipe.Controls.Add(this.TBX_ChaSelect);
            this.GBX_Equipe.Controls.Add(this.TBX_PaysSelect);
            this.GBX_Equipe.Controls.Add(this.B_Update);
            this.GBX_Equipe.Controls.Add(this.B_Delete);
            this.GBX_Equipe.Controls.Add(this.NUD_IDEquipe);
            this.GBX_Equipe.Controls.Add(this.TBX_ChapeauSelect);
            this.GBX_Equipe.Controls.Add(this.TBX_NomPaysSelect);
            this.GBX_Equipe.Controls.Add(this.TBX_CoeffUEFA);
            this.GBX_Equipe.Controls.Add(this.LBL_CoeffUEFA);
            this.GBX_Equipe.Controls.Add(this.LBL_ChapeauSelection);
            this.GBX_Equipe.Controls.Add(this.PBX_Ecusson);
            this.GBX_Equipe.Controls.Add(this.LBL_IDPays);
            this.GBX_Equipe.Controls.Add(this.B_AddEquipe);
            this.GBX_Equipe.Controls.Add(this.TBX_NomEquipe);
            this.GBX_Equipe.Controls.Add(this.TBX_LieuImage);
            this.GBX_Equipe.Controls.Add(this.B_RushImage);
            this.GBX_Equipe.Controls.Add(this.LBL_NomEquipe);
            this.GBX_Equipe.Controls.Add(this.LBL_ImgEquipe);
            this.GBX_Equipe.Controls.Add(this.LBX_Equipe);
            this.GBX_Equipe.ForeColor = System.Drawing.Color.White;
            this.GBX_Equipe.Location = new System.Drawing.Point(12, 12);
            this.GBX_Equipe.Name = "GBX_Equipe";
            this.GBX_Equipe.Size = new System.Drawing.Size(415, 443);
            this.GBX_Equipe.TabIndex = 2;
            this.GBX_Equipe.TabStop = false;
            this.GBX_Equipe.Text = "Equipe";
            // 
            // TBX_ImageSave
            // 
            this.TBX_ImageSave.Location = new System.Drawing.Point(107, 235);
            this.TBX_ImageSave.Name = "TBX_ImageSave";
            this.TBX_ImageSave.Size = new System.Drawing.Size(100, 20);
            this.TBX_ImageSave.TabIndex = 22;
            // 
            // LBL_ImageSave
            // 
            this.LBL_ImageSave.AutoSize = true;
            this.LBL_ImageSave.Location = new System.Drawing.Point(6, 238);
            this.LBL_ImageSave.Name = "LBL_ImageSave";
            this.LBL_ImageSave.Size = new System.Drawing.Size(101, 13);
            this.LBL_ImageSave.TabIndex = 21;
            this.LBL_ImageSave.Text = "Image sauvegardée";
            // 
            // Update
            // 
            this.Update.ForeColor = System.Drawing.Color.Black;
            this.Update.Location = new System.Drawing.Point(256, 48);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 20;
            this.Update.Text = "Actualiser";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // TBX_ChaSelect
            // 
            this.TBX_ChaSelect.Location = new System.Drawing.Point(62, 368);
            this.TBX_ChaSelect.Name = "TBX_ChaSelect";
            this.TBX_ChaSelect.Size = new System.Drawing.Size(39, 20);
            this.TBX_ChaSelect.TabIndex = 18;
            // 
            // TBX_PaysSelect
            // 
            this.TBX_PaysSelect.Location = new System.Drawing.Point(48, 309);
            this.TBX_PaysSelect.Name = "TBX_PaysSelect";
            this.TBX_PaysSelect.Size = new System.Drawing.Size(39, 20);
            this.TBX_PaysSelect.TabIndex = 17;
            // 
            // B_Update
            // 
            this.B_Update.ForeColor = System.Drawing.Color.Black;
            this.B_Update.Location = new System.Drawing.Point(325, 385);
            this.B_Update.Name = "B_Update";
            this.B_Update.Size = new System.Drawing.Size(75, 23);
            this.B_Update.TabIndex = 15;
            this.B_Update.Text = "Modifier";
            this.B_Update.UseVisualStyleBackColor = true;
            this.B_Update.Click += new System.EventHandler(this.B_Update_Click);
            // 
            // B_Delete
            // 
            this.B_Delete.ForeColor = System.Drawing.Color.Black;
            this.B_Delete.Location = new System.Drawing.Point(325, 356);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(75, 23);
            this.B_Delete.TabIndex = 14;
            this.B_Delete.Text = "Supprimer";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // NUD_IDEquipe
            // 
            this.NUD_IDEquipe.Location = new System.Drawing.Point(256, 22);
            this.NUD_IDEquipe.Name = "NUD_IDEquipe";
            this.NUD_IDEquipe.Size = new System.Drawing.Size(120, 20);
            this.NUD_IDEquipe.TabIndex = 13;
            // 
            // TBX_ChapeauSelect
            // 
            this.TBX_ChapeauSelect.Location = new System.Drawing.Point(62, 395);
            this.TBX_ChapeauSelect.Name = "TBX_ChapeauSelect";
            this.TBX_ChapeauSelect.Size = new System.Drawing.Size(120, 20);
            this.TBX_ChapeauSelect.TabIndex = 12;
            // 
            // TBX_NomPaysSelect
            // 
            this.TBX_NomPaysSelect.Location = new System.Drawing.Point(48, 336);
            this.TBX_NomPaysSelect.Name = "TBX_NomPaysSelect";
            this.TBX_NomPaysSelect.Size = new System.Drawing.Size(120, 20);
            this.TBX_NomPaysSelect.TabIndex = 9;
            // 
            // TBX_CoeffUEFA
            // 
            this.TBX_CoeffUEFA.Location = new System.Drawing.Point(100, 276);
            this.TBX_CoeffUEFA.Name = "TBX_CoeffUEFA";
            this.TBX_CoeffUEFA.Size = new System.Drawing.Size(100, 20);
            this.TBX_CoeffUEFA.TabIndex = 7;
            // 
            // LBL_CoeffUEFA
            // 
            this.LBL_CoeffUEFA.AutoSize = true;
            this.LBL_CoeffUEFA.Location = new System.Drawing.Point(6, 279);
            this.LBL_CoeffUEFA.Name = "LBL_CoeffUEFA";
            this.LBL_CoeffUEFA.Size = new System.Drawing.Size(88, 13);
            this.LBL_CoeffUEFA.TabIndex = 6;
            this.LBL_CoeffUEFA.Text = "Coefficient UEFA";
            // 
            // LBL_ChapeauSelection
            // 
            this.LBL_ChapeauSelection.AutoSize = true;
            this.LBL_ChapeauSelection.Location = new System.Drawing.Point(6, 371);
            this.LBL_ChapeauSelection.Name = "LBL_ChapeauSelection";
            this.LBL_ChapeauSelection.Size = new System.Drawing.Size(50, 13);
            this.LBL_ChapeauSelection.TabIndex = 4;
            this.LBL_ChapeauSelection.Text = "Chapeau";
            // 
            // PBX_Ecusson
            // 
            this.PBX_Ecusson.BackColor = System.Drawing.Color.White;
            this.PBX_Ecusson.Location = new System.Drawing.Point(256, 119);
            this.PBX_Ecusson.Name = "PBX_Ecusson";
            this.PBX_Ecusson.Size = new System.Drawing.Size(144, 132);
            this.PBX_Ecusson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_Ecusson.TabIndex = 5;
            this.PBX_Ecusson.TabStop = false;
            this.PBX_Ecusson.Click += new System.EventHandler(this.PBX_Ecusson_Click);
            // 
            // LBL_IDPays
            // 
            this.LBL_IDPays.AutoSize = true;
            this.LBL_IDPays.Location = new System.Drawing.Point(6, 334);
            this.LBL_IDPays.Name = "LBL_IDPays";
            this.LBL_IDPays.Size = new System.Drawing.Size(30, 13);
            this.LBL_IDPays.TabIndex = 2;
            this.LBL_IDPays.Text = "Pays";
            // 
            // B_AddEquipe
            // 
            this.B_AddEquipe.ForeColor = System.Drawing.Color.Black;
            this.B_AddEquipe.Location = new System.Drawing.Point(325, 327);
            this.B_AddEquipe.Name = "B_AddEquipe";
            this.B_AddEquipe.Size = new System.Drawing.Size(75, 23);
            this.B_AddEquipe.TabIndex = 3;
            this.B_AddEquipe.Text = "Ajouter";
            this.B_AddEquipe.UseVisualStyleBackColor = true;
            this.B_AddEquipe.Click += new System.EventHandler(this.B_AddEquipe_Click);
            // 
            // TBX_NomEquipe
            // 
            this.TBX_NomEquipe.Location = new System.Drawing.Point(48, 143);
            this.TBX_NomEquipe.Name = "TBX_NomEquipe";
            this.TBX_NomEquipe.Size = new System.Drawing.Size(115, 20);
            this.TBX_NomEquipe.TabIndex = 3;
            // 
            // TBX_LieuImage
            // 
            this.TBX_LieuImage.Location = new System.Drawing.Point(48, 176);
            this.TBX_LieuImage.Name = "TBX_LieuImage";
            this.TBX_LieuImage.Size = new System.Drawing.Size(115, 20);
            this.TBX_LieuImage.TabIndex = 3;
            // 
            // B_RushImage
            // 
            this.B_RushImage.ForeColor = System.Drawing.Color.Black;
            this.B_RushImage.Location = new System.Drawing.Point(48, 202);
            this.B_RushImage.Name = "B_RushImage";
            this.B_RushImage.Size = new System.Drawing.Size(75, 23);
            this.B_RushImage.TabIndex = 3;
            this.B_RushImage.Text = "Parcourir";
            this.B_RushImage.UseVisualStyleBackColor = true;
            this.B_RushImage.Click += new System.EventHandler(this.B_RushImage_Click);
            // 
            // LBL_NomEquipe
            // 
            this.LBL_NomEquipe.AutoSize = true;
            this.LBL_NomEquipe.Location = new System.Drawing.Point(6, 148);
            this.LBL_NomEquipe.Name = "LBL_NomEquipe";
            this.LBL_NomEquipe.Size = new System.Drawing.Size(29, 13);
            this.LBL_NomEquipe.TabIndex = 3;
            this.LBL_NomEquipe.Text = "Nom";
            // 
            // LBX_Equipe
            // 
            this.LBX_Equipe.FormattingEnabled = true;
            this.LBX_Equipe.Location = new System.Drawing.Point(6, 19);
            this.LBX_Equipe.Name = "LBX_Equipe";
            this.LBX_Equipe.Size = new System.Drawing.Size(244, 108);
            this.LBX_Equipe.TabIndex = 3;
         
            this.LBX_Equipe.DoubleClick += new System.EventHandler(this.LBX_Equipe_DoubleClick);
            // 
            // GBX_Pays
            // 
            this.GBX_Pays.BackColor = System.Drawing.Color.Transparent;
            this.GBX_Pays.Controls.Add(this.B_AfficherPays);
            this.GBX_Pays.Controls.Add(this.B_AddPays);
            this.GBX_Pays.Controls.Add(this.TBX_NomPays);
            this.GBX_Pays.Controls.Add(this.LBL_NomPays);
            this.GBX_Pays.Controls.Add(this.LBX_Pays);
            this.GBX_Pays.ForeColor = System.Drawing.Color.White;
            this.GBX_Pays.Location = new System.Drawing.Point(433, 12);
            this.GBX_Pays.Name = "GBX_Pays";
            this.GBX_Pays.Size = new System.Drawing.Size(314, 177);
            this.GBX_Pays.TabIndex = 3;
            this.GBX_Pays.TabStop = false;
            this.GBX_Pays.Text = "Pays";
            // 
            // B_AfficherPays
            // 
            this.B_AfficherPays.ForeColor = System.Drawing.Color.Black;
            this.B_AfficherPays.Location = new System.Drawing.Point(226, 19);
            this.B_AfficherPays.Name = "B_AfficherPays";
            this.B_AfficherPays.Size = new System.Drawing.Size(75, 23);
            this.B_AfficherPays.TabIndex = 4;
            this.B_AfficherPays.Text = "Actualiser";
            this.B_AfficherPays.UseVisualStyleBackColor = true;
            this.B_AfficherPays.Click += new System.EventHandler(this.B_AfficherPays_Click);
            // 
            // B_AddPays
            // 
            this.B_AddPays.ForeColor = System.Drawing.Color.Black;
            this.B_AddPays.Location = new System.Drawing.Point(74, 143);
            this.B_AddPays.Name = "B_AddPays";
            this.B_AddPays.Size = new System.Drawing.Size(75, 23);
            this.B_AddPays.TabIndex = 3;
            this.B_AddPays.Text = "Ajouter";
            this.B_AddPays.UseVisualStyleBackColor = true;
            this.B_AddPays.Click += new System.EventHandler(this.B_AddPays_Click);
            // 
            // TBX_NomPays
            // 
            this.TBX_NomPays.Location = new System.Drawing.Point(90, 119);
            this.TBX_NomPays.Name = "TBX_NomPays";
            this.TBX_NomPays.Size = new System.Drawing.Size(100, 20);
            this.TBX_NomPays.TabIndex = 2;
            // 
            // LBL_NomPays
            // 
            this.LBL_NomPays.AutoSize = true;
            this.LBL_NomPays.Location = new System.Drawing.Point(6, 122);
            this.LBL_NomPays.Name = "LBL_NomPays";
            this.LBL_NomPays.Size = new System.Drawing.Size(69, 13);
            this.LBL_NomPays.TabIndex = 1;
            this.LBL_NomPays.Text = "Nom du pays";
            // 
            // LBX_Pays
            // 
            this.LBX_Pays.FormattingEnabled = true;
            this.LBX_Pays.Location = new System.Drawing.Point(6, 19);
            this.LBX_Pays.Name = "LBX_Pays";
            this.LBX_Pays.Size = new System.Drawing.Size(214, 95);
            this.LBX_Pays.TabIndex = 0;
            this.LBX_Pays.DoubleClick += new System.EventHandler(this.LBX_Pays_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // B_Tirage
            // 
            this.B_Tirage.Location = new System.Drawing.Point(658, 397);
            this.B_Tirage.Name = "B_Tirage";
            this.B_Tirage.Size = new System.Drawing.Size(89, 50);
            this.B_Tirage.TabIndex = 4;
            this.B_Tirage.Text = "Tirage";
            this.B_Tirage.UseVisualStyleBackColor = true;
            this.B_Tirage.Click += new System.EventHandler(this.B_Tirage_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 459);
            this.Controls.Add(this.B_Tirage);
            this.Controls.Add(this.GBX_Pays);
            this.Controls.Add(this.GBX_Equipe);
            this.Controls.Add(this.GBX_Chapeau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.GBX_Chapeau.ResumeLayout(false);
            this.GBX_Chapeau.PerformLayout();
            this.GBX_Equipe.ResumeLayout(false);
            this.GBX_Equipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_IDEquipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Ecusson)).EndInit();
            this.GBX_Pays.ResumeLayout(false);
            this.GBX_Pays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBX_Chapeau;
        private System.Windows.Forms.Label LBL_ImgEquipe;
        private System.Windows.Forms.GroupBox GBX_Equipe;
        private System.Windows.Forms.Label LBL_NomEquipe;
        private System.Windows.Forms.ListBox LBX_Equipe;
        private System.Windows.Forms.Label LBL_IDPays;
        private System.Windows.Forms.Button B_AddEquipe;
        private System.Windows.Forms.TextBox TBX_NomEquipe;
        private System.Windows.Forms.TextBox TBX_LieuImage;
        private System.Windows.Forms.Button B_RushImage;
        private System.Windows.Forms.GroupBox GBX_Pays;
        private System.Windows.Forms.Button B_AddPays;
        private System.Windows.Forms.TextBox TBX_NomPays;
        private System.Windows.Forms.Label LBL_NomPays;
        private System.Windows.Forms.ListBox LBX_Pays;
        private System.Windows.Forms.PictureBox PBX_Ecusson;
        private System.Windows.Forms.TextBox TBX_NomChapeau;
        private System.Windows.Forms.Button B_AddChapeau;
        private System.Windows.Forms.Label LBl_LibelleChapeau;
        private System.Windows.Forms.ListBox LBX_Chapeau;
        private System.Windows.Forms.Label LBL_ChapeauSelection;
        private System.Windows.Forms.Button B_Rand;
        private System.Windows.Forms.TextBox TBX_CoeffUEFA;
        private System.Windows.Forms.Label LBL_CoeffUEFA;
        private System.Windows.Forms.TextBox TBX_NomPaysSelect;
        private System.Windows.Forms.Button B_AfficherPays;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TBX_ChapeauSelect;
        private System.Windows.Forms.NumericUpDown NUD_IDEquipe;
        private System.Windows.Forms.Button B_Update;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.TextBox TBX_ChaSelect;
        private System.Windows.Forms.TextBox TBX_PaysSelect;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox TBX_ImageSave;
        private System.Windows.Forms.Label LBL_ImageSave;
        private System.Windows.Forms.Button B_Tirage;
    }
}

