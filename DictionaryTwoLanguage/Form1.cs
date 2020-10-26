using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryTwoLanguage
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> germanToEnglishDictionary = new Dictionary<string, List<string>>();
        string csvFile = @"C:\Users\DCV\Desktop\dic.csv";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(csvFile))
            {
                readCSV(csvFile);
                UpdateTranslations();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGerman.Text;
            var englishWord = tbEnglish.Text;
            var turkishWord = tbTurkish.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord) || !string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(turkishWord))
            {
                germanToEnglishDictionary.Add(germanWord, new List<string> { englishWord, turkishWord });
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            lBoxGermanWords.DataSource = germanToEnglishDictionary.Keys.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var textSearch = tbSearch.Text;
            if (germanToEnglishDictionary.ContainsKey(textSearch))
            {
                List<string> listSearch = new List<string>();
                if (germanToEnglishDictionary.TryGetValue(textSearch, out listSearch))
                {
                    tbFindEN.Text = listSearch[0];
                    tbFindTR.Text = listSearch[1];
                }
            }
            else
            {
                tbFindEN.Text = "no luck";
                tbFindTR.Text = "no tienes suerte";
            }
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            var words = germanToEnglishDictionary;
            String csv = String.Join(
                Environment.NewLine,
                germanToEnglishDictionary.Select(d => $"{d.Key};{d.Value[0]};{d.Value[1]};"));
            System.IO.File.AppendAllText(@"C:\Users\DCV\Desktop\dic.csv", csv.ToString());
        }

        public string[][] readCSV(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            string[][] result = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].Split(';');
                var germanWord = result[i].ElementAt(0);
                var englishWord = result[i].ElementAt(1);
                var turkishWord = result[i].ElementAt(2);
                if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
                {
                    germanToEnglishDictionary.Add(germanWord, new List<string> { englishWord, turkishWord });
                }
            }
            return result;
        }

        private void tbFindTR_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
