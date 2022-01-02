﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Frequency_Analysis_Of_Ciphers
{

    public partial class mainForm : Form
    {
        private readonly TreeViewFiller treeViewFiller = new TreeViewFiller();
        private FrequencyCalculator frequencyCalculator;
        private LanguageFrequency languageFrequency;
        private LetterChanger letterChanger;
        static int VALIDATION_DELAY = 500;
        private TreeNode _lastSelectedNode1 = null;
        private TreeNode _lastSelectedNode2 = null;
        System.Threading.Timer timer = null;
        private Size lastSize;
        public mainForm()
        {
            InitializeComponent();
            frequencyCalculator = new FrequencyCalculator(tvVyskytVTextu, tbIN);
            languageFrequency = new LanguageFrequency(tvObecnyVyskyt);
            letterChanger = new LetterChanger(tvVyskytVTextu, tvObecnyVyskyt, TvLetterChanged, tbIN, tbOut);
            tbIN.ScrollBars = ScrollBars.Vertical;
            tbOut.ScrollBars = ScrollBars.Vertical;
            cbSelectLanguage.SelectedIndex = 0;
            cbSorting.SelectedIndex = 0;
            lastSize = Size;
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
                languageFrequency.SortAlphabetically();
                frequencyCalculator.SortAlphabetically();
            }
            else
            {
                languageFrequency.SortByPercentage();
                frequencyCalculator.SortByPercentage();
            }
        }

        //Zvýrazní označený kořen
        private void tvObecnyVyskyt_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _lastSelectedNode1 = NodeHiglight(e.Node, _lastSelectedNode1);
            if (tvVyskytVTextu.SelectedNode != null)
            {
                letterChanger.LetterChange();
            }
        }

        //Funkce na zvýraznění
        private TreeNode NodeHiglight(TreeNode e, TreeNode _lastSelectedNode)
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
            _lastSelectedNode2 = NodeHiglight(e.Node, _lastSelectedNode2);
            if (tvObecnyVyskyt.SelectedNode != null)
            {
                letterChanger.LetterChange();
            }
        }


        private void btSaveSelection_Click(object sender, EventArgs e)
        {
            letterChanger.SaveSelection();
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

        private void btClearSelectedLetterCouple_Click(object sender, EventArgs e)
        {
            if (TvLetterChanged.SelectedNode != null)
            {
                letterChanger.RemoveLetterCouple(TvLetterChanged.SelectedNode.Text);
                TvLetterChanged.SelectedNode.Remove();
            }
        }

        private void nápovědaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm help = new HelpForm();
            help.Show();
        }

        private void vstupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                tbIN.Text = new StreamReader(theDialog.FileName).ReadToEnd();
            }
        }

        private void uložitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Text File";
            saveFileDialog.Filter = "TXT files|*.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.FileName = "output";
            saveFileDialog.InitialDirectory = @"C:\";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter file = new StreamWriter(stream);
                file.Write(tbOut.Text);
                file.Close();
            }
        }

        private void načístKonfiguraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Configuration File";
            theDialog.Filter = "CON files|*.con";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
               letterChanger.ReadConfiguration(new StreamReader(theDialog.FileName).ReadToEnd());
            }

        }

        private void uložitKonfiguraciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Configuration File";
            saveFileDialog.Filter = "CON files|*.con";
            saveFileDialog.DefaultExt = "con";
            saveFileDialog.FileName = "configuration";
            saveFileDialog.InitialDirectory = @"C:\";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter file = new StreamWriter(stream);
                file.Write(letterChanger.GetConfiguration());
                file.Close();
            }
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
