using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFIapp
{
    public partial class MainForm : Form
    {

        OracleConnection spojenie;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
           try
                {   spojenie = new OracleConnection();      // Vytvorenie inštancie OracleConnection
                    Login loginForm = new Login();      // Vytvorenie inštancie formulára Login
                    if (loginForm.ShowDialog() != DialogResult.OK)      // Zobrazenie formulára Login a kontrola výsledku
                    {
                        this.Close();      // Zatvorenie hlavného formulára, ak používateľ zruší prihlásenie
                        return;
                     }
                
                
                string userLogin = loginForm.textBoxLoginUserID.Text.Trim();         // získanie prihlasovacích údajov z formulára Login » textBoxLogin Trim() oreže medzeru alebo biele miesta 
                string userPassword = loginForm.textBoxLoginPswd.Text;        // získanie prihlasovacích údajov z formulára Login » textBoxPwd

                spojenie.ConnectionString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=147.175.227.41)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=student)));" +
                    $"User Id={userLogin};Password={userPassword};";  // použitie zadaných prihlasovacích údajov

            


                spojenie.Open();        // Pokus o otvorenie pripojenia

                if (spojenie.State == ConnectionState.Open)
                {
                    MessageBox.Show("Pripojenie k databáze bolo úspešné.", "Pripojenie úspešné", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm.ActiveForm.Text = $"{MainForm.ActiveForm.Text} - prihlásený ako {userLogin}";
                }
                else
                {
                    MessageBox.Show("Nepodarilo sa pripojiť k databáze.", "Chyba pripojenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    MainForm.ActiveForm.Text = "SOFI app - neprihlásený používateľ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pri vytváraní pripojenia: " + ex.Message, "Chyba pripojenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)      // Obsluha udalosti po zatvorení formulára
        {
            spojenie.Close();
        }

        private void odberateliaToolStripMenuItem_Click(object sender, EventArgs e)     // Obsluha udalosti kliknutia na položku ponuky "Odberatelia"
        {
            Odberatelia odberateliaForm = new Odberatelia(spojenie);
            odberateliaForm.MdiParent = this;      // Nastavenie hlavného formulára ako rodičovského formulára
            odberateliaForm.Show();      // Zobrazenie formulára Odberatelia
        }
    }
}
