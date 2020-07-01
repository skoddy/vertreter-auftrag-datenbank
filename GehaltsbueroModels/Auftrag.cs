using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gehaltsbuero.Models
{
    public class Auftrag : DBObject
    {
        public Auftrag () { }

        public Auftrag(Vertreter vertreter)
        {
            Vertreter = vertreter;
            VertreterName = $"{vertreter.Vorname} {vertreter.Nachname}"; ;
        }

        public Guid VertreterId { get; set; }
        public string Auftragsnummer { get; set; } = "AAAAA";
        public Vertreter Vertreter { get; set; }
        public string VertreterName { get; set; }
        public List<Posten> Posten { get; set; } = new List<Posten>();
        public decimal Summe => Posten.Sum(posten => posten.Produkt.Preis);
    }
}
