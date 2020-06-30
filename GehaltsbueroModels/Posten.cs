using System;

namespace Gehaltsbuero.Models
{
    public class Posten : DBObject
    {
        public Guid AuftragsId { get; set; }
        public Auftrag Auftrag { get; set; }
        public Produkt Leistung { get; set; }
    }
}
