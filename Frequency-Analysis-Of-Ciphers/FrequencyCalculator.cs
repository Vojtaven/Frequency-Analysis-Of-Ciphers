using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Frequency_Analysis_Of_Ciphers
{
    class FrequencyCalculator
    {
        TextBox tbIN;
        TreeView tvVyskytVTextu;
        private List<letterfre> letterCount = new List<letterfre>();
        private List<letterfre> letterFrequency = new List<letterfre>();
        private int allLetterCount = 0;
        private bool Alphabetically = true;
        TreeViewFiller treeViewFiller;
        public FrequencyCalculator(TreeView tvfrequencyInText, TextBox tbIN, TreeView tvVyskytVTextu)
        {
            treeViewFiller = new TreeViewFiller(tvfrequencyInText); 
            this.tbIN = tbIN;
             this.tvVyskytVTextu= tvVyskytVTextu;
        }

        public void StartCalculations()
        {
            clearList();
            FindLetterCount(tbIN.Text);
            calculateFrequency();
            FrequencyTreeViewFiller(tvVyskytVTextu);
        }
        public void FindLetterCount(string text) 
        {
            text = this.RemoveDiacritics(text).ToUpper();
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    int index = letterCount.FindIndex(o => o.letter == letter);
                    if (index >= 0)
                    {
                        letterCount[index].addCount();
                    }
                    else
                    {
                        letterCount.Add(new letterfre(1, letter));
                    }
                    allLetterCount++;
                }
            }
        }
        public void sortAlphabetically()
        {
            treeViewFiller.sortAlphabetically(letterFrequency);
            Alphabetically = true;
        }
        public void sortByPercentage()
        {
            treeViewFiller.sortByPercentage(letterFrequency);
            Alphabetically = false;
        }
        public void clearList()
        {
            allLetterCount = 0;
            letterCount.Clear();
        }

        public void calculateFrequency() 
        {
            letterFrequency.Clear();
            float temp;
            for (int i = 0; i < letterCount.Count; i++)
            {
                temp = (float)Math.Round((double)(letterCount[i].getCount() / (decimal)allLetterCount) * 100, 2 , MidpointRounding.AwayFromZero);
                letterFrequency.Add(new letterfre(letterCount[i].getLetter(), temp));
            }
        
        }
        public void FrequencyTreeViewFiller(TreeView tv) 
        {
            if (Alphabetically)
                sortAlphabetically();
            else
                sortByPercentage();
        }
        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
