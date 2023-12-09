using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latin2
{
    public partial class VolosiiLatinRussian : Form
    

    {
        Dictionary<string, string> words = new Dictionary<string, string>();
        Dictionary<string, string> words2 = new Dictionary<string, string>();
        Dictionary<string, string> ords = new Dictionary<string, string>();



        public VolosiiLatinRussian()
        {
            InitializeComponent();
            words.Add("а", "a");
            words.Add("б", "b");
            words.Add("в", "v");
            words.Add("г", "g");
            words.Add("д", "d");
            words.Add("е", "e");
            words.Add("ё", "jo");
            words.Add("ж", "ž");
            words.Add("з", "z");
            words.Add("и", "i");
            words.Add("й", "j");
            words.Add("к", "k");
            words.Add("л", "l");
            words.Add("м", "m");
            words.Add("н", "n");
            words.Add("о", "o");
            words.Add("п", "p");
            words.Add("р", "r");
            words.Add("с", "s");
            words.Add("т", "t");
            words.Add("у", "u");
            words.Add("ф", "f");
            words.Add("х", "h");
            words.Add("ц", "c");
            words.Add("ч", "č");
            words.Add("ш", "š");
            words.Add("щ", "ŝ");
            words.Add("ъ", "j");
            words.Add("ы", "y");
            words.Add("ь", "'");
            words.Add("э", "é");
            words.Add("ю", "ju");
            words.Add("я", "ja");
            words.Add("А", "A");
            words.Add("Б", "B");
            words.Add("В", "V");
            words.Add("Г", "G");
            words.Add("Д", "D");
            words.Add("Е", "E");
            words.Add("Ё", "Jo");
            words.Add("Ж", "Ž");
            words.Add("З", "Z");
            words.Add("И", "I");
            words.Add("Й", "J");
            words.Add("К", "K");
            words.Add("Л", "L");
            words.Add("М", "M");
            words.Add("Н", "N");
            words.Add("О", "O");
            words.Add("П", "P");
            words.Add("Р", "R");
            words.Add("С", "S");
            words.Add("Т", "T");
            words.Add("У", "U");
            words.Add("Ф", "F");
            words.Add("Х", "H");
            words.Add("Ц", "C");
            words.Add("Ч", "Č");
            words.Add("Ш", "Š");
            words.Add("Щ", "Ŝ");
            words.Add("Ъ", "J");
            words.Add("Ы", "Y");
            words.Add("Ь", "'");
            words.Add("Э", "É");
            words.Add("Ю", "Ju");
            words.Add("Я", "Ja");

            words2.Add("а", "а");
            words2.Add("б", "b");
            words2.Add("в", "v");
            words2.Add("г", "g");
            words2.Add("д", "d");
            words2.Add("е", "e");
            words2.Add("ё", "jo");
            words2.Add("ж", "rz");
            words2.Add("з", "z");
            words2.Add("и", "i");
            words2.Add("й", "j");
            words2.Add("к", "k");
            words2.Add("л", "l");
            words2.Add("м", "m");
            words2.Add("н", "n");
            words2.Add("о", "o");
            words2.Add("п", "p");
            words2.Add("р", "r");
            words2.Add("с", "s");
            words2.Add("т", "t");
            words2.Add("у", "u");
            words2.Add("ф", "f");
            words2.Add("х", "сh");
            words2.Add("ц", "c");
            words2.Add("ч", "cz");
            words2.Add("ш", "sz");
            words2.Add("щ", "szcz");
            words2.Add("ъ", "j");
            words2.Add("ы", "y");
            words2.Add("ь", "'");
            words2.Add("э", "é");
            words2.Add("ю", "ju");
            words2.Add("я", "ja");
            words2.Add("А", "A");
            words2.Add("Б", "B");
            words2.Add("В", "V");
            words2.Add("Г", "G");
            words2.Add("Д", "D");
            words2.Add("Е", "E");
            words2.Add("Ё", "Jo");
            words2.Add("Ж", "Rz");
            words2.Add("З", "Z");
            words2.Add("И", "I");
            words2.Add("Й", "J");
            words2.Add("К", "K");
            words2.Add("Л", "L");
            words2.Add("М", "M");
            words2.Add("Н", "N");
            words2.Add("О", "O");
            words2.Add("П", "P");
            words2.Add("Р", "R");
            words2.Add("С", "S");
            words2.Add("Т", "T");
            words2.Add("У", "U");
            words2.Add("Ф", "F");
            words2.Add("Х", "Сh");
            words2.Add("Ц", "C");
            words2.Add("Ч", "Cz");
            words2.Add("Ш", "Sz");
            words2.Add("Щ", "Szcz");
            words2.Add("Ъ", "J");
            words2.Add("Ы", "Y");
            words2.Add("Ь", "'");
            words2.Add("Э", "É");
            words2.Add("Ю", "Ju");
            words2.Add("Я", "Ja");

            ords.Add("а", "a");
            ords.Add("б", "b");
            ords.Add("в", "v");
            ords.Add("г", "g");
            ords.Add("д", "d");
            ords.Add("е", "e");
            ords.Add("ё", "yo");
            ords.Add("ж", "zh");
            ords.Add("з", "z");
            ords.Add("и", "i");
            ords.Add("й", "j");
            ords.Add("к", "k");
            ords.Add("л", "l");
            ords.Add("м", "m");
            ords.Add("н", "n");
            ords.Add("о", "o");
            ords.Add("п", "p");
            ords.Add("р", "r");
            ords.Add("с", "s");
            ords.Add("т", "t");
            ords.Add("у", "u");
            ords.Add("ф", "f");
            ords.Add("х", "h");
            ords.Add("ц", "c");
            ords.Add("ч", "ch");
            ords.Add("ш", "sh");
            ords.Add("щ", "sch");
            ords.Add("ъ", "'");
            ords.Add("ы", "y");
            ords.Add("ь", "'");
            ords.Add("э", "e");
            ords.Add("ю", "yu");
            ords.Add("я", "ya");
            ords.Add("А", "A");
            ords.Add("Б", "B");
            ords.Add("В", "V");
            ords.Add("Г", "G");
            ords.Add("Д", "D");
            ords.Add("Е", "E");
            ords.Add("Ё", "Yo");
            ords.Add("Ж", "Zh");
            ords.Add("З", "Z");
            ords.Add("И", "I");
            ords.Add("Й", "J");
            ords.Add("К", "K");
            ords.Add("Л", "L");
            ords.Add("М", "M");
            ords.Add("Н", "N");
            ords.Add("О", "O");
            ords.Add("П", "P");
            ords.Add("Р", "R");
            ords.Add("С", "S");
            ords.Add("Т", "T");
            ords.Add("У", "U");
            ords.Add("Ф", "F");
            ords.Add("Х", "H");
            ords.Add("Ц", "C");
            ords.Add("Ч", "Ch");
            ords.Add("Ш", "Sh");
            ords.Add("Щ", "Sch");
            ords.Add("Ъ", "'");
            ords.Add("Ы", "Y");
            ords.Add("Ь", "'");
            ords.Add("Э", "E");
            ords.Add("Ю", "Yu");
            ords.Add("Я", "Ya");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string source = textBox1.Text;
            if (radioButton1.Checked)
            {


                foreach (KeyValuePair<string, string> pair in words)
                {
                    source = source.Replace(pair.Key, pair.Value);
                }
                textBox2.Text = source;
            }
            else if (radioButton2.Checked)
            {
                foreach (KeyValuePair<string, string> pair in words2)
                {
                    source = source.Replace(pair.Key, pair.Value);
                }
                textBox2.Text = source;


            }
            else if (radioButton3.Checked)
            {
                foreach (KeyValuePair<string, string> pair in ords)
                {
                    source = source.Replace(pair.Key, pair.Value);
                }
                textBox2.Text = source;
            }

        }

      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void VolosiiLatinRussian_Load(object sender, EventArgs e)
        {
 
        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
            
        {
            
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void VolosiiLatinRussian_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)

            {

                button1_Click(button1, null);
            }
        }
    }
}