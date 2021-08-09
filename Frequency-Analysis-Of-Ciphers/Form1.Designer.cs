
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Písmena");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Biagramy");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Triagramy");
            this.tbIN = new System.Windows.Forms.TextBox();
            this.tvVyskytVTextu = new System.Windows.Forms.TreeView();
            this.tvObecnyVyskyt = new System.Windows.Forms.TreeView();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.cbSelectLanguage = new System.Windows.Forms.ComboBox();
            this.lbLanguageSelection = new System.Windows.Forms.Label();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.lbSorting = new System.Windows.Forms.Label();
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
            this.tvVyskytVTextu.HideSelection = false;
            this.tvVyskytVTextu.Location = new System.Drawing.Point(687, 13);
            this.tvVyskytVTextu.Name = "tvVyskytVTextu";
            this.tvVyskytVTextu.Size = new System.Drawing.Size(194, 606);
            this.tvVyskytVTextu.TabIndex = 1;
            // 
            // tvObecnyVyskyt
            // 
            this.tvObecnyVyskyt.HideSelection = false;
            this.tvObecnyVyskyt.Location = new System.Drawing.Point(909, 13);
            this.tvObecnyVyskyt.Name = "tvObecnyVyskyt";
            treeNode4.Name = "letters";
            treeNode4.Text = "Písmena";
            treeNode5.Name = "Biagrams";
            treeNode5.Text = "Biagramy";
            treeNode6.Name = "Triagrams";
            treeNode6.Text = "Triagramy";
            this.tvObecnyVyskyt.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            this.tvObecnyVyskyt.Size = new System.Drawing.Size(176, 606);
            this.tvObecnyVyskyt.TabIndex = 2;
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(12, 344);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(441, 275);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 631);
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
    }
}

