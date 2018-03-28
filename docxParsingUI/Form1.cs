using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docxParsingUI
{
    public partial class Form1 : Form
    {
        private string fichierModele;
        private string fichierDonnees;
        private string fichierDestination;
        public Form1()
        {
            InitializeComponent();
        }

        private void parcourirSourceDonnees_Click(object sender, EventArgs e)
        {
            OpenFileDialog ouvrirSourceDonnees = new OpenFileDialog();
            ouvrirSourceDonnees.Filter = "";
            ouvrirSourceDonnees.Title = "Sélectionner une source de données";

            if (ouvrirSourceDonnees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sourceModele.Text = ouvrirSourceDonnees.FileName;
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
            
            MessageBox.Show("La lettre de coopération a été générée dans le fichier " + fichierDestination, "Lettre générée", MessageBoxButtons.OK);
            statut.Text = "La lettre de coopération a été générée dans " + fichierDestination;
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
    }
}
