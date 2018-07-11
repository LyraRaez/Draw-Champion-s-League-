using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tirage_Champions_League
{
    public partial class FRM_Tirage : Form
    { 

        public FRM_Tirage()
        {
            InitializeComponent();
        }

        private void FRM_Tirage_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM EQUIPE   WHERE ID_Chapeau= 1 ORDER BY ID_Pays");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                LBX_Chapeau1.Items.Add((int)read["ID_Equipe"] + "." + (string)read["Nom_Equipe"] + " " + (string)read["Coefficient_UEFA"] + " Pays:" + (int)read["ID_Pays"] + " Chapeau:" + (int)read["ID_Chapeau"]);
            }
            sqlCon.Close();

            string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon2 = new SqlConnection(connectionString2);
            sqlCon2.Open();

            string commandString2 = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM EQUIPE WHERE ID_Chapeau= 2 ORDER BY ID_Pays ");
            SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
            SqlDataReader read2 = sqlCmd2.ExecuteReader();
            while (read2.Read())
            {
                LBX_Chapeau2.Items.Add((int)read2["ID_Equipe"] + "." + (string)read2["Nom_Equipe"] + " " + (string)read2["Coefficient_UEFA"] + " Pays:" + (int)read2["ID_Pays"] + " Chapeau:" + (int)read2["ID_Chapeau"]);
            }
            sqlCon2.Close();

            string connectionString3 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon3 = new SqlConnection(connectionString3);
            sqlCon3.Open();

            string commandString3 = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM EQUIPE WHERE ID_Chapeau= 3 ORDER BY ID_Pays ");
            SqlCommand sqlCmd3 = new SqlCommand(commandString3, sqlCon3);
            SqlDataReader read3 = sqlCmd3.ExecuteReader();
            while (read3.Read())
            {
                LBX_Chapeau3.Items.Add((int)read3["ID_Equipe"] + "." + (string)read3["Nom_Equipe"] + " " + (string)read3["Coefficient_UEFA"] + " Pays:" + (int)read3["ID_Pays"] + " Chapeau:" + (int)read3["ID_Chapeau"]);
            }
            sqlCon3.Close();

            string connectionString4 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon4 = new SqlConnection(connectionString4);
            sqlCon4.Open();

            string commandString4 = ("SELECT ID_Equipe, Nom_Equipe, Nom_Logo_Equipe, Logo_Equipe, Coefficient_UEFA, ID_Pays, ID_Chapeau FROM EQUIPE WHERE ID_Chapeau= 4 ORDER BY ID_Pays ");
            SqlCommand sqlCmd4 = new SqlCommand(commandString4, sqlCon4);
            SqlDataReader read4 = sqlCmd4.ExecuteReader();
            while (read4.Read())
            {
                LBX_Chapeau4.Items.Add((int)read4["ID_Equipe"] + "." + (string)read4["Nom_Equipe"] + " " + (string)read4["Coefficient_UEFA"] + " Pays:" + (int)read4["ID_Pays"] + " Chapeau:" + (int)read4["ID_Chapeau"]);
            }
            sqlCon4.Close();

            string connectionString7 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon7 = new SqlConnection(connectionString7);
            sqlCon7.Open();

            string commandString7 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Libelle_Equipe2, Libelle_Equipe3 , Libelle_Equipe4 FROM POULE ORDER BY ID_Groupe");
            SqlCommand sqlCmd7 = new SqlCommand(commandString7, sqlCon7);
            SqlDataReader read7 = sqlCmd7.ExecuteReader();
            while (read7.Read())
            {
                LBX_Groupe1.Items.Add((int)read7["ID_Groupe"] + "." + (string)read7["Libelle_Groupe"]);
            }
            sqlCon7.Close();



        }

        private void B_Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            TBX_Tirage.Text = rnd.Next(1, 9).ToString();
        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            TBX_Tirage.Clear();
        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            Menu ecran2 = new Menu();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }

        private void LBX_Chapeau1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Texte = LBX_Chapeau1.SelectedItem.ToString(), ID;
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
                TBX_Equipe1.Text = read["Nom_Equipe"].ToString();
                LBL_ImageEquipe1.Text = read["Nom_Logo_Equipe"].ToString();
                PBX_Equipe1.ImageLocation = read["Nom_Logo_Equipe"].ToString();
            }
            NUD_Equipe1.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

        private void LBX_Chapeau2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Texte = LBX_Chapeau2.SelectedItem.ToString(), ID;
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
                TBX_Equipe2.Text = read["Nom_Equipe"].ToString();
                LBL_ImageEquipe2.Text = read["Nom_Logo_Equipe"].ToString();
                PBX_Equipe2.ImageLocation = read["Nom_Logo_Equipe"].ToString();
            }
            NUD_Equipe2.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

        private void LBX_Chapeau3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Texte = LBX_Chapeau3.SelectedItem.ToString(), ID;
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
                TBX_Equipe3.Text = read["Nom_Equipe"].ToString();
                LBL_ImageEquipe3.Text = read["Nom_Logo_Equipe"].ToString();
                PBX_Equipe3.ImageLocation = read["Nom_Logo_Equipe"].ToString();
            }
            NUD_Equipe3.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

        private void LBX_Chapeau4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Texte = LBX_Chapeau4.SelectedItem.ToString(), ID;
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
                TBX_Equipe4.Text = read["Nom_Equipe"].ToString();
                LBL_ImageEquipe4.Text = read["Nom_Logo_Equipe"].ToString();
                PBX_Equipe4.ImageLocation = read["Nom_Logo_Equipe"].ToString();
            }
            NUD_Equipe4.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

       

        private void B_AddGroupe_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "INSERT INTO POULE( Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4) values ('" + TBX_NomGroupe.Text + "','"+TBX_Equipe1.Text+"','"+LBL_ImageEquipe1.Text+ "','" + TBX_Equipe2.Text + "','" + LBL_ImageEquipe2.Text + "','" + TBX_Equipe3.Text + "','" + LBL_ImageEquipe3.Text + "','" + TBX_Equipe4.Text + "','" + LBL_ImageEquipe4.Text + "')";
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void LBX_Groupe1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Texte = LBX_Groupe1.SelectedItem.ToString(), ID;
            int longueur = Texte.Length;
             int i = 0, compteur = 0;

            for (i = 0; i<longueur; i++)
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


            string commandString = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4 FROM POULE WHERE ID_Groupe='" + ID + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            while (read.Read())
            {
                TBX_NomGroupe.Text = read["Libelle_Groupe"].ToString();
                TBX_Equipe1.Text = read["Libelle_Equipe1"].ToString();
                TBX_Equipe2.Text = read["Libelle_Equipe2"].ToString();
                TBX_Equipe3.Text = read["Libelle_Equipe3"].ToString();
                TBX_Equipe4.Text = read["Libelle_Equipe4"].ToString();
                
                PBX_Equipe1.ImageLocation = read["Image_Equipe1"].ToString();
                PBX_Equipe2.ImageLocation = read["Image_Equipe2"].ToString();
                PBX_Equipe3.ImageLocation = read["Image_Equipe3"].ToString();
                PBX_Equipe4.ImageLocation = read["Image_Equipe4"].ToString();

                LBL_ImageEquipe1.Text = read["Image_Equipe1"].ToString();
                LBL_ImageEquipe2.Text = read["Image_Equipe2"].ToString();
                LBL_ImageEquipe3.Text = read["Image_Equipe3"].ToString();
                LBL_ImageEquipe4.Text = read["Image_Equipe4"].ToString(); 
            }
            NUD_IDGroupe.Value = Convert.ToDecimal(ID);


            sqlCon.Close();
        }

        private void B_MajGroupe_Click(object sender, EventArgs e)
        {
            LBX_Groupe1.Items.Clear();
            {
                string connectionString7 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
                SqlConnection sqlCon7 = new SqlConnection(connectionString7);
                sqlCon7.Open();

                string commandString7 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Libelle_Equipe2, Libelle_Equipe3 , Libelle_Equipe4 FROM POULE ORDER BY ID_Groupe");
                SqlCommand sqlCmd7 = new SqlCommand(commandString7, sqlCon7);
                SqlDataReader read7 = sqlCmd7.ExecuteReader();
                while (read7.Read())
                {
                    LBX_Groupe1.Items.Add((int)read7["ID_Groupe"] + "." + (string)read7["Libelle_Groupe"]);
                }
                sqlCon7.Close();
            }
        }

        private void B_UpdateGroupe_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = "UPDATE POULE SET Libelle_Groupe = ('" + TBX_NomGroupe.Text + "'), Libelle_Equipe1 = ('" + TBX_Equipe1.Text + "'), Libelle_Equipe2 = ('" + TBX_Equipe2.Text + "'),Libelle_Equipe3 = ('" + TBX_Equipe3.Text + "'),Libelle_Equipe4 = ('" + TBX_Equipe4.Text + "'), Image_Equipe1 = ('" + LBL_ImageEquipe1.Text + "'), Image_Equipe2 = ('" + LBL_ImageEquipe2.Text + "'), Image_Equipe3=('" +LBL_ImageEquipe3.Text+ "'), Image_Equipe4=('" +LBL_ImageEquipe4.Text+ "') WHERE ID_Groupe ='" + NUD_IDGroupe.Value + "'";  // Sélectionne une ou plusieurs colonne(s) d'une table
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void B_DeleteGroupe_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();

            string commandString = ("DELETE FROM POULE WHERE ID_Groupe ='" + NUD_IDGroupe.Value + "'");
            SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
            SqlDataReader read = sqlCmd.ExecuteReader();
            sqlCon.Close();
        }

        private void B_AccesListe_Click(object sender, EventArgs e)
        {
            FRM_Liste ecran2 = new FRM_Liste();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }
    }
}

