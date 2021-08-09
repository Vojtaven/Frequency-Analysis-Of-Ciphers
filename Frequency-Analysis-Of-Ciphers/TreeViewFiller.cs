using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Frequency_Analysis_Of_Ciphers
{
    class TreeViewFiller
    {
        private TreeView tvInUse;
        public TreeViewFiller(TreeView tvInUse)
        {
            this.tvInUse = tvInUse;
        }

        public void TreeViewFill(List<letterfre> list)
        {
            tvInUse.Invoke(t => t.Nodes.Clear());
            tvInUse.Invoke(t => t.Nodes.Add("Písmena"));
            for (int i = 0; i < list.Count; i++)
            {
                tvInUse.Invoke(t => t.Nodes[0].Nodes.Add($"{list[i]} %"));
            }
            tvInUse.Invoke(t => t.ExpandAll());
        }

        public void sortAlphabetically(List<letterfre> list)
        {
            list = list.OrderBy(o => o.getLetter()).ToList();
            TreeViewFill(list);
        }
        public void sortByPercentage(List<letterfre> list) 
        {
            list = list.OrderByDescending(o => o.getFrequency()).ToList();
            TreeViewFill(list);
        }
    }
}
