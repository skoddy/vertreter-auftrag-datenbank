using Gehaltsbuero.Models;

namespace Gehaltsbuero.Models
{
    public class Produkt : DBObject
    {
        public string Name { get; set; }
        public decimal Preis { get; set; }
        public override string ToString() => $"{Name}: {Preis}";
    }
}
