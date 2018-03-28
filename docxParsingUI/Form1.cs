using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;

namespace docxParsingUI
{
    public partial class Form1 : Form
    {
        private string fichierModele;
        private string fichierDonnees;
        private string fichierDestination;
        private Dictionary<string, string> donnees = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void parcourirSourceDonnees_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirSourceDonnees = new OpenFileDialog();
            //ouvrirSourceDonnees.Filter = "Documents Excel (*.xlsx)|*.xslx";
            ouvrirSourceDonnees.Title = "Sélectionner une source de données";

            if (ouvrirSourceDonnees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceDonnees.Text = ouvrirSourceDonnees.FileName;
            }

        }

        private void parcourirModele_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirModele = new OpenFileDialog();
            ouvrirModele.Filter = "Documents Word (*.docx)|*.docx";
            ouvrirModele.Title = "Sélectionner un modèle";

            if (ouvrirModele.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceModele.Text = ouvrirModele.FileName;
            }
        }

        private void parcourirDestination_Click(object sender, EventArgs e)
        {
            SaveFileDialog ouvrirDestination = new SaveFileDialog();
            ouvrirDestination.Filter = "Documents Word (*.docx)|*.docx";
            ouvrirDestination.Title = "Sélectionner un fichier de destination";

            if (ouvrirDestination.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceDestination.Text = ouvrirDestination.FileName;
            }
        }

        private void recupererDonneesExcel(string chemin)
        {
            using (var stream = File.Open(chemin, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    var spreadsheet = result.Tables[0];
                    for (int i = 0; i < spreadsheet.Rows.Count; i++)
                    {
                        donnees.Add(spreadsheet.Rows[i][0].ToString(), spreadsheet.Rows[i][1].ToString());
                    }
                }
            }
        }

        private void boutonGenerer_Click(object sender, EventArgs e)
        {
            genererLC();
        }

        private void boutonEffacer_Click(object sender, EventArgs e)
        {
            effacerChamps();
        }

        private void générerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genererLC();
        }

        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            effacerChamps();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void genererLC()
        {
            fichierModele = sourceModele.Text;
            fichierDestination = sourceDestination.Text;
            fichierDonnees = sourceDonnees.Text;

            recupererDonneesExcel(fichierDonnees);

            DocX documentModele = DocX.Load(fichierModele);

            foreach(var item in donnees)
            {
                //documentModele.ReplaceText("{{(.*?)}}", ChercheValeur, false, RegexOptions.IgnoreCase, new Formatting(), new Formatting(), MatchFormattingOptions.SubsetMatch);
                documentModele.ReplaceText("{{" + item.Key + "}}", item.Value);
            }

            documentModele.SaveAs(fichierDestination);

            MessageBox.Show("La lettre de coopération a été générée dans le fichier " + fichierDestination, "Lettre générée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statut.Text = "La lettre de coopération a été générée dans " + fichierDestination;

            donnees.Clear();
        }
        private void effacerChamps()
        {
            if (MessageBox.Show("Voulez-vous vraiment effacer tous les champs ?", "Confirmation",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sourceDonnees.Clear();
                sourceModele.Clear();
                sourceDestination.Clear();
            }
        }

        private string ChercheValeur(string key)
        {
            if(donnees.ContainsKey(key))
            {
                return donnees[key];
            }
            return key;
        }
    }
}
