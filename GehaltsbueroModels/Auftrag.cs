using Gehaltsbuero.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gehaltsbuero
{
    public class Auftrag : DBObject
    {
        public Auftrag () { }

        public Auftrag(Vertreter vertreter)
        {
            Vertreter = vertreter;
            VertreterName = $"{vertreter.Vorname} {vertreter.Nachname}"; ;
        }

        public string AuftragsNummer { get; set; } = "AAAAA";
        public Vertreter Vertreter { get; set; }
        public string VertreterName { get; set; }
        public List<Posten> Posten { get; set; } = new List<Posten>();
        public decimal Summe => Posten.Sum(posten => posten.Leistung.Preis);
    }
}
