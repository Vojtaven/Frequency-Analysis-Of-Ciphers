using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class LetterChanger
    {
        List<changedLetter> listOfChangedLetters = new List<changedLetter>();
        TreeView tvOriginalLetter;
        TreeView tvChangingLetter;
        TextBox tbIn;
        TextBox tbOut;
        private string savedOriginalLetters = "";
        private char selectedOriginalLetter;
        private char selectedChangingLetter;
        public LetterChanger(TreeView tvOriginalLetter,TreeView tvChangingLetter,TextBox tbIn,TextBox tbOut) 
        {
            this.tvOriginalLetter = tvOriginalLetter;
            this.tvChangingLetter = tvChangingLetter;
            this.tbIn = tbIn;
            this.tbOut = tbOut;
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
            foreach (char c in tbIn.Text)
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
            if (selectedChangingLetter != char.MinValue)
            {
                if (selectedOriginalLetter != char.MinValue)
                {
                    bool addToList = true;
                    if (listOfChangedLetters.Count != 0)
                    {
                        for (int i = 0; i < listOfChangedLetters.Count; i++)
                        {
                            if (listOfChangedLetters[i].originalLetter == selectedOriginalLetter)
                            {
                                addToList = false;
                                listOfChangedLetters[i].changingLetter = selectedChangingLetter;
                            }
                            else if (listOfChangedLetters[i].changingLetter == selectedChangingLetter)
                            {
                                addToList = false;
                                listOfChangedLetters[i].originalLetter = selectedOriginalLetter;
                            }
                        }
                    }
                    if (addToList)
                        listOfChangedLetters.Add(new changedLetter(selectedOriginalLetter, selectedChangingLetter));

                    selectedOriginalLetter = char.MinValue;
                    selectedChangingLetter = char.MinValue;
                    changeSavedOrinalLetterString();
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
        }
    }
    class changedLetter
    {
        public char originalLetter;
        public char changingLetter;
        public changedLetter(char originalLetter,char changingLetter)
        {
            this.changingLetter = changingLetter;
            this.originalLetter = originalLetter;
        }
    }
}
