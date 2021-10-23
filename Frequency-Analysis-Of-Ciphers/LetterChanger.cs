using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Frequency_Analysis_Of_Ciphers
{
    class LetterChanger
    {
        List<changedLetter> listOfChangedLetters = new List<changedLetter>();
        TreeViewFiller treeViewFiller;

        TreeView tvOriginalLetter;
        TreeView tvChangingLetter;
        TreeView TvLetterChanged;

        TextBox tbIn;
        TextBox tbOut;

        private string savedOriginalLetters = "";
        private char selectedOriginalLetter;
        private char selectedChangingLetter;

        public LetterChanger(TreeView tvOriginalLetter, TreeView tvChangingLetter, TreeView TvLetterChanged, TextBox tbIn, TextBox tbOut)
        {
            this.TvLetterChanged = TvLetterChanged;
            this.tvOriginalLetter = tvOriginalLetter;
            this.tvChangingLetter = tvChangingLetter;
            this.tbIn = tbIn;
            this.tbOut = tbOut;
            treeViewFiller = new TreeViewFiller(TvLetterChanged);
        }
        public void LetterChange()
        {
            selectedOriginalLetter = tvOriginalLetter.SelectedNode.Text[0];
            selectedChangingLetter = tvChangingLetter.SelectedNode.Text[0];
            ChangeTextBox();
        }
        public void ChangeTextBox()
        {
            string tempText = "";
            string textIn = RemoveDiacritics(tbIn.Text);
            foreach (char c in textIn)
            {
                char cUp = char.ToUpper(c);
                if (cUp == selectedOriginalLetter)
                    tempText += selectedChangingLetter;
                else if (savedOriginalLetters.Contains(cUp))
                    tempText += listOfChangedLetters[savedOriginalLetters.IndexOf(cUp)].changingLetter;
                else if (char.IsLetter(c))
                    tempText += '*';
                else
                    tempText += c;
            }
            tbOut.Text = tempText;
        }
        public void saveSelection()
        {
            if (selectedChangingLetter != char.MinValue)   //Ověří že se nejedná o špatný znak
            {
                if (selectedOriginalLetter != char.MinValue)
                {
                    bool addToList = true;
                    if (listOfChangedLetters.Count != 0)   //Zkontroluje jestli zž kombinace není v listu a když tak jí změní
                    {
                        for (int i = 0; i < listOfChangedLetters.Count; i++)
                        {
                            if (listOfChangedLetters[i].originalLetter == selectedOriginalLetter)
                            {
                                if (addToList)
                                {
                                    addToList = false;
                                    listOfChangedLetters[i].changingLetter = selectedChangingLetter;
                                }
                                else
                                {
                                    listOfChangedLetters.RemoveAt(i);
                                }

                            }
                            else if (listOfChangedLetters[i].changingLetter == selectedChangingLetter)
                            {
                                if (addToList)
                                {
                                    addToList = false;
                                    listOfChangedLetters[i].originalLetter = selectedOriginalLetter;
                                }
                                else
                                {
                                    listOfChangedLetters.RemoveAt(i);
                                }
                            }
                        }
                    }


                    if (addToList)
                        listOfChangedLetters.Add(new changedLetter(selectedOriginalLetter, selectedChangingLetter));

                    selectedOriginalLetter = char.MinValue;
                    selectedChangingLetter = char.MinValue;
                    changeSavedOrinalLetterString();
                    ChangeTvContent();
                }
            }
        }
        private void changeSavedOrinalLetterString()
        {
            savedOriginalLetters = "";
            foreach (changedLetter item in listOfChangedLetters)
            {
                savedOriginalLetters += item.originalLetter;
            }
        }
        public void ClearSavedSelections()
        {
            savedOriginalLetters = "";
            listOfChangedLetters.Clear();
            ChangeTextBox();
            ChangeTvContent();
        }

        public void RemoveLetterCouple(string coupleToRemove)
        {
            for (int i = 0; i < listOfChangedLetters.Count; i++)
            {
                if (coupleToRemove == listOfChangedLetters[i].ToString())
                {
                    listOfChangedLetters.RemoveAt(i);
                    changeSavedOrinalLetterString();
                    break;
                }
            }
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
        private void ChangeTvContent()
        {
            treeViewFiller.TreeViewFill(listOfChangedLetters);
        }
    }

}
