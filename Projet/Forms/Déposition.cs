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

namespace Projet
{
    public partial class Déposition : Form
    {
        Functions con;
        public Déposition()
        {
            InitializeComponent();
            con = new Functions();
            ShowDep();
        }
        private void ShowDep()
        {
            string Query = "select * from الاستيداع";

            DGVDep.DataSource = con.GetData(Query);


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


        private void Déposition_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        int key = 0;
        private void DGVExe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = DGVDep.SelectedRows[0].Cells[1].Value.ToString();
            TxtN.Text = DGVDep.SelectedRows[0].Cells[2].Value.ToString();
            TxtCombo.Text = DGVDep.SelectedRows[0].Cells[3].Value.ToString();
            TxtApartir.Text = DGVDep.SelectedRows[0].Cells[4].Value.ToString();
            TxtTemp.Text = DGVDep.SelectedRows[0].Cells[5].Value.ToString();
            TxtCause.Text = DGVDep.SelectedRows[0].Cells[6].Value.ToString();
            TxtEcole.Text = DGVDep.SelectedRows[0].Cells[7].Value.ToString();
            TxtObser.Text = DGVDep.SelectedRows[0].Cells[8].Value.ToString();

            if (TxtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVDep.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (TxtName.Text == "" || TxtN.Text == "" || TxtEcole.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtTemp.Text == "" || TxtObser.Text == "" || TxtCause.Text == "")
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
                    string TxtLic = TxtApartir.Text;
                    string TxtEco = TxtEcole.Text;
                    string TxtTem = TxtTemp.Text;
                    string TxtObse = TxtObser.Text;
                    string TxtCaus = TxtCause.Text;

                    // Requête SQL pour insérer les données dans le tableau الاستيداع
                    string Query = "INSERT INTO [الاستيداع] ([الاسم], [رقم_التاجير], [الإطار], [ابتداء_من], [مدة_الاستيداع], [سبب_الاستيداع], [المؤسسة], [ملاحظات]) " +
                                   "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtLic, TxtTem, TxtCaus, TxtEco, TxtObse);
                    con.SetData(Query);
                    MessageBox.Show("Données ajoutées avec succès !");
                    ShowDep(); // Utiliser la fonction correspondante pour le tableau الاستيداع

                    // Réinitialisation des champs
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    // Affichage d'un message d'erreur
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (TxtName.Text == "" || TxtN.Text == "" || TxtEcole.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtTemp.Text == "" || TxtCause.Text == "")
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
                    string TxtLic = TxtApartir.Text;
                    string TxtEco = TxtEcole.Text;
                    string TxtTem = TxtTemp.Text;
                    string TxtObse = TxtObser.Text;
                    string TxtCaus = TxtCause.Text;
                    string Query = "UPDATE الاستيداع SET رقم_التاجير = N'{1}', الإطار = N'{2}', " +
                                   "ابتداء_من = N'{3}', مدة_الاستيداع = N'{4}', سبب_الاستيداع = N'{5}', المؤسسة = N'{6}' " +
                                   "WHERE الاسم = N'{0}'";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtLic, TxtTem, TxtCaus, TxtCaus);
                    con.SetData(Query);
                    MessageBox.Show("Données modifiées avec succès !");
                    ShowDep();

                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {
                    // Affichage d'un message d'erreur
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            TxtApartir.Text = "";
            TxtCause.Text = "";
            TxtCombo.SelectedIndex = -1;
            TxtN.Text = "";
            TxtName.Text = "";
            TxtObser.Text = "";
            TxtEcole.Text = "";
            TxtN.Text = "";
            TxtTemp.Text = "";
            TxtSearch.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Sélectionnez un élément !");
            }
            else
            {
                try
                {
                    string Query = "DELETE FROM الاستيداع WHERE المعرف = @key";

                    using (SqlConnection connection = new SqlConnection("Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True;"))
                    {
                        using (SqlCommand command = new SqlCommand(Query, connection))
                        {
                            command.Parameters.AddWithValue("@key", key);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Supprimé avec succès !");
                                ShowDep();
                                BtnVider_Click(this, EventArgs.Empty);
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé avec cet identifiant.");
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Erreur : " + Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
            {
                MessageBox.Show("Veuillez entrer un nom à rechercher.");
                return;
            }

            try
            {
                string Query = "SELECT * FROM الاستيداع WHERE الاسم LIKE '%' + @nom + '%'";

                using (SqlConnection connection = new SqlConnection("Data Source=PCHP;Initial Catalog=GestionDR;Integrated Security=True;"))
                {
                    using (SqlCommand command = new SqlCommand(Query, connection))
                    {
                        command.Parameters.AddWithValue("@nom", TxtSearch.Text.Trim());

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                DGVDep.DataSource = dataTable;
                                TxtSearch.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé pour ce nom.");
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erreur : " + Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "الاستيداع ";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = " الأكاديمية الجهوية للتربية والتكوين لجهة العيون الساقية الحمراء - المديرية الإقليمية العيون -\r\nمصلحة الموارد البشرية والشؤون الإدارية والمالية –    مكتب الوضعيات الإدارية للموظفين\r\nشارع الأمير مولاي عبد الله ، صندوق بريد 428، العيون – الهاتف : 0528894703 – 0528893704   الفاكس : 0528892764 \r\n\r\n";
            printer.FooterSpacing = 15;
            DGVDep.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            printer.PageSettings.Landscape = true;
            printer.PrintDataGridView(DGVDep);
        }
    }
}
