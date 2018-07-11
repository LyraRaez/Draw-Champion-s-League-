using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;


using System.Windows.Forms;

namespace Tirage_Champions_League
{
    public partial class Menu : Form
    {
        public string InitialDirecory {get; set;}
        public Menu()
        {
            InitializeComponent();


        }
        private void Menu_Load(object sender, EventArgs e)
        {
            string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon2 = new SqlConnection(connectionString2);
            sqlCon2.Open();

            string commandString2 = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM EQUIPE ORDER BY ID_Equipe");
            SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
            SqlDataReader read2 = sqlCmd2.ExecuteReader();
            while (read2.Read())
            {
                LBX_Equipe.Items.Add((int)read2["ID_Equipe"] + "." + (string)read2["Nom_Equipe"] + " " + (string)read2["Coefficient_UEFA"] + " Pays:" + (int)read2["ID_Pays"] + " Chapeau:" + (int)read2["ID_Chapeau"]);
            }
            sqlCon2.Close();

            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = ("SELECT ID_Pays, Libelle_Pays FROM PAYS ORDER BY ID_Pays ");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                LBX_Pays.Items.Add((int)read["ID_Pays"] + "." + (string)read["Libelle_Pays"]);
            }
            sqlCon.Close();

             string connectionString3 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
                SqlConnection sqlCon3 = new SqlConnection(connectionString3);
                sqlCon3.Open();

                string commandString3 = ("SELECT ID_Chapeau, Libelle_Chapeau FROM CHAPEAU ORDER BY ID_Chapeau ");
                SqlCommand sqlCmd3 = new SqlCommand(commandString3, sqlCon3);
                SqlDataReader read4 = sqlCmd3.ExecuteReader();
                while (read4.Read())
                {
                    LBX_Chapeau.Items.Add((int)read4["ID_Chapeau"] + "." + (string)read4["Libelle_Chapeau"]);
                }
                sqlCon3.Close();
        }

        /// <summary>
        /// Pays
        /// </summary>

