using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFIapp
{
    public partial class Login : Form
    {
        public Login()      // Konštruktor formulára Login
        {
            InitializeComponent();      // Inicializácia komponentov formulára
        }
        // Obsluha udalosti pred zatvorením formulára
        private void Login_FormClosing(object sender, FormClosingEventArgs e)       // Obsluha udalosti pred zatvorením formulára
        {
            if ((textBoxLoginUserID.Text == "" || textBoxLoginPswd.Text == "") && this.DialogResult == DialogResult.OK)     // Skontrolovať, či sú polia prázdne pri pokuse o potvrdenie
            {
                MessageBox.Show("Vyplňte prosím polia User ID and Heslo.", "POvinné údaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);      // Zobraziť varovnú správu

                e.Cancel = true;            // Zrušiť zatvorenie formulára
            }
        }
    }
}
