
namespace Frequency_Analysis_Of_Ciphers
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Písmena");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Biagramy");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Triagramy");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tbIN = new System.Windows.Forms.TextBox();
            this.tvVyskytVTextu = new System.Windows.Forms.TreeView();
            this.tvObecnyVyskyt = new System.Windows.Forms.TreeView();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.cbSelectLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguageSelection = new System.Windows.Forms.Label();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.lbSorting = new System.Windows.Forms.Label();
            this.btSaveSelection = new System.Windows.Forms.Button();
            this.btClearSavedSelection = new System.Windows.Forms.Button();
            this.TvLetterChanged = new System.Windows.Forms.TreeView();
            this.lbChangedLetters = new System.Windows.Forms.Label();
            this.lbTextFrequency = new System.Windows.Forms.Label();
            this.lbLanguageFrequency = new System.Windows.Forms.Label();
            this.lbOutputText = new System.Windows.Forms.Label();
            this.lbInputText = new System.Windows.Forms.Label();
            this.btClearSelectedLetterCouple = new System.Windows.Forms.Button();
            this.MsMainMenu = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vstupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfuguraceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.načístKonfiguraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uložitKonfiguraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIN
            // 
            this.tbIN.BackColor = System.Drawing.SystemColors.Window;
            this.tbIN.Location = new System.Drawing.Point(15, 43);
            this.tbIN.Multiline = true;
            this.tbIN.Name = "tbIN";
            this.tbIN.Size = new System.Drawing.Size(441, 266);
            this.tbIN.TabIndex = 0;
            this.tbIN.TextChanged += new System.EventHandler(this.tbIN_TextChanged);
            // 
            // tvVyskytVTextu
            // 
            this.tvVyskytVTextu.BackColor = System.Drawing.SystemColors.Window;
            this.tvVyskytVTextu.Location = new System.Drawing.Point(851, 43);
            this.tvVyskytVTextu.Name = "tvVyskytVTextu";
            this.tvVyskytVTextu.Size = new System.Drawing.Size(114, 576);
            this.tvVyskytVTextu.TabIndex = 1;
            this.tvVyskytVTextu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvVyskytVTextu_AfterSelect);
            // 
            // tvObecnyVyskyt
            // 
            this.tvObecnyVyskyt.BackColor = System.Drawing.SystemColors.Window;
            this.tvObecnyVyskyt.Location = new System.Drawing.Point(971, 43);
            this.tvObecnyVyskyt.Name = "tvObecnyVyskyt";
            treeNode1.Name = "letters";
            treeNode1.Text = "Písmena";
            treeNode2.Name = "Biagrams";
            treeNode2.Text = "Biagramy";
            treeNode3.Name = "Triagrams";
            treeNode3.Text = "Triagramy";
            this.tvObecnyVyskyt.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvObecnyVyskyt.Size = new System.Drawing.Size(114, 576);
            this.tvObecnyVyskyt.TabIndex = 2;
            this.tvObecnyVyskyt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvObecnyVyskyt_AfterSelect);
            // 
            // tbOut
            // 
            this.tbOut.BackColor = System.Drawing.SystemColors.Window;
            this.tbOut.Location = new System.Drawing.Point(15, 328);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(441, 291);
            this.tbOut.TabIndex = 3;
            // 
            // cbSelectLanguage
            // 
            this.cbSelectLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.cbSelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectLanguage.FormattingEnabled = true;
            this.cbSelectLanguage.Items.AddRange(new object[] {
            "Čeština",
            "Angličtina",
            "Němčina",
            "Francouzšťina",
            "Slovenština"});
            this.cbSelectLanguage.Location = new System.Drawing.Point(484, 43);
            this.cbSelectLanguage.Name = "cbSelectLanguage";
            this.cbSelectLanguage.Size = new System.Drawing.Size(182, 21);
            this.cbSelectLanguage.TabIndex = 4;
            this.cbSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.cbSelectLanguage_SelectedIndexChanged);
            // 
            // lbLanguageSelection
            // 
            this.lbLanguageSelection.AutoSize = true;
            this.lbLanguageSelection.Location = new System.Drawing.Point(481, 27);
            this.lbLanguageSelection.Name = "lbLanguageSelection";
            this.lbLanguageSelection.Size = new System.Drawing.Size(67, 13);
            this.lbLanguageSelection.TabIndex = 5;
            this.lbLanguageSelection.Text = "Výběr jazyka";
            // 
            // cbSorting
            // 
            this.cbSorting.BackColor = System.Drawing.SystemColors.Control;
            this.cbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Items.AddRange(new object[] {
            "Abecedně",
            "Podle frekvence"});
            this.cbSorting.Location = new System.Drawing.Point(484, 83);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(182, 21);
            this.cbSorting.TabIndex = 6;
            this.cbSorting.SelectedIndexChanged += new System.EventHandler(this.cbSorting_SelectedIndexChanged);
            // 
            // lbSorting
            // 
            this.lbSorting.AutoSize = true;
            this.lbSorting.Location = new System.Drawing.Point(481, 67);
            this.lbSorting.Name = "lbSorting";
            this.lbSorting.Size = new System.Drawing.Size(64, 13);
            this.lbSorting.TabIndex = 7;
            this.lbSorting.Text = "Druh řazení";
            // 
            // btSaveSelection
            // 
            this.btSaveSelection.Location = new System.Drawing.Point(520, 110);
            this.btSaveSelection.Name = "btSaveSelection";
            this.btSaveSelection.Size = new System.Drawing.Size(111, 44);
            this.btSaveSelection.TabIndex = 8;
            this.btSaveSelection.Text = "Uložit vybranou dvojici";
            this.btSaveSelection.UseVisualStyleBackColor = true;
            this.btSaveSelection.Click += new System.EventHandler(this.btSaveSelection_Click);
            // 
            // btClearSavedSelection
            // 
            this.btClearSavedSelection.Location = new System.Drawing.Point(520, 160);
            this.btClearSavedSelection.Name = "btClearSavedSelection";
            this.btClearSavedSelection.Size = new System.Drawing.Size(111, 39);
            this.btClearSavedSelection.TabIndex = 9;
            this.btClearSavedSelection.Text = "Vymazat uložené dvojice";
            this.btClearSavedSelection.UseVisualStyleBackColor = true;
            this.btClearSavedSelection.Click += new System.EventHandler(this.btClearSavedSelection_Click);
            // 
            // TvLetterChanged
            // 
            this.TvLetterChanged.BackColor = System.Drawing.SystemColors.Window;
            this.TvLetterChanged.Location = new System.Drawing.Point(718, 43);
            this.TvLetterChanged.Name = "TvLetterChanged";
            this.TvLetterChanged.Size = new System.Drawing.Size(114, 576);
            this.TvLetterChanged.TabIndex = 10;
            this.TvLetterChanged.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TvLetterChanged_AfterSelect);
            // 
            // lbChangedLetters
            // 
            this.lbChangedLetters.AutoSize = true;
            this.lbChangedLetters.Location = new System.Drawing.Point(715, 24);
            this.lbChangedLetters.Name = "lbChangedLetters";
            this.lbChangedLetters.Size = new System.Drawing.Size(101, 13);
            this.lbChangedLetters.TabIndex = 11;
            this.lbChangedLetters.Text = "Vyměněná písmena";
            // 
            // lbTextFrequency
            // 
            this.lbTextFrequency.AutoSize = true;
            this.lbTextFrequency.Location = new System.Drawing.Point(848, 24);
            this.lbTextFrequency.Name = "lbTextFrequency";
            this.lbTextFrequency.Size = new System.Drawing.Size(73, 13);
            this.lbTextFrequency.TabIndex = 12;
            this.lbTextFrequency.Text = "Výskyt v textu";
            // 
            // lbLanguageFrequency
            // 
            this.lbLanguageFrequency.AutoSize = true;
            this.lbLanguageFrequency.Location = new System.Drawing.Point(968, 24);
            this.lbLanguageFrequency.Name = "lbLanguageFrequency";
            this.lbLanguageFrequency.Size = new System.Drawing.Size(80, 13);
            this.lbLanguageFrequency.TabIndex = 13;
            this.lbLanguageFrequency.Text = "Výskyt v jazyce";
            // 
            // lbOutputText
            // 
            this.lbOutputText.AutoSize = true;
            this.lbOutputText.Location = new System.Drawing.Point(12, 312);
            this.lbOutputText.Name = "lbOutputText";
            this.lbOutputText.Size = new System.Drawing.Size(39, 13);
            this.lbOutputText.TabIndex = 14;
            this.lbOutputText.Text = "Výstup";
            // 
            // lbInputText
            // 
            this.lbInputText.AutoSize = true;
            this.lbInputText.Location = new System.Drawing.Point(12, 27);
            this.lbInputText.Name = "lbInputText";
            this.lbInputText.Size = new System.Drawing.Size(64, 13);
            this.lbInputText.TabIndex = 15;
            this.lbInputText.Text = "Vstupní text";
            // 
            // btClearSelectedLetterCouple
            // 
            this.btClearSelectedLetterCouple.Location = new System.Drawing.Point(520, 205);
            this.btClearSelectedLetterCouple.Name = "btClearSelectedLetterCouple";
            this.btClearSelectedLetterCouple.Size = new System.Drawing.Size(111, 34);
            this.btClearSelectedLetterCouple.TabIndex = 16;
            this.btClearSelectedLetterCouple.Text = "Odebrat vybraný pár písmen";
            this.btClearSelectedLetterCouple.UseVisualStyleBackColor = true;
            this.btClearSelectedLetterCouple.Click += new System.EventHandler(this.btClearSelectedLetterCouple_Click);
            // 
            // MsMainMenu
            // 
            this.MsMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.konfuguraceToolStripMenuItem});
            this.MsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.MsMainMenu.Name = "MsMainMenu";
            this.MsMainMenu.Size = new System.Drawing.Size(1097, 24);
            this.MsMainMenu.TabIndex = 17;
            this.MsMainMenu.Text = "menuStrip1";
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vstupToolStripMenuItem,
            this.uložitToolStripMenuItem});
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // vstupToolStripMenuItem
            // 
            this.vstupToolStripMenuItem.Name = "vstupToolStripMenuItem";
            this.vstupToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.vstupToolStripMenuItem.Text = "Nahrát vstup";
            this.vstupToolStripMenuItem.Click += new System.EventHandler(this.vstupToolStripMenuItem_Click);
            // 
            // uložitToolStripMenuItem
            // 
            this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
            this.uložitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.uložitToolStripMenuItem.Text = "Uložit vystup";
            this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
            // 
            // konfuguraceToolStripMenuItem
            // 
            this.konfuguraceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.načístKonfiguraciToolStripMenuItem,
            this.uložitKonfiguraciToolStripMenuItem});
            this.konfuguraceToolStripMenuItem.Name = "konfuguraceToolStripMenuItem";
            this.konfuguraceToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.konfuguraceToolStripMenuItem.Text = "Konfigurace";
            // 
            // načístKonfiguraciToolStripMenuItem
            // 
            this.načístKonfiguraciToolStripMenuItem.Name = "načístKonfiguraciToolStripMenuItem";
            this.načístKonfiguraciToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.načístKonfiguraciToolStripMenuItem.Text = "Načíst konfiguraci";
            this.načístKonfiguraciToolStripMenuItem.Click += new System.EventHandler(this.načístKonfiguraciToolStripMenuItem_Click);
            // 
            // uložitKonfiguraciToolStripMenuItem
            // 
            this.uložitKonfiguraciToolStripMenuItem.Name = "uložitKonfiguraciToolStripMenuItem";
            this.uložitKonfiguraciToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uložitKonfiguraciToolStripMenuItem.Text = "Uložit konfiguraci";
            this.uložitKonfiguraciToolStripMenuItem.Click += new System.EventHandler(this.uložitKonfiguraciToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1097, 631);
            this.Controls.Add(this.btClearSelectedLetterCouple);
            this.Controls.Add(this.lbInputText);
            this.Controls.Add(this.lbOutputText);
            this.Controls.Add(this.lbLanguageFrequency);
            this.Controls.Add(this.lbTextFrequency);
            this.Controls.Add(this.lbChangedLetters);
            this.Controls.Add(this.TvLetterChanged);
            this.Controls.Add(this.btClearSavedSelection);
            this.Controls.Add(this.btSaveSelection);
            this.Controls.Add(this.lbSorting);
            this.Controls.Add(this.cbSorting);
            this.Controls.Add(this.lbLanguageSelection);
            this.Controls.Add(this.cbSelectLanguage);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tvObecnyVyskyt);
            this.Controls.Add(this.tvVyskytVTextu);
            this.Controls.Add(this.tbIN);
            this.Controls.Add(this.MsMainMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsMainMenu;
            this.Name = "mainForm";
            this.Text = "Frekvenční analýza šifer";
            this.MsMainMenu.ResumeLayout(false);
            this.MsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIN;
        private System.Windows.Forms.TreeView tvVyskytVTextu;
        private System.Windows.Forms.TreeView tvObecnyVyskyt;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.ComboBox cbSelectLanguage;
        private System.Windows.Forms.Label lbLanguageSelection;
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.Label lbSorting;
        private System.Windows.Forms.Button btSaveSelection;
        private System.Windows.Forms.Button btClearSavedSelection;
        private System.Windows.Forms.TreeView TvLetterChanged;
        private System.Windows.Forms.Label lbChangedLetters;
        private System.Windows.Forms.Label lbTextFrequency;
        private System.Windows.Forms.Label lbLanguageFrequency;
        private System.Windows.Forms.Label lbOutputText;
        private System.Windows.Forms.Label lbInputText;
        private System.Windows.Forms.Button btClearSelectedLetterCouple;
        private System.Windows.Forms.MenuStrip MsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vstupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfuguraceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem načístKonfiguraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uložitKonfiguraciToolStripMenuItem;
    }
}