        private void B_AddPays_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "INSERT INTO PAYS( Libelle_Pays) values ('" + TBX_NomPays.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();


        }


        private void LBX_Pays_DoubleClick(object sender, EventArgs e)
        {
            string Texte = LBX_Pays.SelectedItem.ToString(), ID;
            int longueur = Texte.Length;
            int i = 0, compteur = 0;

            for (i = 0; i < longueur; i++)
            {
                if (Texte.ElementAt(i).ToString() != ".")
                    compteur++;
                else
                    i = longueur;
            }
            ID = Texte.Substring(0, compteur);

            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = ("SELECT ID_Pays, Libelle_Pays FROM PAYS WHERE ID_Pays='" + ID + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                TBX_NomPaysSelect.Text = read["Libelle_Pays"].ToString();
            }
            TBX_PaysSelect.Text = ID.ToString();
            sqlCon.Close();
        }

        private void B_AfficherPays_Click(object sender, EventArgs e)
        {
                LBX_Pays.Items.Clear();
                {
                    string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
                    SqlConnection sqlCon2 = new SqlConnection(connectionString2);
                    sqlCon2.Open();

                    string commandString2 = ("SELECT ID_Pays, Libelle_Pays FROM PAYS ORDER BY ID_Pays ");
                    SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
                    SqlDataReader read2 = sqlCmd2.ExecuteReader();
                    while (read2.Read())
                    {
                        LBX_Pays.Items.Add((int)read2["ID_Pays"] + "." + (string)read2["Libelle_Pays"]);
                    }
                    sqlCon2.Close();
                }

        }



        /// <summary>
        /// Chapeau
        /// </summary>

        private void B_AddChapeau_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "INSERT INTO CHAPEAU( Libelle_Chapeau) values ('" + TBX_NomChapeau.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void LBX_Chapeau_DoubleClick(object sender, EventArgs e)
        {
            string Texte = LBX_Chapeau.SelectedItem.ToString(), ID;
            int longueur = Texte.Length;
            int i = 0, compteur = 0;

            for (i = 0; i < longueur; i++)
            {
                if (Texte.ElementAt(i).ToString() != ".")
                    compteur++;
                else
                    i = longueur;
            }
            ID = Texte.Substring(0, compteur);

            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();


            string commandString = ("SELECT ID_Chapeau, Libelle_Chapeau FROM CHAPEAU WHERE ID_Chapeau='" + ID + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                TBX_ChapeauSelect.Text = read["Libelle_Chapeau"].ToString();
            }
            TBX_ChaSelect.Text = ID.ToString();
            sqlCon.Close();

        }

        private void B_Rand_Click(object sender, EventArgs e)
        {
                LBX_Chapeau.Items.Clear();
                {
                    string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
                    SqlConnection sqlCon2 = new SqlConnection(connectionString2);
                    sqlCon2.Open();

                    string commandString2 = ("SELECT ID_Chapeau, Libelle_Chapeau FROM CHAPEAU ORDER BY ID_Chapeau ");
                    SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
                    SqlDataReader read2 = sqlCmd2.ExecuteReader();
                    while (read2.Read())
                    {
                        LBX_Chapeau.Items.Add((int)read2["ID_Chapeau"] + "." + (string)read2["Libelle_Chapeau"]);
                    }
                    sqlCon2.Close();
                }
        }

        /// <summary>
        /// Equipe
        /// </summary>
        private void B_RushImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileSelect = new OpenFileDialog();
            FileSelect.Filter = "";
            FileSelect.Title = "Selectionnée une image";
            FileSelect.ShowDialog();
            string chemin = FileSelect.FileName;
            TBX_LieuImage.Text = FileSelect.FileName;
            FileStream fs = new FileStream(chemin, FileMode.Open);
            PBX_Ecusson.Image = Image.FromStream(fs);

            fs.Close();
            MessageBox.Show("Merci de sauvegarder l'image");
        }



        private void B_AddEquipe_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "INSERT INTO EQUIPE(Nom_Equipe, Nom_Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau) values ('" + TBX_NomEquipe.Text + "','" + TBX_ImageSave.Text + "','" + TBX_CoeffUEFA.Text + "','" + int.Parse(TBX_PaysSelect.Text) + "', '" + int.Parse(TBX_ChaSelect.Text) + "')";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
            RAZControle();
        }

        private void LBX_Equipe_DoubleClick(object sender, EventArgs e)
        {
            string Texte = LBX_Equipe.SelectedItem.ToString(), ID;
            int longueur = Texte.Length;
            int i = 0, compteur = 0;

            for (i = 0; i < longueur; i++)
            {
                if (Texte.ElementAt(i).ToString() != ".")
                    compteur++;
                else
                    i = longueur;
            }
            ID = Texte.Substring(0, compteur);

            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();


            string commandString = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM Equipe WHERE ID_Equipe='" + ID + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                TBX_NomEquipe.Text = read["Nom_Equipe"].ToString();
                TBX_LieuImage.Text = read["Nom_Logo_Equipe"].ToString();
                PBX_Ecusson.ImageLocation = read["Nom_Logo_Equipe"].ToString();
                TBX_CoeffUEFA.Text = read["Coefficient_UEFA"].ToString();
                TBX_ChaSelect.Text = read["ID_Chapeau"].ToString();
                TBX_PaysSelect.Text = read["ID_Pays"].ToString();

            }
            NUD_IDEquipe.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "UPDATE Equipe SET Nom_Equipe = ('" + TBX_NomEquipe.Text + "'), Nom_Logo_Equipe = ('" + TBX_ImageSave.Text + "'), Coefficient_UEFA = ('" + TBX_CoeffUEFA.Text + "'), ID_Pays=('" + int.Parse(TBX_PaysSelect.Text) + "'), ID_Chapeau=('" + int.Parse(TBX_ChaSelect.Text) + "') WHERE ID_Equipe ='" + NUD_IDEquipe.Value + "'";  // Sélectionne une ou plusieurs colonne(s) d'une table
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = ("DELETE FROM Equipe WHERE ID_Equipe ='" + NUD_IDEquipe.Value + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void B_SavePic_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(PBX_Ecusson.ClientSize.Width, PBX_Ecusson.ClientSize.Height);
            PBX_Ecusson.DrawToBitmap(bmp, PBX_Ecusson.ClientRectangle);
            bmp.Save("K:/Antoine/Cours/DEV2/DEV/Cas Champions Ligue Football/Image/picturebox.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void PBX_Ecusson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "c://";
            saveFileDialog.Filter = "Image PNG (*.png)|.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFileDialog.InitialDirectory = "K:/Antoine/Cours/DEV2/DEV/Cas Champions Ligue Football/Image";
                PBX_Ecusson.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
            TBX_ImageSave.Text= saveFileDialog.FileName;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            LBX_Equipe.Items.Clear();
            {
                string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
                SqlConnection sqlCon2 = new SqlConnection(connectionString2);
                sqlCon2.Open();

                string commandString2 = ("SELECT ID_Equipe, Nom_Equipe,Nom_Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM Equipe ORDER BY ID_Equipe ");
                SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
                SqlDataReader read2 = sqlCmd2.ExecuteReader();
                while (read2.Read())
                {
                    LBX_Equipe.Items.Add((int)read2["ID_Equipe"] + "." + (string)read2["Nom_Equipe"]+" "+(string)read2["Coefficient_UEFA"]+" Pays:"+(int)read2["ID_Pays"]+" Chapeau:"+(int)read2["ID_Chapeau"]);
                }
                sqlCon2.Close();
                LBL_ImgEquipe.Visible=true;
                TBX_LieuImage.Visible=true;
                B_RushImage.Visible=true;
                RAZControle();
            }
        }

        private void RAZControle()
        {
            TBX_ChapeauSelect.Clear();
            TBX_ChaSelect.Clear();
            TBX_CoeffUEFA.Clear();
            TBX_ImageSave.Clear();
            TBX_LieuImage.Clear();
            TBX_NomChapeau.Clear();
            TBX_NomEquipe.Clear();
            TBX_NomPays.Clear();
            TBX_NomPaysSelect.Clear();
            TBX_PaysSelect.Clear();
            
        }

        private void B_Tirage_Click(object sender, EventArgs e)
        {
            FRM_Tirage ecran2 = new FRM_Tirage();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }
    }
}
