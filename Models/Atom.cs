using System.ComponentModel;

namespace myapp.Models
{
    public class Atom
    {
        public int AtomNumarasi { get; set; }
        public string AtomAdi { get; set; }
        public string AminoasitAdi { get; set; }
        public char ZincirTamamlayici { get; set; }
        public int AminoasitSiraNumarasi { get; set; }
        public float XKoordinati { get; set; }
        public float YKoordinati { get; set; }
        public float ZKoordinati { get; set; }
        public float DolulukOrani { get; set; }
        public float SicaklikFaktoru { get; set; }

        public string toString() { return AtomAdi + " " + AtomNumarasi + " " + XKoordinati; }
    }
}