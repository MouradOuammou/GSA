using DGVPrinterHelper;
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

namespace Projet.Forms
{
    public partial class Licenses : Form
    {
        Functions con;

        public Licenses()
        {
            InitializeComponent();
            con = new Functions();
            ShowLic();

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

        }
        private void ShowLic()
        {
            string Query = "select * from الرخص ";

            DGVLic.DataSource = con.GetData(Query);
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRecherche_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
            {
                MessageBox.Show("Veuillez entrer un nom à rechercher.");
                return;
            }

            try
            {
                // Définir la requête SQL pour la table الرخص
                string Query = "SELECT * FROM الرخص WHERE الاسم LIKE '%' + @nom + '%'";

                using (SqlConnection connection = new SqlConnection("Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True"))
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        // Ajouter le paramètre avec la valeur de recherche
                        command.Parameters.AddWithValue("@nom", TxtSearch.Text.Trim());

                        // Ouvrir la connexion
                        connection.Open();

                        // Exécuter la commande et remplir le DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Vérifier si des enregistrements ont été trouvés
                            if (dataTable.Rows.Count > 0)
                            {
                                DGVLic.DataSource = dataTable; // Afficher les résultats dans le DataGridView
                                TxtSearch.Text = ""; // Réinitialiser le champ de recherche
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé pour ce nom.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtObser.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
            else
            {
                try
                {
                    string TxtNam = TxtName.Text;
                    string TxtNumber = TxtN.Text;
                    string TxtComb = TxtCombo.SelectedItem.ToString();
                    string TxtDat = TxtDate.Text;
                    string TxtLic = TxtApartir.Text;
                    string TxtObs = TxtObser.Text;
                    string Query = "INSERT INTO [الرخص] ([الاسم], [رقم_التأجير], [الاطار], [الرخصة_طبيعة], [مدتها], [ملاحظات]) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtDat, TxtLic, TxtObs);
                    con.SetData(Query);
                    MessageBox.Show("Données ajoutées avec succès !");
                    ShowLic();
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;

        private void BtnMod_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" ||
  TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtObser.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de modifier l'enregistrement.");
            }
            else
            {
                try
                {
                    string TxtNam = TxtName.Text;
                    string TxtNumber = TxtN.Text;
                    string TxtComb = TxtCombo.SelectedItem.ToString();
                    string TxtDat = TxtDate.Text; // Correspond à مدتها
                    string TxtLic = TxtApartir.Text;
                    string TxtObs = TxtObser.Text;  // Correspond à ملاحظات

                    string Query = "UPDATE الرخص SET رقم_التأجير = N'{1}', الاطار = N'{2}', " +
                        "الرخصة_طبيعة = N'{3}', مدتها = N'{4}', ملاحظات = N'{5}' " +
                        "WHERE الاسم = N'{0}'";

                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtLic, TxtDat, TxtObs);
                    con.SetData(Query); // Assurez-vous que con est bien initialisé
                    MessageBox.Show("Données modifiées avec succès !");
                    ShowLic();
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtN.Text = "";
            TxtDate.Text = "";
            TxtApartir.Text = "";
            TxtCombo.SelectedIndex = -1;
            TxtSearch.Text = "";
            TxtObser.Text = "";
        }
        private void BtnImp_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = " الرخص\n\n\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = " الأكاديمية الجهوية للتربية والتكوين لجهة العيون الساقية الحمراء - المديرية الإقليمية العيون -\r\nمصلحة الموارد البشرية والشؤون الإدارية والمالية –    مكتب الوضعيات الإدارية للموظفين\r\nشارع الأمير مولاي عبد الله ، صندوق بريد 428، العيون – الهاتف : 0528894703 – 0528893704   الفاكس : 0528892764 \r\n\r\n";
            printer.FooterSpacing = 15;
            DGVLic.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            printer.PageSettings.Landscape = true;
            printer.PrintDataGridView(DGVLic);
        }


        private void BtnSupp_Click(object sender, EventArgs e)
        {
            if (key == 0) // Assurez-vous que 'key' correspond à l'enregistrement à supprimer
            {
                MessageBox.Show("Sélectionnez un élément à supprimer !");
            }
            else
            {
                try
                {
                    string Query = "DELETE FROM الرخص WHERE الرقم = @id";

                    using (SqlConnection connection = new SqlConnection("Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True;"))
                    {
                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@id", key); // 'key' doit être l'identifiant de l'enregistrement à supprimer

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Supprimé avec succès !");
                                BtnVider_Click(this, EventArgs.Empty);
                                ShowLic(); // Méthode pour rafraîchir le DataGridView
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé avec cet identifiant.");
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }
      
        private void DGVLic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = DGVLic.SelectedRows[0].Cells[1].Value.ToString();
            TxtN.Text = DGVLic.SelectedRows[0].Cells[2].Value.ToString();
            TxtCombo.Text = DGVLic.SelectedRows[0].Cells[3].Value.ToString();
            TxtApartir.Text = DGVLic.SelectedRows[0].Cells[4].Value.ToString();
            TxtDate.Text = DGVLic.SelectedRows[0].Cells[5].Value.ToString();
            TxtObser.Text = DGVLic.SelectedRows[0].Cells[6].Value.ToString();
            if (TxtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVLic.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Licenses_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

    }
}
