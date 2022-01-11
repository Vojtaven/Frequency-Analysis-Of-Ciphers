﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class TreeViewFiller
    {
        private TreeView tvInUse;
        public TreeViewFiller(TreeView tvInUse)
        {
            this.tvInUse = tvInUse;
        }
        public TreeViewFiller()
        {
        }

        public void TreeViewFill(List<LetterFrequency> list)
        {
            tvInUse.Invoke(t => t.Nodes.Clear());
            if (list.Count != 0)
                tvInUse.Invoke(t => t.Nodes.Add("Písmena"));
            for (int i = 0; i < list.Count; i++)
            {
                tvInUse.Invoke(t => t.Nodes[0].Nodes.Add($"{list[i]} %"));
            }
            tvInUse.Invoke(t => t.ExpandAll());
        }

        public void TreeViewFill(List<ChangedLetter> list)
        {
            tvInUse.Invoke(t => t.Nodes.Clear());
            if (list.Count != 0)
                tvInUse.Invoke(t => t.Nodes.Add("Písmena"));
            for (int i = 0; i < list.Count; i++)
            {
                tvInUse.Invoke(t => t.Nodes[0].Nodes.Add(list[i].ToString()));
            }
            tvInUse.Invoke(t => t.ExpandAll());
        }

        public void SortAlphabetically(List<LetterFrequency> list)
        {
            list = list.OrderBy(o => o.GetLetter()).ToList();
            TreeViewFill(list);
        }
        public void SortByPercentage(List<LetterFrequency> list)
        {
            list = list.OrderByDescending(o => o.frequency).ToList();
            TreeViewFill(list);
        }

        public TreeNode FindNodeByLetter(char letter, TreeView tv)
        {
            TreeNode output = null;
            for (int i = 0; i < tv.Nodes[0].Nodes.Count; i++)
            {
                if (tv.Nodes[0].Nodes[i].Text[0] == letter)
                {
                    output = tv.Nodes[0].Nodes[i];
                    break;
                }
            }

            return output;
        }
    }
}
