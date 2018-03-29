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
        /// <summary>
        /// Contient le chemin du fichier de modèle LC
        /// </summary>
        private string fichierModele;

        /// <summary>
        /// Contient le chemin du fichier avec les informations sur l'entreprise du client
        /// </summary>
        private string fichierDonnees;

        /// <summary>
        /// Contient le chemin du fichier de destination
        /// </summary>
        private string fichierDestination;

        /// <summary>
        /// Les informations du client y sont stockées 
        /// </summary>
        private Dictionary<string, string> donnees = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ouvre une boîte de dialogue pour sélectionner le fichier de données client
        /// </summary>
        private void parcourirSourceDonnees_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirSourceDonnees = new OpenFileDialog();
            ouvrirSourceDonnees.Filter = "Documents Excel (*.xlsx)|*.xlsx";
            ouvrirSourceDonnees.Title = "Sélectionner une source de données";

            if (ouvrirSourceDonnees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceDonnees.Text = ouvrirSourceDonnees.FileName;
            }

        }

        /// <summary>
        /// Ouvre une boîte de dialogue pour sélectionner le fichier de modèle LC
        /// </summary>
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

        /// <summary>
        /// Ouvre une boîte de dialogue pour sélectionner le fichier de destination et le créer s'il n'existe pas
        /// </summary>
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

        /// <summary>
        /// Extrait les données du fichier client
        /// </summary>
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

        /// <summary>
        /// Génère la LC
        /// </summary>
        private void boutonGenerer_Click(object sender, EventArgs e)
        {
            fichierModele = sourceModele.Text;
            fichierDestination = sourceDestination.Text;
            fichierDonnees = sourceDonnees.Text;
            if (String.IsNullOrEmpty(fichierDonnees))
            {
                MessageBox.Show("Le champ du fichier de données est vide.", "Le champ du fichier de données est vide.", MessageBoxButtons.OK);
                return;
            }
            else if (String.IsNullOrEmpty(fichierModele))
            {
                MessageBox.Show("Le champ du fichier modèle est vide.", "Le champ du fichier modèle est vide.", MessageBoxButtons.OK);
                return;
            }

            else if (String.IsNullOrEmpty(fichierDestination))
            {
                MessageBox.Show("Le champ du fichier de destination est vide.", "Le champ du fichier destination est vide.", MessageBoxButtons.OK);
                return;
            }


            if (!File.Exists(fichierModele))
            {
                MessageBox.Show("Le fichier modèle n' existe pas.", "Le fichier modèle n' existe pas.", MessageBoxButtons.OK);
                return;
            }
            else if (!File.Exists(fichierDonnees))
            {
                MessageBox.Show("Le fichier de données n' existe pas.", "Le fichier de données n' existe pas.", MessageBoxButtons.OK);
                return;
            }

            genererLC();
        }

        /// <summary>
        /// Efface les champs
        /// </summary>
        private void boutonEffacer_Click(object sender, EventArgs e)
        {
            effacerChamps();
        }

        /// <summary>
        /// Génère la LC
        /// </summary>
        private void générerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genererLC();
        }

        /// <summary>
        /// Efface  les champs
        /// </summary>
        private void effacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            effacerChamps();
        }

        /// <summary>
        /// Permet de quitter l'application
        /// </summary>
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary> 
        /// Fonction de génération d'une LC
        /// </summary>
        private void genererLC()
        {

            fichierModele = sourceModele.Text;
            fichierDestination = sourceDestination.Text;
            fichierDonnees = sourceDonnees.Text;

            
            
            recupererDonneesExcel(fichierDonnees);

            


            DocX documentModele = DocX.Load(fichierModele);

            foreach(var item in donnees)
            {
                //documentModele.ReplaceText("{{(.*?)}}", ChercheValeur, false, RegexOptions.IgnoreCase | RegexOptions.Multiline, new Formatting(), new Formatting(), MatchFormattingOptions.SubsetMatch);
                documentModele.ReplaceText("{{" + item.Key + "}}", item.Value);
            }

            documentModele.SaveAs(fichierDestination);

            MessageBox.Show("La lettre de coopération a été générée dans le fichier " + fichierDestination, "Lettre générée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            statut.Text = "La lettre de coopération a été générée dans " + fichierDestination;

            donnees.Clear();
        }

        /// <summary>
        /// Affiche une boîte de dialogue et efface les champs
        /// </summary>
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

        /// <summary>
        /// Récupère une valeur du Dictionnary en fonction de la clé
        /// </summary>
        private string ChercheValeur(string key)
        {
            if(donnees.ContainsKey(key))
            {
                return donnees[key];
            }
            return key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
