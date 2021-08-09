using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Frequency_Analysis_Of_Ciphers
{
    class LanguageFrequency
    {

        string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        private bool alphabetically = true;
        TreeViewFiller treeViewFiller;

        List<letterfre> nowUsing;
        List<letterfre> english = new List<letterfre>();
        List<letterfre> german = new List<letterfre>();
        List<letterfre> french = new List<letterfre>();
        List<letterfre> czech = new List<letterfre>();
        List<letterfre> slovak = new List<letterfre>();

        public LanguageFrequency(TreeView tvLanguage)
        {
            treeViewFiller = new TreeViewFiller(tvLanguage);
            this.CreateLanguages();
            nowUsing = czech;
        }
        public void ChangeLanguage(string selectedLanguage)
        {
            switch (selectedLanguage.ToLower())
            {
                case "en":
                    nowUsing = english;
                    break;
                case "ge":
                    nowUsing = german;
                    break;
                case "fr":
                    nowUsing = french;
                    break;
                case "cz":
                    nowUsing = czech;
                    break;
                case "sl":
                    nowUsing = slovak;
                    break;
            }
            if (!alphabetically)
                treeViewFiller.sortByPercentage(nowUsing);
            else
            treeViewFiller.TreeViewFill(nowUsing);
        }

        public void sortAlphabetically()
        {
            alphabetically = true;
            treeViewFiller.sortAlphabetically(nowUsing);
        }
        public void sortByPercentage()
        {
            alphabetically = false;
            treeViewFiller.sortByPercentage(nowUsing);
        }

        private void CreateLanguages()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"jazyky-vyskyt.txt");
            string[] rawtextData = System.IO.File.ReadAllText(path).Split(new string[] { "\r", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < alphabet.Length; i++)
            {
                english.Add(new letterfre(alphabet[i], float.Parse(rawtextData[7 + i * 6])));
                german.Add(new letterfre(alphabet[i], float.Parse(rawtextData[8 + i * 6])));
                french.Add(new letterfre(alphabet[i], float.Parse(rawtextData[9 + i * 6])));
                czech.Add(new letterfre(alphabet[i], float.Parse(rawtextData[10 + i * 6])));
                slovak.Add(new letterfre(alphabet[i], float.Parse(rawtextData[11 + i * 6])));
            }
        }

    }
}
