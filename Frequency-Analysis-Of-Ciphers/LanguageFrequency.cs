using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frequency_Analysis_Of_Ciphers
{
    class LanguageFrequency
    {

        string alphabet = "abcdefghijklmnopqrstuvwxyz".ToUpper();
        private bool alphabetically = true;
        TreeViewFiller treeViewFiller;

        List<letterfre> nowUsing;
        List<letterfre> english = new List<letterfre>();
        List<letterfre> german = new List<letterfre>();
        List<letterfre> french = new List<letterfre>();
        List<letterfre> czech = new List<letterfre>();
        List<letterfre> slovak = new List<letterfre>();

        public LanguageFrequency(TreeView tvLanguage)
        {
            treeViewFiller = new TreeViewFiller(tvLanguage);
            this.CreateLanguages();
            nowUsing = czech;
        }
        public void ChangeLanguage(string selectedLanguage)
        {
            switch (selectedLanguage.ToLower())
            {
                case "en":
                    nowUsing = english;
                    break;
                case "ge":
                    nowUsing = german;
                    break;
                case "fr":
                    nowUsing = french;
                    break;
                case "cz":
                    nowUsing = czech;
                    break;
                case "sl":
                    nowUsing = slovak;
                    break;
            }
            if (!alphabetically)
                treeViewFiller.SortByPercentage(nowUsing);
            else
                treeViewFiller.TreeViewFill(nowUsing);
        }

        public void SortAlphabetically()
        {
            alphabetically = true;
            treeViewFiller.SortAlphabetically(nowUsing);
        }
        public void SortByPercentage()
        {
            alphabetically = false;
            treeViewFiller.SortByPercentage(nowUsing);
        }

        private void CreateLanguages()
        {

            string[] rawtextData = data.Split(new string[] { "\r", "\n", " " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < alphabet.Length; i++)
            {
                english.Add(new letterfre(alphabet[i], float.Parse(rawtextData[7 + i * 6])));
                german.Add(new letterfre(alphabet[i], float.Parse(rawtextData[8 + i * 6])));
                french.Add(new letterfre(alphabet[i], float.Parse(rawtextData[9 + i * 6])));
                czech.Add(new letterfre(alphabet[i], float.Parse(rawtextData[10 + i * 6])));
                slovak.Add(new letterfre(alphabet[i], float.Parse(rawtextData[11 + i * 6])));
            }
        }

        private string data = @"//  En   Fr     Ge    Cz    Sk
                                A 07,96 07,68 05,52 08,99 09,49
                                B 01,60 00,80 01,56 01,86 01,90
                                C 02,84 03,32 02,94 03,04 03,45
                                D 04,01 03,60 04,91 04,14 04,09
                                E 12,86 17,76 19,18 10,13 09,16
                                F 02,62 01,06 01,96 00,33 00,31
                                G 01,99 01,10 03,60 00,48 00,40
                                H 05,39 00,64 05,02 02,06 02,35
                                I 07,77 07,23 08,21 06,92 06,81
                                J 00,16 00,19 00,16 02,10 02,12
                                K 00,41 00,00 01,33 03,44 03,80
                                L 03,51 05,89 03,48 04,20 04,56
                                M 02,43 02,72 01,69 02,99 02,97
                                N 07,51 07,61 10,20 06,64 06,34
                                O 06,62 05,34 02,14 08,39 09,34
                                P 01,81 03,24 00,54 03,54 02,87
                                Q 00,17 01,34 00,01 00,00 00,00
                                R 06,83 06,81 07,01 05,33 05,12
                                S 06,62 08,23 07,07 05,74 05,94
                                T 09,72 07,30 05,86 04,98 05,06
                                U 02,48 06,05 04,22 03,94 03,70
                                V 01,15 01,27 00,84 04,50 04,85
                                W 01,80 00,00 01,38 00,06 00,06
                                X 00,17 00,54 00,00 00,04 00,03
                                Y 01,52 00,21 00,00 02,72 02,57
                                Z 00,05 00,07 01,17 03,44 02,72";

    }
}
