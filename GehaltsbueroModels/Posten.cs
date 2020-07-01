using System;

namespace Gehaltsbuero.Models
{
    public class Posten : DBObject
    {
        public Guid AuftragId { get; set; }
        public Auftrag Auftrag { get; set; }
        public Produkt Produkt { get; set; }
    }
}
