using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gehaltsbuero.Repository
{
    public interface IGehaltsbueroRepository
    {
        IVertreterRepository Vertreter { get; }
    }
}
