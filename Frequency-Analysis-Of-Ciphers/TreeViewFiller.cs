using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class TreeViewFiller
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string[] english = new string[26];
        string[] german = new string[26];
        string[] french = new string[26];
        string[] czech = new string[26];
        string[] slovak = new string[26];
        Form1 formInstance;
        TreeView tv;
        public TreeViewFiller(Form1 form)
        {
            this.CreateLanguages();
            formInstance = form;
            tv = Application.OpenForms["Form1"].Controls["tvObecnyVyskyt"] as TreeView;
        }
         
        
        private void CreateLanguages()
        {
            string[] rawtextData = System.IO.File.ReadAllText(@"F:\Aplikace\Frequency-Analysis-Of-Ciphers\Frequency-Analysis-Of-Ciphers\bin\Debug\jazyky-vyskyt.txt").Split(new string[] {"\r", "\n", " "},StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
