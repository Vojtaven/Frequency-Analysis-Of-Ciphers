using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace Frequency_Analysis_Of_Ciphers
{

    public partial class Form1 : Form
    {
        TreeViewFiller treeViewFiller = new TreeViewFiller();
        FrequencyCalculator frequencyCalculator;
        LanguageFrequency languageFrequency;
        LetterChanger letterChanger;
        static int VALIDATION_DELAY = 500;
        private TreeNode _lastSelectedNode1 = null;
        private TreeNode _lastSelectedNode2 = null;
        System.Threading.Timer timer = null;
        public Form1()
        {
            InitializeComponent(); 
            frequencyCalculator = new FrequencyCalculator(tvVyskytVTextu,tbIN,tvVyskytVTextu);
            languageFrequency = new LanguageFrequency(tvObecnyVyskyt);
            letterChanger = new LetterChanger(tvVyskytVTextu,tvObecnyVyskyt,TvLetterChanged,tbIN,tbOut);
            tbIN.ScrollBars = ScrollBars.Vertical;
            tbOut.ScrollBars = ScrollBars.Vertical;
            cbSelectLanguage.SelectedIndex = 0;
            cbSorting.SelectedIndex = 0;
        }

        private void tbIN_TextChanged(object sender, EventArgs e)
        {
            TextBox origin = sender as TextBox;
            //Čeká než uživatel přestane psát do boxu
            if (!origin.ContainsFocus)
                return;

            DisposeTimer();
            timer = new System.Threading.Timer(TimerElapsed, null, VALIDATION_DELAY, VALIDATION_DELAY);

        }
        private void TimerElapsed(Object obj)
        {
            // Provede příkaz a odhodí timer
            CheckSyntaxAndReport();
            DisposeTimer();
        }

        private void DisposeTimer()
        {
            if (timer != null)
            {
                timer.Dispose();
                timer = null;
            }
        }

        private void CheckSyntaxAndReport()
        { 
            //Příkaz
            string tempText = "";
            this.Invoke(new Action(() =>
            {
            letterChanger.ChangeTextBox();
            frequencyCalculator.StartCalculations();
            }
            ));

        }

        //Mění jazyk
        private void cbSelectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = cbSelectLanguage.Text;
            if (temp != "")
            {
                temp = temp.Substring(0, 2);
                languageFrequency.ChangeLanguage(temp);
            }
        }

        //Mění řazení
        private void cbSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSorting.SelectedIndex == 0)
            {
                languageFrequency.sortAlphabetically();
                frequencyCalculator.sortAlphabetically();
            }
            else
            {
                languageFrequency.sortByPercentage();
                frequencyCalculator.sortByPercentage();
            }
        }

        //Zvýrazní označený kořen
        private void tvObecnyVyskyt_AfterSelect(object sender, TreeViewEventArgs e)
        {
           _lastSelectedNode1 = NodeHiglight(e.Node,_lastSelectedNode1);
            if (tvVyskytVTextu.SelectedNode != null)
            {
                letterChanger.LetterChange();
            }
        }

        //Funkce na zvýraznění
        private TreeNode NodeHiglight(TreeNode e,TreeNode _lastSelectedNode)
        {
            // Select new node
            e.BackColor = SystemColors.Highlight;
            e.ForeColor = SystemColors.HighlightText;
            if (_lastSelectedNode != null)
            {
                // Deselect old node
                _lastSelectedNode.BackColor = SystemColors.Window;
                _lastSelectedNode.ForeColor = SystemColors.WindowText;
            }
            return e;
        }

        //Zvýrazní označený kořen
        private void tvVyskytVTextu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _lastSelectedNode2 = NodeHiglight(e.Node,_lastSelectedNode2);
            if (tvObecnyVyskyt.SelectedNode != null)
            {
                letterChanger.LetterChange();
            }
        }

        
        private void btSaveSelection_Click(object sender, EventArgs e)
        {
            letterChanger.saveSelection();
        }

        private void btClearSavedSelection_Click(object sender, EventArgs e)
        {
            letterChanger.ClearSavedSelections();
        }

        private void TvLetterChanged_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode temp = TvLetterChanged.SelectedNode;
            tvVyskytVTextu.SelectedNode = treeViewFiller.FindNodeByLetter(temp.Text[0], tvVyskytVTextu);
            tvObecnyVyskyt.SelectedNode = treeViewFiller.FindNodeByLetter(temp.Text[5], tvObecnyVyskyt);
            letterChanger.LetterChange();
        }
    }
    public static class Extensions
    {
        public static void Invoke<TControlType>(this TControlType control, Action<TControlType> del)
            where TControlType : Control
        {
            if (control.InvokeRequired)
                control.Invoke(new Action(() => del(control)));
            else
                del(control);
        }
    }

}
