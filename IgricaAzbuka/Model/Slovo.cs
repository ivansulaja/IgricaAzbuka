using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaAzbuka.Model
{
    public class Slovo
    {
        public int ID { get; set; }
        public char Char { get; set; }
        public bool isSelected { get; set; }
        public string Zvuk { get; set; }
        public string regularnoSlovo { get; set; }

        public Slovo(int id, char slovo, string rSlovo)
        {
            ID = id;
            Char = slovo;
            isSelected = false;
            Zvuk = string.Format("/Assets/Sounds/{0}.m4a", id);
            regularnoSlovo = rSlovo;
            
        }
        public static List<Slovo> getAzbuka()
        {
            List<Slovo> Slova = new List<Slovo>();

            Slova.Add(new Slovo(1, '\u0410',"A"));
            Slova.Add(new Slovo(2, '\u0411',"B"));
            Slova.Add(new Slovo(3, '\u0412', "V"));
            Slova.Add(new Slovo(4, '\u0413', "G"));
            Slova.Add(new Slovo(5, '\u0414', "D"));
            Slova.Add(new Slovo(6, '\u0402', "DJ"));
            Slova.Add(new Slovo(7, '\u0415', "E"));
            Slova.Add(new Slovo(8, '\u0416', "Z"));
            Slova.Add(new Slovo(9, '\u0417', "Z"));
            Slova.Add(new Slovo(10, '\u0418', "I"));
            Slova.Add(new Slovo(11, '\u0408', "J"));
            Slova.Add(new Slovo(12, '\u041A', "K"));
            Slova.Add(new Slovo(13, '\u041B', "L"));
            Slova.Add(new Slovo(14, '\u0409', "LJ"));
            Slova.Add(new Slovo(15, '\u041C', "M"));
            Slova.Add(new Slovo(16, '\u041D', "N"));
            Slova.Add(new Slovo(17, '\u040A', "NJ"));
            Slova.Add(new Slovo(18, '\u041E', "O"));
            Slova.Add(new Slovo(19, '\u041F', "P"));
            Slova.Add(new Slovo(20, '\u0420', "R"));
            Slova.Add(new Slovo(21, '\u0421', "S"));
            Slova.Add(new Slovo(22, '\u0422', "T"));
            Slova.Add(new Slovo(23, '\u040B', "C"));
            Slova.Add(new Slovo(24, '\u0423', "U"));
            Slova.Add(new Slovo(25, '\u0424', "F"));
            Slova.Add(new Slovo(26, '\u0425', "H"));
            Slova.Add(new Slovo(27, '\u0426', "C"));
            Slova.Add(new Slovo(28, '\u0427', "C"));
            Slova.Add(new Slovo(29, '\u040F', "D"));
            Slova.Add(new Slovo(30, '\u0428', "S"));


            return Slova;

        }
    }
}
