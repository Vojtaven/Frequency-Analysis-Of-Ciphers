using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class LetterChanger
    {
        List<ChangedLetter> listOfChangedLetters = new List<ChangedLetter>();
        TreeViewFiller treeViewFiller;

        TreeView tvOriginalLetter;
        TreeView tvChangingLetter;

        TextBox tbIn;
        TextBox tbOut;

        private string savedOriginalLetters = "";
        private char selectedOriginalLetter;
        private char selectedChangingLetter;

        public LetterChanger(TreeView tvOriginalLetter, TreeView tvChangingLetter, TreeView TvLetterChanged, TextBox tbIn, TextBox tbOut)
        {
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
        public void SaveSelection()
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
                        listOfChangedLetters.Add(new ChangedLetter(selectedOriginalLetter, selectedChangingLetter));

                    //selectedOriginalLetter = char.MinValue;
                    //selectedChangingLetter = char.MinValue;
                    ChangeSavedOrinalLetterString();
                    ChangeTvContent();
                }
            }

        }
        private void ChangeSavedOrinalLetterString()
        {
            savedOriginalLetters = "";
            foreach (ChangedLetter item in listOfChangedLetters)
            {
                savedOriginalLetters += item.originalLetter;
            }
            ChangeTextBox();
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
                    ChangeSavedOrinalLetterString();
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

        public string GetConfiguration()
        {
            string output = "";

            foreach (ChangedLetter item in listOfChangedLetters)
            {
                output += $"{item}\n";
            }

            return output;
        }

        public void ReadConfiguration(string input)
        {
            string[] data = input.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            listOfChangedLetters.Clear();
            foreach (string item in data)
            {
                string[] temp = item.Split();
                listOfChangedLetters.Add(new ChangedLetter(temp[0][0], temp[2][0]));
            }
            ChangeSavedOrinalLetterString();
            ChangeTvContent();
        }
        private void ChangeTvContent()
        {
            treeViewFiller.TreeViewFill(listOfChangedLetters);
        }
    }

}
