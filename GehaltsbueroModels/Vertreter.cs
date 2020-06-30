using System;

namespace Gehaltsbuero.Models
{
    /// <summary>
    /// Stellt einen Vertreter dar.
    /// </summary>
    public class Vertreter : DBObject, IEquatable<Vertreter>
    {
        /// <summary>
        /// Setzt oder gibt den Vornamen zurück.
        /// </summary>
        public string Vorname { get; set; }

        /// <summary>
        /// Setzt oder gibt den Nachnamen zurück.
        /// </summary>
        public string Nachname { get; set; }

        /// <summary>
        /// Gibt den vollständigen Namen zurück.
        /// </summary>
        /// <returns>Vollständiger Name</returns>
        public override string ToString() => $"{Vorname} {Nachname}";

        public bool Equals(Vertreter other) =>
            Vorname == other.Vorname &&
            Nachname == other.Nachname;
    }
}
