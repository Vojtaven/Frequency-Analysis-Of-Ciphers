using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class FrequencyCalculator
    {
        TextBox tbIN;
        private readonly List<letterfre> letterFrequency = new List<letterfre>();
        private int allLetterCount = 0;
        private bool Alphabetically = true;
        TreeViewFiller treeViewFiller;
        public FrequencyCalculator(TreeView tvfrequencyInText, TextBox tbIN)
        {
            treeViewFiller = new TreeViewFiller(tvfrequencyInText);
            this.tbIN = tbIN;
        }

        public void StartCalculations()
        {
            ClearList();
            FindLetterCount(tbIN.Text);
            CalculateFrequency();
            FrequencyTreeViewFiller();
        }
        public void FindLetterCount(string text)
        {
            text = this.RemoveDiacritics(text).ToUpper();
            foreach (char letter in text)
            {
                if (char.IsLetter(letter))
                {
                    int index = letterFrequency.FindIndex(o => o.letter == letter);
                    if (index >= 0)
                    {
                        letterFrequency[index].AddCount();
                    }
                    else
                    {
                        letterFrequency.Add(new letterfre(1, letter));
                    }
                    allLetterCount++;
                }
            }
        }
        public void SortAlphabetically()
        {
            treeViewFiller.SortAlphabetically(letterFrequency);
            Alphabetically = true;
        }
        public void SortByPercentage()
        {
            treeViewFiller.SortByPercentage(letterFrequency);
            Alphabetically = false;
        }
        public void ClearList()
        {
            allLetterCount = 0;
            letterFrequency.Clear();
        }

        public void CalculateFrequency()
        {
            for (int i = 0; i < letterFrequency.Count; i++)
            {
                letterFrequency[i].CalculateFrequency(allLetterCount);
            }
        }
        public void FrequencyTreeViewFiller()
        {
            if (Alphabetically)
                SortAlphabetically();
            else
                SortByPercentage();
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
