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
    public partial class Affectation : Form
    {
        Functions con;
        public Affectation()
        {
            InitializeComponent();
            con = new Functions();
            ShowAffectation();
        }
        private void ShowAffectation()
        {
            string Query = "SELECT * FROM الالحاق";
            DGVAffe.DataSource = con.GetData(Query);
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
        
        private void DGVAffe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtName.Text = DGVAffe.SelectedRows[0].Cells[1].Value.ToString();
            TxtN.Text = DGVAffe.SelectedRows[0].Cells[2].Value.ToString();
            TxtCombo.SelectedItem = DGVAffe.SelectedRows[0].Cells[3].Value.ToString();
            TxtDate.Text = DGVAffe.SelectedRows[0].Cells[4].Value.ToString();
            TxtApartir.Text = DGVAffe.SelectedRows[0].Cells[5].Value.ToString();
            TxtEcole.Text = DGVAffe.SelectedRows[0].Cells[6].Value.ToString();

            if (TxtName.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DGVAffe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        int key = 0;
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
                    string Query = "DELETE FROM الالحاق WHERE الرقم = @key";

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
                                ShowAffectation();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "" || TxtEcole.Text == "")

            {
                MessageBox.Show("Veuillez remplir tous les champs. ");
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
                    string TxtEco = TxtEcole.Text;
                    string Query = "INSERT INTO [الالحاق] ([الاسم], [رقم_التأجير], [الاطار], [الفترة_الزمنية], [ابتداء_من], [المؤسسة_أو_الإدارة_المستقبلة]) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}')";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtDat, TxtLic, TxtEco);
                    con.SetData(Query);
                    MessageBox.Show("Données ajoutées avec succès ! ");
                    ShowAffectation();
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
            TxtEcole.Text = "";
            TxtCombo.SelectedIndex = -1;
            TxtSearch.Text = "";
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = " الالحاق\r\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = " الأكاديمية الجهوية للتربية والتكوين لجهة العيون الساقية الحمراء - المديرية الإقليمية العيون -\r\nمصلحة الموارد البشرية والشؤون الإدارية والمالية –    مكتب الوضعيات الإدارية للموظفين\r\nشارع الأمير مولاي عبد الله ، صندوق بريد 428، العيون – الهاتف : 0528894703 – 0528893704   الفاكس : 0528892764 \r\n\r\n";
            printer.FooterSpacing = 15;
            DGVAffe.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            printer.PageSettings.Landscape = true;
            printer.PrintDataGridView(DGVAffe);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtN.Text == "" || TxtDate.Text == "" || TxtEcole.Text == "" || TxtCombo.SelectedIndex == -1 || TxtApartir.Text == "")

            {
                MessageBox.Show("Veuillez remplir tous les champs avant de modifier l'enregistrement. ");
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
                    string TxtEco = TxtEcole.Text;
                    string Query = "UPDATE الالحاق SET رقم_التأجير = N'{1}', الاطار = N'{2}', " +
                       "الفترة_الزمنية = N'{3}', ابتداء_من = N'{4}', المؤسسة_أو_الإدارة_المستقبلة = N'{5}' " +
                       "WHERE الاسم = N'{0}'";
                    Query = string.Format(Query, TxtNam, TxtNumber, TxtComb, TxtDat, TxtLic, TxtEco, key);
                    con.SetData(Query);
                    MessageBox.Show("Données Modifier avec succès ! ");
                    ShowAffectation();
                    BtnVider_Click(this, EventArgs.Empty);
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);

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
                string Query = "SELECT * FROM التفرغ_النقابي WHERE الاسم LIKE '%' + @nom + '%'";

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
                                DGVAffe.DataSource = dataTable;
                                TxtSearch.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Aucun enregistrement trouvé pour ce nom.");
                                DGVAffe.DataSource = null; // Vider le DataGridView si aucun résultat
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
    }
}
