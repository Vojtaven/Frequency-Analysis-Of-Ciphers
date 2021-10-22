
namespace Frequency_Analysis_Of_Ciphers
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // tbIN
            // 
            this.tbIN.Location = new System.Drawing.Point(12, 13);
            this.tbIN.Multiline = true;
            this.tbIN.Name = "tbIN";
            this.tbIN.Size = new System.Drawing.Size(441, 275);
            this.tbIN.TabIndex = 0;
            this.tbIN.TextChanged += new System.EventHandler(this.tbIN_TextChanged);
            // 
            // tvVyskytVTextu
            // 
            this.tvVyskytVTextu.Location = new System.Drawing.Point(851, 27);
            this.tvVyskytVTextu.Name = "tvVyskytVTextu";
            this.tvVyskytVTextu.Size = new System.Drawing.Size(114, 592);
            this.tvVyskytVTextu.TabIndex = 1;
            this.tvVyskytVTextu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvVyskytVTextu_AfterSelect);
            // 
            // tvObecnyVyskyt
            // 
            this.tvObecnyVyskyt.Location = new System.Drawing.Point(971, 27);
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
            this.tvObecnyVyskyt.Size = new System.Drawing.Size(114, 592);
            this.tvObecnyVyskyt.TabIndex = 2;
            this.tvObecnyVyskyt.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvObecnyVyskyt_AfterSelect);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(12, 306);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(441, 313);
            this.tbOut.TabIndex = 3;
            // 
            // cbSelectLanguage
            // 
            this.cbSelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectLanguage.FormattingEnabled = true;
            this.cbSelectLanguage.Items.AddRange(new object[] {
            "Czech",
            "English",
            "German",
            "French",
            "Slovak"});
            this.cbSelectLanguage.Location = new System.Drawing.Point(484, 27);
            this.cbSelectLanguage.Name = "cbSelectLanguage";
            this.cbSelectLanguage.Size = new System.Drawing.Size(182, 21);
            this.cbSelectLanguage.TabIndex = 4;
            this.cbSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.cbSelectLanguage_SelectedIndexChanged);
            // 
            // lbLanguageSelection
            // 
            this.lbLanguageSelection.AutoSize = true;
            this.lbLanguageSelection.Location = new System.Drawing.Point(481, 9);
            this.lbLanguageSelection.Name = "lbLanguageSelection";
            this.lbLanguageSelection.Size = new System.Drawing.Size(100, 13);
            this.lbLanguageSelection.TabIndex = 5;
            this.lbLanguageSelection.Text = "Language selection";
            // 
            // cbSorting
            // 
            this.cbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Items.AddRange(new object[] {
            "Alphabetically",
            "By percentage"});
            this.cbSorting.Location = new System.Drawing.Point(484, 75);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(182, 21);
            this.cbSorting.TabIndex = 6;
            this.cbSorting.SelectedIndexChanged += new System.EventHandler(this.cbSorting_SelectedIndexChanged);
            // 
            // lbSorting
            // 
            this.lbSorting.AutoSize = true;
            this.lbSorting.Location = new System.Drawing.Point(484, 56);
            this.lbSorting.Name = "lbSorting";
            this.lbSorting.Size = new System.Drawing.Size(40, 13);
            this.lbSorting.TabIndex = 7;
            this.lbSorting.Text = "Sorting";
            // 
            // btSaveSelection
            // 
            this.btSaveSelection.Location = new System.Drawing.Point(520, 103);
            this.btSaveSelection.Name = "btSaveSelection";
            this.btSaveSelection.Size = new System.Drawing.Size(111, 44);
            this.btSaveSelection.TabIndex = 8;
            this.btSaveSelection.Text = "Save selection";
            this.btSaveSelection.UseVisualStyleBackColor = true;
            this.btSaveSelection.Click += new System.EventHandler(this.btSaveSelection_Click);
            // 
            // btClearSavedSelection
            // 
            this.btClearSavedSelection.Location = new System.Drawing.Point(520, 154);
            this.btClearSavedSelection.Name = "btClearSavedSelection";
            this.btClearSavedSelection.Size = new System.Drawing.Size(111, 39);
            this.btClearSavedSelection.TabIndex = 9;
            this.btClearSavedSelection.Text = "Clear Saved Selections";
            this.btClearSavedSelection.UseVisualStyleBackColor = true;
            this.btClearSavedSelection.Click += new System.EventHandler(this.btClearSavedSelection_Click);
            // 
            // TvLetterChanged
            // 
            this.TvLetterChanged.Location = new System.Drawing.Point(731, 27);
            this.TvLetterChanged.Name = "TvLetterChanged";
            this.TvLetterChanged.Size = new System.Drawing.Size(114, 592);
            this.TvLetterChanged.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 631);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

