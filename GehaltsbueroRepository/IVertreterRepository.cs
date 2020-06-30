using System;
using System.Collections.Generic;

namespace Gehaltsbuero.Models
{
    public interface IVertreterRepository
    {
        IEnumerable<Vertreter> Get();

        Vertreter Get(Guid guid);

        Vertreter Upsert(Vertreter vertreter);

        void DeleteAsync(Guid vertreterId);
    }
}
