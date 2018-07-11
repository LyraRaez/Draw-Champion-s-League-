using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tirage_Champions_League
{
    public partial class FRM_Liste : Form
    {
        public FRM_Liste()
        {
            InitializeComponent();
        }

        private void FRM_Liste_Load(object sender, EventArgs e)
        {
            string connectionString7 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon7 = new SqlConnection(connectionString7);
            sqlCon7.Open();

            string commandString7 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=2 ");
            SqlCommand sqlCmd7 = new SqlCommand(commandString7, sqlCon7);
            SqlDataReader read7 = sqlCmd7.ExecuteReader();
            while (read7.Read())
            {
                LBL_Equipe1Groupe1.Text= read7["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe1.Text = read7["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe1.Text = read7["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe1.Text = read7["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe1.ImageLocation = read7["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe1.ImageLocation = read7["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe1.ImageLocation = read7["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe1.ImageLocation = read7["Image_Equipe4"].ToString();
            }
            sqlCon7.Close();

            string connectionString8 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon8= new SqlConnection(connectionString8);
            sqlCon8.Open();

            string commandString8 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=7 ");
            SqlCommand sqlCmd8 = new SqlCommand(commandString8, sqlCon8);
            SqlDataReader read8 = sqlCmd8.ExecuteReader();
            while (read8.Read())
            {
                LBL_Equipe1Groupe2.Text = read8["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe2.Text = read8["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe2.Text = read8["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe2.Text = read8["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe2.ImageLocation = read8["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe2.ImageLocation = read8["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe2.ImageLocation = read8["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe2.ImageLocation = read8["Image_Equipe4"].ToString();
            }
            sqlCon8.Close();

            string connectionString9 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon9 = new SqlConnection(connectionString9);
            sqlCon9.Open();

            string commandString9 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=8 ");
            SqlCommand sqlCmd9 = new SqlCommand(commandString9, sqlCon9);
            SqlDataReader read9 = sqlCmd9.ExecuteReader();
            while (read9.Read())
            {
                LBL_Equipe1Groupe3.Text = read9["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe3.Text = read9["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe3.Text = read9["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe3.Text = read9["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe3.ImageLocation = read9["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe3.ImageLocation = read9["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe3.ImageLocation = read9["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe3.ImageLocation = read9["Image_Equipe4"].ToString();
            }
            sqlCon9.Close();

            string connectionString1 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon1 = new SqlConnection(connectionString1);
            sqlCon1.Open();

            string commandString1= ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=10 ");
            SqlCommand sqlCmd1 = new SqlCommand(commandString1, sqlCon1);
            SqlDataReader read1 = sqlCmd1.ExecuteReader();
            while (read1.Read())
            {
                LBL_Equipe1Groupe4.Text = read1["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe4.Text = read1["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe4.Text = read1["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe4.Text = read1["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe4.ImageLocation = read1["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe4.ImageLocation = read1["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe4.ImageLocation = read1["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe4.ImageLocation = read1["Image_Equipe4"].ToString();
            }
            sqlCon1.Close();

            string connectionString2 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon2 = new SqlConnection(connectionString2);
            sqlCon2.Open();

            string commandString2 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=11 ");
            SqlCommand sqlCmd2 = new SqlCommand(commandString2, sqlCon2);
            SqlDataReader read2 = sqlCmd2.ExecuteReader();
            while (read2.Read())
            {
                LBL_Equipe1Groupe5.Text = read2["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe5.Text = read2["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe5.Text = read2["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe5.Text = read2["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe5.ImageLocation = read2["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe5.ImageLocation = read2["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe5.ImageLocation = read2["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe5.ImageLocation = read2["Image_Equipe4"].ToString();
            }
            sqlCon2.Close();

            string connectionString3 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon3 = new SqlConnection(connectionString3);
            sqlCon3.Open();

            string commandString3 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=12 ");
            SqlCommand sqlCmd3= new SqlCommand(commandString3, sqlCon3);
            SqlDataReader read3 = sqlCmd3.ExecuteReader();
            while (read3.Read())
            {
                LBL_Equipe1Groupe6.Text = read3["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe6.Text = read3["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe6.Text = read3["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe6.Text = read3["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe6.ImageLocation = read3["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe6.ImageLocation = read3["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe6.ImageLocation = read3["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe6.ImageLocation = read3["Image_Equipe4"].ToString();
            }
            sqlCon3.Close();

            string connectionString4 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon4 = new SqlConnection(connectionString4);
            sqlCon4.Open();

            string commandString4 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=13 ");
            SqlCommand sqlCmd4 = new SqlCommand(commandString4, sqlCon4);
            SqlDataReader read4 = sqlCmd4.ExecuteReader();
            while (read4.Read())
            {
                LBL_Equipe1Groupe7.Text = read4["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe7.Text = read4["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe7.Text = read4["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe7.Text = read4["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe7.ImageLocation = read4["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe7.ImageLocation = read4["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe7.ImageLocation = read4["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe7.ImageLocation = read4["Image_Equipe4"].ToString();
            }
            sqlCon4.Close();

            string connectionString5 = "Data Source=POSTE27-16;Initial Catalog=ChampionsLeagueAM;User ID=sa;Password=btssio;";
            SqlConnection sqlCon5 = new SqlConnection(connectionString5);
            sqlCon5.Open();

            string commandString5 = ("SELECT ID_Groupe, Libelle_Groupe, Libelle_Equipe1, Image_Equipe1, Libelle_Equipe2, Image_Equipe2, Libelle_Equipe3, Image_Equipe3, Libelle_Equipe4, Image_Equipe4  FROM POULE WHERE ID_Groupe=14 ");
            SqlCommand sqlCmd5 = new SqlCommand(commandString5, sqlCon5);
            SqlDataReader read5 = sqlCmd5.ExecuteReader();
            while (read5.Read())
            {
                LBL_Equipe1Groupe8.Text = read5["Libelle_Equipe1"].ToString();
                LBL_Equipe2Groupe8.Text = read5["Libelle_Equipe2"].ToString();
                LBL_Equipe3Groupe8.Text = read5["Libelle_Equipe3"].ToString();
                LBL_Equipe4Groupe8.Text = read5["Libelle_Equipe4"].ToString();

                PBX_Equipe1Groupe8.ImageLocation = read5["Image_Equipe1"].ToString();
                PBX_Equipe2Groupe8.ImageLocation = read5["Image_Equipe2"].ToString();
                PBX_Equipe3Groupe8.ImageLocation = read5["Image_Equipe3"].ToString();
                PBX_Equipe4Groupe8.ImageLocation = read5["Image_Equipe4"].ToString();
            }
            sqlCon5.Close();
        }

        private void PBX_Equipe1Groupe1_Click(object sender, EventArgs e)
        {

        }

        private void PBX_Equipe3Groupe1_Click(object sender, EventArgs e)
        {

        }

        private void B_Back_Click(object sender, EventArgs e)
        {
            FRM_Tirage ecran2 = new FRM_Tirage();
            ecran2.Owner = this;
            ecran2.Show();
            this.Hide();
        }
    }
}
