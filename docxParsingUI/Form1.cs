using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lot1
{
    public partial class Form1 : Form
    {
        private HttpClient client = new HttpClient();
        private AutoCompleteStringCollection villes = new AutoCompleteStringCollection();
        public Form1()
        {
            InitializeComponent();
            date.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabControl1.SelectedIndex + 1);
        }

        private async void cp_TextChanged(object sender, EventArgs e)
        {
            if(cp.Text == "")
            {
                ville.Items.Clear();
            }

            if(cp.Text.Length == 5)
            {
                HttpResponseMessage reponse = await client.GetAsync("https://geo.api.gouv.fr/communes?codePostal=" + cp.Text);
                string json = await reponse.Content.ReadAsStringAsync();
                //WebClient test = new WebClient();
                //string json = test.DownloadString("https://geo.api.gouv.fr/communes?codePostal=" + cp.Text);
                List<Ville> listeVilles = JsonConvert.DeserializeObject<List<Ville>>(json);
                foreach (var item in listeVilles)
                {
                    //villes.Add(item.nom.ToUpper());
                    ville.Items.Add(item.nom.ToUpper());
                }
                //ville.Items.
                /*ville.AutoCompleteCustomSource = villes;
                ville.AutoCompleteMode = AutoCompleteMode.Suggest;
                ville.AutoCompleteSource = AutoCompleteSource.CustomSource;*/
                ville.SelectedIndex = 0;

            }
        }

        private async void ville_TextChangedAsync(object sender, EventArgs e)
        {
            /*if(ville.Text.Length > 4)
            {
                HttpResponseMessage reponse = await client.GetAsync("https://geo.api.gouv.fr/communes?nom=" + ville.Text);
                string json = await reponse.Content.ReadAsStringAsync();
                List<Commune> listeCommunes = JsonConvert.DeserializeObject<List<Commune>>(json);
                foreach (var item in listeCommunes)
                {
                    villes.Add(item.nom.ToUpper());
                }

                ville.AutoCompleteCustomSource = villes;
                ville.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ville.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }*/
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            chargerdonnees();
            
        }
        private void chargerdonnees()
        {
            OpenFileDialog ouvrirSourceDonnees = new OpenFileDialog();
            ouvrirSourceDonnees.Filter = "Documents Excel (*.xlsx)|*.xlsx";
            ouvrirSourceDonnees.Title = "Sélectionner une source de données";

            if (ouvrirSourceDonnees.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var stream = File.Open(ouvrirSourceDonnees.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();
                        var spreadsheet = result.Tables[0];
                        for (int i = 0; i < spreadsheet.Columns.Count; i++)
                        {
                            //MessageBox.Show(spreadsheet.Rows[0][i].ToString(), spreadsheet.Rows[0][0].ToString());

                            nom.Text = spreadsheet.Rows[1][3].ToString();

                            prenom.Text = spreadsheet.Rows[1][4].ToString();


                            fonction.Text = spreadsheet.Rows[1][5].ToString();


                            textBox1.Text = spreadsheet.Rows[1][6].ToString();
                            numericUpDown1.Text = spreadsheet.Rows[1][7].ToString();
                            textBox2.Text = spreadsheet.Rows[1][8].ToString();
                            numericUpDown2.Text = spreadsheet.Rows[1][9].ToString();



                        }
                    }
                }
            }
        }

        private void ouvrirUnFichierClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chargerdonnees();
        }
    }

    public class Ville
    {
        public string nom { get; set; }
        public string code { get; set; }
        public string codeDepartement { get; set; }
        public string codeRegion { get; set; }
        public List<string> codesPostaux { get; set; }
        public int population { get; set; }
    }

    public class Commune
    {
        public string nom { get; set; }
        public string code { get; set; }
        public string codeDepartement { get; set; }
        public string codeRegion { get; set; }
        public List<string> codesPostaux { get; set; }
        public int population { get; set; }
        public double _score { get; set; }
    }
}
