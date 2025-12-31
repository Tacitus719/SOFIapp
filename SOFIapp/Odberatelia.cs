using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace SOFIapp
{
    public partial class Odberatelia : Form
    {
        OracleConnection spojenie;
        OracleDataAdapter adapter;
        OracleCommand sqlCommand;
        DataSet dataSet;

        public Odberatelia(OracleConnection funkcneSpojenie)
        {
            InitializeComponent();
            spojenie = funkcneSpojenie;         // Priradenie funkčného pripojenia OracleConnection

            dataSet = new DataSet();        // Vytvorenie inštancie DataSet


        }

        private void Odberatelia_Load(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT * FROM XLOJ_ODBERATELIA";      // SQL dotaz na výber všetkých záznamov z tabuľky ODOBERATELIA
                sqlCommand = new OracleCommand(sql, spojenie);      // Vytvorenie inštancie OracleCommand s SQL dotazom a pripojením
                adapter = new OracleDataAdapter(sqlCommand);      // Vytvorenie inštancie OracleDataAdapter s OracleCommand
                adapter.Fill(dataSet, "Odberatelia");      // Naplnenie DataSet údajmi z databázy
                dataGridViewOdberatelia.DataSource = dataSet.Tables["Odberatelia"];      // Nastavenie zdroja údajov DataGridView na tabuľku "Odberatelia" v DataSet
           
                Odberatelia.ActiveForm.Text = "Odberatelia - počet záznamov: " + dataSet.Tables["Odberatelia"].Rows.Count;      // Nastavenie textu formulára na počet záznamov
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pri načítaní údajov: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxOdberateliaEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewOdberatelia_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridViewOdberatelia.SelectedRows.Count > 0)
            {
                int currentIndex = dataGridViewOdberatelia.CurrentRow.Index;      // Získanie indexu aktuálne vybratej riadky
                    Odberatelia.ActiveForm.Text = "Odberatelia - počet záznamov: " + dataSet.Tables["Odberatelia"].Rows.Count + " - Aktuálny záznam: " + (currentIndex + 1);      // Aktualizácia textu formulára s aktuálnym záznamom
                
                textBoxOdberateliaNazov.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["NAZOV"].Value.ToString();      // Zobrazenie názvu odberateľa v textovom poli
                textBoxOdberateliaAdresa.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["ADRESA"].Value.ToString();      // Zobrazenie adresy odberateľa v textovom poli
                textBoxOdberateliaPSC.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["PSC"].Value.ToString();      // Zobrazenie PSČ odberateľa v textovom poli
                textBoxOdberateliaMesto.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["MESTO"].Value.ToString();      // Zobrazenie mesta odberateľa v textovom poli
                textBoxOdberateliaEmail.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["EMAIL"].Value.ToString();      // Zobrazenie emailu odberateľa v textovom poli
                textBox1.Text = dataGridViewOdberatelia.SelectedRows[0].Cells["TELEFON"].Value.ToString();      // Zobrazenie telefónneho čísla odberateľa v textovom poli
            }
        }

        private void buttonOdberateliaVymazat_Click(object sender, EventArgs e)
        {
            try 
            {

                DialogResult potvrdenie = MessageBox.Show("Naozaj chcete vymazať tento záznam?", "Potvrdenie mazania", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);      // Zobrazenie dialógového okna na potvrdenie mazania
                if (potvrdenie != DialogResult.Yes)
                {
                    return;      // Ak používateľ nezvolí "Yes", ukončiť metódu
                }

                string deleteSql = "DELETE FROM XLOJ_ODBERATELIA WHERE ODBERATEL_ID = :id";      // SQL dotaz na vymazanie záznamu podľa ID_ODBERATELA

                sqlCommand = new OracleCommand(deleteSql, spojenie);                                // Vytvorenie inštancie OracleCommand s SQL dotazom a pripojením

                int currentIndex = dataGridViewOdberatelia.CurrentRow.Index;                            // Získanie indexu aktuálne vybratej riadky
                int idOdberatela = Convert.ToInt32(dataGridViewOdberatelia.SelectedRows[0].Cells["ODBERATEL_ID"].Value);      // Získanie ID_ODBERATELA z vybratej riadky
                sqlCommand.Parameters.Add(new OracleParameter("id", idOdberatela));                     // Pridanie parametra ID_ODBERATELA do SQL dotazu
                int rowsAffected = sqlCommand.ExecuteNonQuery();                                        // Vykonanie SQL dotazu na vymazanie záznamu
                if (rowsAffected > 0)
                {
                    dataSet.Tables["Odberatelia"].Rows.RemoveAt(currentIndex);      // Odstránenie záznamu z DataSet
                    Odberatelia.ActiveForm.Text = "Odberatelia - počet záznamov: " + dataSet.Tables["Odberatelia"].Rows.Count;      // Aktualizácia textu formulára s počtom záznamov
                    MessageBox.Show("Záznam bol úspešne vymazaný.", "Úspech", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Záznam sa nepodarilo vymazať.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba pri mazaní záznamu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Obnovenie údajov v DataGridView po vymazaní záznamu
            dataSet.Tables["Odberatelia"].Clear();      // Vyčistenie tabuľky "Odberatelia" v DataSet
            adapter.Fill(dataSet, "Odberatelia");      // Opätovné naplnenie DataSet údajmi z databázy
        }
    }
}
