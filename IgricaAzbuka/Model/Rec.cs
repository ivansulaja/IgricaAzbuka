using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgricaAzbuka.Model
{
    public class Rec
    {
        public string Name { get; set; }
        public string Zvuk { get; set; }

        public Rec(string name)
        {
            Name = name;
            Zvuk = string.Format("Assets/Sounds/{0}.m4a", name);
        }

        public static List<Rec> getReci()
        {
            List<Rec> Reci = new List<Rec>();

            Reci.Add(new Rec("TATA"));
            Reci.Add(new Rec("MAMA"));
            Reci.Add(new Rec("VUK"));
            Reci.Add(new Rec("BABA"));
            Reci.Add(new Rec("UNA"));

            return Reci;
        }
    }


}
