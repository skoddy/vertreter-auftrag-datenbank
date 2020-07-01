using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gehaltsbuero.Repository
{
    public interface IAuftragRepository
    {

        IEnumerable<Auftrag> Get();

        Auftrag Get(Guid guid);

        IEnumerable<Auftrag> Get(string search);

        IEnumerable<Auftrag> GetForVertreter(Guid guid);

        Auftrag Upsert(Auftrag auftrag);

        void Delete(Guid guid);
    }
}
