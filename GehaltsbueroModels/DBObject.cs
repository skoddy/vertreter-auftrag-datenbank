using System;

namespace Gehaltsbuero.Models
{
    /// <summary>
    /// Basis Klasse für Datenbank Entitäten.
    /// </summary>
    public class DBObject
    {
        /// <summary>
        /// Setzt oder gibt eine Datenbank Id zurück.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
