using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр4
{
    internal class Testtt
    {
        public string Name { get; set; } 
        public string Zadanie{ get; set; }
        public string Perotvet { get; set; }
        public string VtorOtvet { get; set; }
        public string TritiOtvet { get; set; }

        public Testtt(string name, string za, string per, string vtor, string tri)
        {
            Name = name;
            Zadanie = za;
            Perotvet = per;
            VtorOtvet = vtor;
            TritiOtvet = tri;

        }


    }
}
