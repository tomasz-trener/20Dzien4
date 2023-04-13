using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07DataBinding
{
  
    internal class Zawodnik
    {
        public int Id_zawodnika { get; set; }
        public int? Id_trenera { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Kraj { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public int Wzrost { get; set; }
        public int Waga { get; set; }   

        public string ImieNazwiskoKraj
        {
            get
            {
                return $"{Imie} {Nazwisko} ({Kraj})";
            }
        }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }

        public char this[int a]
        {
            get
            {
                return Nazwisko[a];
            }
        }

        public string DynamicznaWlasciwosc
        {
            get
            {
                string s = "";
                foreach (var k in WyswietlaneKolumny)
                    s += this[k] + " ";

                return s;
            }
        }

        public static string[] WyswietlaneKolumny { get; set; } 
    }
}
