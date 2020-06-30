using Gehaltsbuero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gehaltsbuero.Repository.Sql
{
    public class SqlVertreterRepository : IVertreterRepository
    {
        private readonly GehaltsbueroContext _db;

        public SqlVertreterRepository(GehaltsbueroContext db)
        {
            _db = db;
        }
        public void DeleteAsync(Guid vertreterId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vertreter> Get()
        {
            return _db.Vertreter.ToList();
        }

        public Vertreter Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Vertreter Upsert(Vertreter vertreter)
        {
            throw new NotImplementedException();
        }
    }
}
