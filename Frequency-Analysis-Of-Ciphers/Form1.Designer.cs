
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
            this.tvVyskytVTextu.Location = new System.Drawing.Point(687, 13);
            this.tvVyskytVTextu.Name = "tvVyskytVTextu";
            this.tvVyskytVTextu.Size = new System.Drawing.Size(194, 606);
            this.tvVyskytVTextu.TabIndex = 1;
            // 
            // tvObecnyVyskyt
            // 
            this.tvObecnyVyskyt.Location = new System.Drawing.Point(909, 13);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 631);
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
    }
}

