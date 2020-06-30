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
            var current =  _db.Vertreter.FirstOrDefault(_vertreter => _vertreter.Id == vertreter.Id);
            if (null == current)
            {
                _db.Vertreter.Add(vertreter);
            }
            else
            {
                _db.Entry(current).CurrentValues.SetValues(vertreter);
            }
            _db.SaveChanges();
            return vertreter;
        }
    }
}
